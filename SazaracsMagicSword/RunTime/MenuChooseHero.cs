using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;
using SazaracsMagicSword.Data;

namespace SazaracsMagicSword.RunTime
{
    class MenuChooseHero
    {
        Hero hero;
        int choice;

        public Hero ChooseHeroFromConsole() /// Will be a more complex menu with a few choices in it
        {
            choice = 1;
            ChangeHero();

            DrawChooseHeroFromConsole(choice, hero);
            ConsoleKeyInfo pressedKey = Console.ReadKey();

            while (!pressedKey.Key.Equals(ConsoleKey.Enter))
            {
                if (pressedKey.Key.Equals(ConsoleKey.UpArrow))
                {
                    if (choice > 1)
                    {
                        choice--;
                        ChangeHero();
                    }
                    else
                    {
                        choice = 3;
                        ChangeHero();
                    }
                }
                else if (pressedKey.Key.Equals(ConsoleKey.DownArrow))
                {
                    if (choice < 3)
                    {
                        choice++;
                        ChangeHero();
                    }
                    else
                    {
                        choice = 1;
                        ChangeHero();
                    }
                }
                DrawChooseHeroFromConsole(choice, hero);
                pressedKey = Console.ReadKey();
            }
            hero.Name = GetHeroName();
            return hero;
        }
        private void ChangeHero()
        {
            HeroTypes types = new HeroTypes();

            switch (choice)
            {
                case 1: hero = types.Warrior(); break;
                case 2: hero = types.Rogue(); break;
                case 3: hero = types.Mage(); break;
                default: break;
            }
        }
        private string GetHeroName()
        {
            Drawer draw = new Drawer();
            draw.DrawString("Name your hero:", ConsoleColor.DarkGray, 10, 45);
            Console.SetCursorPosition(62, 10);
            Console.ResetColor();
            string name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.SetCursorPosition(62, 10);
                name = Console.ReadLine();
            }
            return name;
        }
        private void DrawChooseHeroFromConsole(int choice, Hero hero)
        {
            Drawer draw = new Drawer();
            string choicePointer = "==>";

            Console.ResetColor();
            Console.Clear();

            draw.DrawString("Choose your hero!", ConsoleColor.Black, 5, 5);

            draw.DrawString("Warrior", ConsoleColor.Black, 8, 8);
            draw.DrawString("Rogue", ConsoleColor.Black, 10, 8);
            draw.DrawString("Mage", ConsoleColor.Black, 12, 8);

            draw.DrawString(choicePointer, ConsoleColor.DarkMagenta, (6 + choice * 2), 4);

            draw.DrawImage(hero.image,ConsoleColor.Black,15,4);

            draw.DrawString("Strength: " + hero.statistics.strength, ConsoleColor.Black, 33, 45);
            draw.DrawString("Dexterity: " + hero.statistics.dexterity, ConsoleColor.Black, 35, 45);
            draw.DrawString("Willpower: " + hero.statistics.willpower, ConsoleColor.Black, 37, 45);

            draw.DrawString("Weapon: " + hero.weapon.name, ConsoleColor.Black, 20, 45);
            draw.DrawString("Weapon Damage: " + hero.weapon.damage, ConsoleColor.Black, 21, 45);

            draw.DrawString("Magic: " + hero.weapon.magic.Name, ConsoleColor.Black, 23, 45);
            draw.DrawString("Magic Damage: " + hero.weapon.magic.damage, ConsoleColor.Black, 24, 45);
            draw.DrawString("Magic Damage on Self: " + hero.weapon.magic.damageOnSelf, ConsoleColor.Black, 24, 45);
            draw.DrawString("Magic Chance to Stun: " + hero.weapon.magic.chanceToStun, ConsoleColor.Black, 24, 45);

            Console.SetCursorPosition(0, 0);
        }
    }
}
