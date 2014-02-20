using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;

namespace SazaracsMagicSword.RunTime
{
    class Drawer
    {
        public void DrawMatrixInConsole(VisualElement[,] matrix)
        {
            int currentRow = 0, currentCol = 0;
            int stepsPerRow = matrix[0, 0].ElementMatrix.GetLength(0);
            int stepsPerCol = matrix[0, 0].ElementMatrix.GetLength(1);

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    DrawInConsole(matrix[r, c], currentRow, currentCol);
                    currentCol += stepsPerCol;
                }
                currentRow += stepsPerRow;
                currentCol = 0;
            }
        }

        public void DrawInConsole(VisualElement element, int row, int col)
        {
            for (int r = 0; r < element.ElementMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < element.ElementMatrix.GetLength(1); c++)
                {
                    DrawBrick(element.ElementMatrix[r, c], row + r, col + c);
                }
            }
        }
        private void DrawBrick(VisualBrick brick, int row, int col)
        {
            Console.SetCursorPosition(col, row);
            Console.BackgroundColor = brick.color;
            Console.Write(brick.ch);
        }

    }
}
