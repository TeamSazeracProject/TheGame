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
        static Levels levels = new Levels();
        static Menus menu = new Menus();
        static Hero hero;
        static VisualElement[,] matrix = new VisualElement[levels.height, levels.width];

        static void Main(string[] args)
        {
            // --- MyPlan

            //1) Main menu (new game / load game)
            hero = menu.ChooseHeroFromConsole();

            //2) Dynamic game
            matrix = load.LoadLevel(matrix, levels.Level1);
            

            //3) In-game menu

            //4) Conversations

            //5) Battles

            //6) Levels

            //7) Tests
        }
    }
}
