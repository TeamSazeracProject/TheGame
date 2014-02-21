using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;

namespace SazaracsMagicSword.RunTime
{
    class Battle
    {
        string whiteBoxRow = new string(' ', 30);
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
                break;
            }

            Console.ReadLine();
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
                draw.DrawString(whiteBoxRow, ConsoleColor.White, 40 + i, 15);
            }
            
            draw.DrawString(enemy.Name, ConsoleColor.DarkGray, 2, 55);
            draw.DrawString(new string(' ', heroLifeBarBlocks), ConsoleColor.DarkRed, 3, 65);
            draw.DrawString(currentEnemyHP + " / " + totalEnemyHP, ConsoleColor.DarkRed, 3, 86);
            draw.DrawImage(enemy.image, ConsoleColor.Black, 5, 55);
            for (int i = 0; i < 7; i++)
            {
                draw.DrawString(whiteBoxRow, ConsoleColor.White, 40 + i, 65);
            }


        }
    }
}
