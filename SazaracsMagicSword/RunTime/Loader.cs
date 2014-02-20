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
        public VisualElement[,] LoadVisibleLevel(VisualElement[,] VisibleMatrix, VisualElement[,] matrix)
        {
            VisualElements VisualLoader = new VisualElements();

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r,c].heroIsThere)
                    {
                        VisibleMatrix[VisibleMatrix.GetLength(0) / 2, VisibleMatrix.GetLength(1) / 2] = VisualLoader.Hero();
                        for (int r2 = 0; r2 < VisibleMatrix.GetLength(0); r2++)
                        {
                            for (int c2 = 0; c2 < VisibleMatrix.GetLength(0); c2++)
                            {
                                int actualPositionRow = r - VisibleMatrix.GetLength(0) / 2 + r2;
                                int actualPositionCol = c - VisibleMatrix.GetLength(0) / 2 + c2;

                                if (actualPositionRow >= 0 ||
                                    actualPositionRow > matrix.GetLength(0) ||
                                    actualPositionCol >= 0 ||
                                    actualPositionCol > matrix.GetLength(1))
                                {
                                    VisibleMatrix[r2, c2] = VisualLoader.Empty();
                                }
                                else
                                {
                                    VisibleMatrix[r2, c2] = matrix[actualPositionRow,actualPositionCol];
                                }
                            }
                        }
                    }
                }
            }
            return VisibleMatrix;
        }

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
                    else if (level[r][c].Equals('H'))
                    {
                        matrix[r, c] = VisualLoader.Grass();
                        matrix[r, c].heroIsThere = true;
                    }
                }
            }

            return matrix;
        }
    }
}
