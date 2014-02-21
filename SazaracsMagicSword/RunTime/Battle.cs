using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;
using System.Threading;

namespace SazaracsMagicSword.RunTime
{
    class Battle
    {
        string boxRow = new string(' ', 30);
        string[] message = { "", "", "" };
        int totalHeroHP;
        int totalEnemyHP;
        int currentHeroHP;
        int currentEnemyHP;

        public void StartBattle(Hero hero, Enemy enemy)
        {
            totalHeroHP = hero.statistics.hitPoints;
            currentHeroHP = totalHeroHP;
            totalEnemyHP = enemy.statistics.hitPoints;
            currentEnemyHP = totalEnemyHP;
            DrawBattle(hero, enemy);

            while (currentHeroHP > 0 && currentEnemyHP > 0)
            {
                ProcessInput(Console.ReadKey());
                DrawBattle(hero, enemy);
                Thread.Sleep(500);
                EnemyAttack(enemy);
                DrawBattle(hero, enemy);
                Thread.Sleep(500);

                break; // must be removed later;
            }

            Console.ReadKey();
        }
        public void DrawBattle(Hero hero, Enemy enemy)
        {
            Drawer draw = new Drawer();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            
            int heroLifeBarBlocks = (20*currentHeroHP)/totalHeroHP;
            int enemyLifeBarBlocks = (20*currentEnemyHP)/totalEnemyHP;

            draw.DrawString(hero.Name, ConsoleColor.DarkGray, 2, 5);
            draw.DrawString(new string(' ', heroLifeBarBlocks), ConsoleColor.DarkRed, 3, 15);
            draw.DrawString(currentHeroHP + " / " + totalHeroHP, ConsoleColor.DarkRed, 3, 36);
            draw.DrawImage(hero.image, ConsoleColor.Black, 5, 5);
            for (int i = 0; i < 7; i++)
            {
                draw.DrawString(boxRow, ConsoleColor.DarkYellow, 40 + i, 15);
                if (i == 1)
                { draw.DrawString("Press [A] to Attack", ConsoleColor.DarkYellow, 40 + i, 18); }
                else if (i == 3)
                { draw.DrawString("Press [S] to use a Spell", ConsoleColor.DarkYellow, 40 + i, 18); }
                else if (i == 5)
                { draw.DrawString("Press [E] to Escape", ConsoleColor.DarkYellow, 40 + i, 18); }
            }
            
            draw.DrawString(enemy.Name, ConsoleColor.DarkGray, 2, 55);
            draw.DrawString(new string(' ', heroLifeBarBlocks), ConsoleColor.DarkRed, 3, 65);
            draw.DrawString(currentEnemyHP + " / " + totalEnemyHP, ConsoleColor.DarkRed, 3, 86);
            draw.DrawImage(enemy.image, ConsoleColor.Black, 5, 55);
            for (int i = 0; i < 7; i++)
            {
                draw.DrawString(boxRow, ConsoleColor.DarkYellow, 40 + i, 65);

                if (i == 1)
                { draw.DrawString(message[0], ConsoleColor.DarkYellow, 40 + i, 68); }
                else if (i == 3)
                { draw.DrawString(message[1], ConsoleColor.DarkYellow, 40 + i, 68); }
                else if (i == 5)
                { draw.DrawString(message[2], ConsoleColor.DarkYellow, 40 + i, 68); }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void ProcessInput(ConsoleKeyInfo pressedKey)
        {
            if (pressedKey.Key.Equals(ConsoleKey.A))
            {

            }
            else if (pressedKey.Key.Equals(ConsoleKey.S))
            {

            }
            else if (pressedKey.Key.Equals(ConsoleKey.E))
            {

            }
            else ProcessInput(Console.ReadKey());
        }
        public void EnemyAttack(Enemy enemy)
        {
            message[2] = message[1];
            message[1] = message[0];
            message[0] = enemy.Name + " used " + enemy.weapon.name;
        }
    }
}
