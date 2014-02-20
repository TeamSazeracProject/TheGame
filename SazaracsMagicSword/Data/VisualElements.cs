using System;
using System.Collections.Generic;
using SazaracsMagicSword.GameObjects;

namespace SazaracsMagicSword.Data
{
    class VisualElements
    {
        Random rnd = new Random();
        public VisualElement Hero()
        {
            VisualElement hero = MakeElement(ConsoleColor.White, 5, 5, ' ', '*', false);
            string[] str = {"  *  ",
                            " *** ",
                            "* * *",
                            "  *  ",
                            " * * "};
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (str[r][c].Equals('*'))
                    {
                        hero.ElementMatrix[r, c].ch = 'M';
                        hero.ElementMatrix[r, c].color = ConsoleColor.Black;
                    }
                }
            }
            return hero;
        }
        public VisualElement Desert()
        {
            return MakeElement(ConsoleColor.Yellow, 5, 5, ' ', '*', false);
        }
        public VisualElement Grass()
        {
            return MakeElement(ConsoleColor.Green, 5, 5, '\\', '*', false);
        }
        public VisualElement Rock()
        {
            return MakeElement(ConsoleColor.DarkGray, 5, 5, '/', '/', true);
        }
        public VisualElement NPC()
        {
            VisualElement npc = MakeElement(ConsoleColor.Magenta, 5, 5, ' ', ' ', true);
            npc.ElementMatrix[2, 1].ch = 'N';
            npc.ElementMatrix[2, 2].ch = 'P';
            npc.ElementMatrix[2, 3].ch = 'C';
            return npc;
        }

        public VisualElement MakeElement(ConsoleColor color, int width, int height, char baseTexture, char randomTexture, bool isSolid)
        {
            VisualBrick[,] visuals = GetVisualsFilledWithColor(color, width, height, baseTexture);
            visuals = GenerateRandomTexture(visuals, '*');
        return new VisualElement(
            visuals,
            null,
            isSolid,
            new Position(0,0)
            );
        }

        public VisualBrick[,] GetVisualsFilledWithColor(ConsoleColor color, int rows, int cols, char ch)
        {
            VisualBrick[,] bricks = new VisualBrick[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    bricks[r, c].color = color;
                    bricks[r, c].ch = ch;
                }
            }
            return bricks;
        }
        public VisualBrick[,] GenerateRandomTexture(VisualBrick[,] bricks, char ch)
        {
            int row = rnd.Next(0, bricks.GetLength(0));
            int col = rnd.Next(0, bricks.GetLength(1));

            bricks[row, col].ch = ch;

            return bricks;
        }
    }
}
