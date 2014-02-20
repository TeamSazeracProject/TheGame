using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.RunTime;
using SazaracsMagicSword.GameObjects;
using SazaracsMagicSword.Data;

namespace SazaracsMagicSword
{
    class Start
    {
        static Loader load = new Loader();
        static Drawer draw = new Drawer();
        static Levels levels = new Levels();
        static Menus menu = new Menus();
        static Hero hero;
        static VisualElement[,] matrix = new VisualElement[levels.height, levels.width];

        static int height = 9, width = 13;
        static VisualElement[,] VisibleMatrix = new VisualElement[height, width];

        static void Main(string[] args)
        {
            Console.WindowHeight = height * 5;
            Console.WindowWidth = width * 5;

            // --- MyPlan

            //1) Main menu (new game / load game)
            hero = menu.ChooseHeroFromConsole();

            //2) Dynamic game
            matrix = load.LoadLevel(matrix, levels.Level1);
            VisibleMatrix = load.LoadVisibleLevel(VisibleMatrix, matrix);
            draw.DrawMatrixInConsole(VisibleMatrix); // throws an exception...

            //3) In-game menu

            //4) Conversations

            //5) Battles

            //6) Levels

            //7) Tests
        }
    }
}
