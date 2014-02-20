using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;
using SazaracsMagicSword.Data;

namespace SazaracsMagicSword.RunTime
{
    class Loader
    {
        public VisualElement[,] LoadLevel(VisualElement[,] matrix, string[] level)
        {
            VisualElements VisualLoader = new VisualElements();

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (level[r][c].Equals(' '))
                    {
                        matrix[r, c] = VisualLoader.Grass();
                    }
                    else if (level[r][c].Equals('/'))
                    {
                        matrix[r, c] = VisualLoader.Grass(); /// will have 1-st enemy
                    }
                    else if (level[r][c].Equals('.'))
                    {
                        matrix[r, c] = VisualLoader.Desert(); /// will have 2-nd enemy
                    }
                    else if (level[r][c].Equals('+'))
                    {
                        matrix[r, c] = VisualLoader.Grass(); /// will have 3-rd enemy
                    }
                    else if (level[r][c].Equals('#'))
                    {
                        matrix[r, c] = VisualLoader.Rock();
                    }
                    else if (level[r][c].Equals(':'))
                    {
                        matrix[r, c] = VisualLoader.Grass();
                    }
                    else if (level[r][c].Equals('*'))
                    {
                        matrix[r, c] = VisualLoader.Rock(); /// Will be chest
                    }
                    else if (char.IsDigit(level[r][c]))
                    {
                        matrix[r, c] = VisualLoader.NPC(); /// will be NPC
                    }
                    else if (level[r][c].Equals('\''))
                    {
                        matrix[r, c] = VisualLoader.Desert(); /// will be BOSS
                    }
                }
            }

            return matrix;
        }
    }
}
