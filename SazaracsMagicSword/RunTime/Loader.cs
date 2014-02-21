﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;
using SazaracsMagicSword.Data;

namespace SazaracsMagicSword.RunTime
{
    class Loader
    {
        static int sizeOfVisualElements = 1;

        public VisualElement[,] LoadVisibleLevel(VisualElement[,] VisibleMatrix, VisualElement[,] matrix, Hero hero)
        {
            VisualElements VisualLoader = new VisualElements();


            VisibleMatrix[VisibleMatrix.GetLength(0) / 2, VisibleMatrix.GetLength(1) / 2] = VisualLoader.Hero(1);
            for (int r2 = 0; r2 < VisibleMatrix.GetLength(0); r2++)
            {
                for (int c2 = 0; c2 < VisibleMatrix.GetLength(0); c2++)
                {
                    int actualPositionRow = hero.position.row - VisibleMatrix.GetLength(0) / 2 + r2;
                    int actualPositionCol = hero.position.col - VisibleMatrix.GetLength(0) / 2 + c2;

                    if (actualPositionRow >= 0 ||
                        actualPositionRow > matrix.GetLength(0) ||
                        actualPositionCol >= 0 ||
                        actualPositionCol > matrix.GetLength(1))
                    {
                        VisibleMatrix[r2, c2] = VisualLoader.Empty(sizeOfVisualElements);
                    }
                    else
                    {
                        VisibleMatrix[r2, c2] = matrix[actualPositionRow, actualPositionCol];
                    }
                }
            }
            return VisibleMatrix;
        }

        public VisualElement[,] LoadLevel(VisualElement[,] matrix, string[] level, Hero hero)
        {
            Dangers dangers = new Dangers();
            VisualElements VisualLoader = new VisualElements();

            List<DangerousTerritory> dangersOnThisLevel = dangers.Level1Dangers;
            switch (hero.level)
            {
                case 1: dangersOnThisLevel = dangers.Level1Dangers; break;
                case 2: dangersOnThisLevel = dangers.Level2Dangers; break;
                case 3: dangersOnThisLevel = dangers.Level3Dangers; break;
                default: break;
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (level[r][c].Equals(' '))
                    {
                        matrix[r, c] = VisualLoader.Grass(sizeOfVisualElements);
                    }
                    else if (level[r][c].Equals('/'))
                    {
                        matrix[r, c] = VisualLoader.Grass(1);
                        matrix[r, c].content = dangersOnThisLevel[0]; /// will have 1-st enemy
                    }
                    else if (level[r][c].Equals('.'))
                    {
                        matrix[r, c] = VisualLoader.Desert(sizeOfVisualElements);
                        matrix[r, c].content = dangersOnThisLevel[1]; /// will have 2-nd enemy
                    }
                    else if (level[r][c].Equals('+'))
                    {
                        matrix[r, c] = VisualLoader.Grass(sizeOfVisualElements);
                        matrix[r, c].content = dangersOnThisLevel[2]; /// will have 3-rd enemy
                    }
                    else if (level[r][c].Equals('#'))
                    {
                        matrix[r, c] = VisualLoader.Rock(sizeOfVisualElements);
                    }
                    else if (level[r][c].Equals(':'))
                    {
                        matrix[r, c] = VisualLoader.Grass(sizeOfVisualElements);
                    }
                    else if (level[r][c].Equals('*'))
                    {
                        matrix[r, c] = VisualLoader.Rock(sizeOfVisualElements); /// Will be chest
                    }
                    else if (char.IsDigit(level[r][c]))
                    {
                        matrix[r, c] = VisualLoader.NPC(sizeOfVisualElements); /// will be NPC
                    }
                    else if (level[r][c].Equals('\''))
                    {
                        matrix[r, c] = VisualLoader.Desert(sizeOfVisualElements); /// will be BOSS
                    }
                    else if (level[r][c].Equals('H'))
                    {
                        matrix[r, c] = VisualLoader.Grass(sizeOfVisualElements);
                        hero.position = new Position(r, c);
                    }
                }
            }

            return matrix;
        }
    }
}
