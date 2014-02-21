﻿using System;
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
        static List<NPC> NPCsOfCurrentLevel = new List<NPC>();

        static int height = 9, width = 13;
        static VisualElement[,] VisibleMatrix = new VisualElement[height, width];

        static void Main(string[] args)
        {
            Console.WindowHeight = 50;
            Console.WindowWidth = 90;

            // --- MyPlan

            //1) Main menu (new game / load game)
            hero = menu.ChooseHeroFromConsole();

            //2) Dynamic game
            matrix = load.LoadLevel(matrix, levels.Level1, hero, NPCsOfCurrentLevel);
            //VisibleMatrix = load.LoadVisibleLevel(VisibleMatrix, matrix, hero); // throws an exception...
            draw.DrawMatrixInConsole(matrix);
            while (true)
            {

                draw.DrawHero(hero);
                Console.SetCursorPosition(80, 0);
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                if (pressedKey.Key.Equals(ConsoleKey.UpArrow))
                {
                    if (!matrix[hero.position.row - 1, hero.position.col].isSolid)
                    {
                        draw.DrawInConsole(matrix[hero.position.row, hero.position.col], hero.position.row, hero.position.col);
                        hero.Move(Direction.up);
                    }
                }
                else if (pressedKey.Key.Equals(ConsoleKey.DownArrow))
                {
                    if (!matrix[hero.position.row + 1, hero.position.col].isSolid)
                    {
                        draw.DrawInConsole(matrix[hero.position.row, hero.position.col], hero.position.row, hero.position.col);
                        hero.Move(Direction.down);
                    }
                }
                else if (pressedKey.Key.Equals(ConsoleKey.LeftArrow))
                {
                    if (!matrix[hero.position.row, hero.position.col - 1].isSolid)
                    {
                        draw.DrawInConsole(matrix[hero.position.row, hero.position.col], hero.position.row, hero.position.col);
                        hero.Move(Direction.left);
                    }
                }
                else if (pressedKey.Key.Equals(ConsoleKey.RightArrow))
                {
                    if (!matrix[hero.position.row, hero.position.col + 1].isSolid)
                    {
                        draw.DrawInConsole(matrix[hero.position.row, hero.position.col], hero.position.row, hero.position.col);
                        hero.Move(Direction.right);
                    }
                }
            }

            //3) In-game menu

            //4) Conversations

            //5) Battles

            //6) Levels

            //7) Tests
        }
    }
}