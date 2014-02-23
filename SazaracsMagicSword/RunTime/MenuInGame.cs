﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;
using System.Threading;

namespace SazaracsMagicSword.RunTime
{
    class MenuInGame
    {
        int choice = 1;
        string whiteSpace = new string(' ', 30);
        string choicePointerLeft = ">>";
        string choicePointerRight = "<<";
        int centerRow = Console.WindowHeight / 2;
        int centerCol = Console.WindowWidth / 2;
        string[] options = { "Resume The Game", "Hero Statistics", "Save Game", "Load Game", "Quit Game" };

        public void Menu(Hero hero)
        {
            DrawMenu();
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            while (!pressedKey.Key.Equals(ConsoleKey.Enter))
            {
                if (pressedKey.Key.Equals(ConsoleKey.UpArrow))
                {
                    if (choice > 1)
                    {
                        choice--;
                        DrawMenu();
                    }
                    else
                    {
                        choice = options.Length;
                        DrawMenu();
                    }
                }
                else if (pressedKey.Key.Equals(ConsoleKey.DownArrow))
                {
                    if (choice < options.Length)
                    {
                        choice++;
                        DrawMenu();
                    }
                    else
                    {
                        choice = 1;
                        DrawMenu();
                    }
                }
                pressedKey = Console.ReadKey();
            }

            switch (choice)
            {
                case 1: return;
                case 2: MenuShowHeroStats(hero); break;
                case 3: throw new NotImplementedException("Saving is not implemented.");
                case 4: throw new NotImplementedException("Loading a Save is not implemented.");
                case 5: Environment.Exit(0); break;
                default:
                    break;
            }
        }

        private void DrawMenu()
        {
            Drawer draw = new Drawer();
            ConsoleColor color = ConsoleColor.White;

            for (int i = 0; i < 15; i++) // draw a box
            {
                draw.DrawString(whiteSpace, color, (centerRow - 5) + i, (centerCol - whiteSpace.Length / 2));
            }
            for (int i = 1; i <= 3; i++) // draw on top
            {
                draw.DrawString(whiteSpace, ConsoleColor.Red, (centerRow - 5) - i, (centerCol - whiteSpace.Length / 2));
            }

            string message = "Game Paused";
            draw.DrawString(message, ConsoleColor.Red, (centerRow - 5) - 2, (centerCol - message.Length / 2));

            for (int i = 1; i <= options.Length; i++)
            {
                draw.DrawString(options[i - 1], color, (centerRow - 5) + 2 * i, (centerCol - options[i - 1].Length / 2));
            }
            draw.DrawString(choicePointerLeft, color, (centerRow - 5) + 2 * choice, (centerCol - options[choice - 1].Length / 2) - choicePointerLeft.Length - 1);
            draw.DrawString(choicePointerRight, color, (centerRow - 5) + 2 * choice, (centerCol + options[choice - 1].Length / 2) + 2);

            Console.SetCursorPosition(0, 0);
        }
        private void MenuShowHeroStats(Hero hero)
        {
            Drawer draw = new Drawer();

            Console.ResetColor();
            Console.Clear();

            draw.DrawString("Name : " + hero.Name, ConsoleColor.Black, 4, 8);
            draw.DrawImage(hero.image, ConsoleColor.Black, 5, 4);

            draw.DrawString("Strength: " + hero.statistics.strength, ConsoleColor.Black, 23, 45);
            draw.DrawString("Dexterity: " + hero.statistics.dexterity, ConsoleColor.Black, 25, 45);
            draw.DrawString("Willpower: " + hero.statistics.willpower, ConsoleColor.Black, 27, 45);

            draw.DrawString("Weapon: " + hero.weapon.name, ConsoleColor.Black, 10, 45);
            draw.DrawString("Weapon Damage: " + hero.weapon.damage, ConsoleColor.Black, 11, 45);

            draw.DrawString("Magic: " + hero.weapon.magic.Name, ConsoleColor.Black, 13, 45);
            draw.DrawString("Magic Damage: " + hero.weapon.magic.damage, ConsoleColor.Black, 14, 45);
            draw.DrawString("Magic Damage on Self: " + hero.weapon.magic.damageOnSelf, ConsoleColor.Black, 15, 45);
            draw.DrawString("Magic Chance to Stun: " + hero.weapon.magic.chanceToStun, ConsoleColor.Black, 16, 45);

            Console.SetCursorPosition(0, 0);

            Console.ReadKey();
        }
    }
}
