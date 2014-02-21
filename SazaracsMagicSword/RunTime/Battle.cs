using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;
using SazaracsMagicSword.Data;
using System.Threading;

namespace SazaracsMagicSword.RunTime
{
    class Battle
    {
        string boxRow = new string(' ', 35);
        string[] message = { "", "", "" };
        int totalHeroHP;
        int totalEnemyHP;
        int currentHeroHP;
        int currentEnemyHP;
        bool enemyIsCrippled;
        bool escapeSuccessful;
        Hero hero;
        Enemy enemy;

        public void StartBattle(Hero TheHero, Enemy TheEnemy)
        {
            hero = TheHero;
            enemy = TheEnemy;

            totalHeroHP = hero.statistics.hitPoints;
            currentHeroHP = totalHeroHP;
            totalEnemyHP = enemy.statistics.hitPoints;
            currentEnemyHP = totalEnemyHP;
            DrawBattle(hero, enemy);

            while (currentHeroHP > 0 && currentEnemyHP > 0)
            {
                ProcessInput(Console.ReadKey());
                Thread.Sleep(1000);
                DrawBattle(hero, enemy);
                if (escapeSuccessful)
                {
                    break;
                }
                if (currentEnemyHP < 1)
                {
                    break;
                }
                EnemyAttack();
                Thread.Sleep(1000);
                DrawBattle(hero, enemy);

                enemyIsCrippled = false;
            }

        }
        void DrawBattle(Hero hero, Enemy enemy)
        {
            Drawer draw = new Drawer();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            int heroLifeBarBlocks = (int)(20 * (double)currentHeroHP / totalHeroHP);
            int enemyLifeBarBlocks = (int)(20 * (double)currentEnemyHP / totalEnemyHP);

            draw.DrawString(hero.Name, ConsoleColor.DarkGray, 2, 5);
            draw.DrawString(new string(' ', 20), ConsoleColor.Black, 3, 15);
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
            draw.DrawString(new string(' ', 20), ConsoleColor.Black, 3, 65);
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
        void ProcessInput(ConsoleKeyInfo pressedKey)
        {
            if (pressedKey.Key.Equals(ConsoleKey.A))
            {
                int damage = hero.weapon.damage;
                damage = damage * hero.statistics.strength / 15;
                damage = (int)((double)damage / enemy.statistics.dextirity * 15);
                currentEnemyHP -= damage;
                AddMessage(hero.Name + " used " + hero.weapon.name + " (" + damage + ")");
                DrawDamage(true);
            }
            else if (pressedKey.Key.Equals(ConsoleKey.S))
            {
                DiceRoller dice = new DiceRoller();

                int damage = hero.weapon.magic.damage;
                damage = damage * hero.statistics.willpower / 15;
                int damageOnSelf = hero.weapon.magic.damageOnSelf;
                damageOnSelf = damageOnSelf * hero.statistics.willpower / 15;

                damage = (int)((double)damage / enemy.statistics.dextirity * 15);

                currentEnemyHP -= damage;
                currentHeroHP -= damageOnSelf;

                if (currentHeroHP > totalHeroHP)
                {
                    currentHeroHP = totalHeroHP;
                }
                if (hero.weapon.magic.crippleFoe)
                {
                    enemyIsCrippled = dice.NewDice(hero.weapon.magic.chanceToCrippleFoe);
                }

                AddMessage(hero.Name + " used " + hero.weapon.magic.Name + " (" + damage + " / " + damageOnSelf + ")");
                DrawDamage(true);
            }
            else if (pressedKey.Key.Equals(ConsoleKey.E))
            {
                DiceRoller dice = new DiceRoller();
                if (dice.NewDice(enemy.chanceToEscape))
                {
                    escapeSuccessful = true;
                }
            }
            else ProcessInput(Console.ReadKey());
        }
        void EnemyAttack()
        {

            if (!enemyIsCrippled)
            {
                int damage = enemy.weapon.damage;
                damage = damage * (enemy.statistics.strength + enemy.statistics.dextirity + enemy.statistics.willpower) / 30;
                damage = (int)((double)damage / hero.statistics.dextirity * 15);

                currentHeroHP -= damage;
                AddMessage(enemy.Name + " used " + enemy.weapon.name + " (" + damage + ")");

                DrawDamage(false);
            }
            else
            {
                AddMessage(enemy.Name + " can not move");
            }
            
        }

        void AddMessage(string str)
        {
            message[2] = message[1];
            message[1] = message[0];
            message[0] = str;
        }

        void DrawDamage(bool damageOnEnemy)
        {
            Drawer draw = new Drawer();
            Images img = new Images();
            Console.ForegroundColor = ConsoleColor.Red;
            
            if (damageOnEnemy)
            {
                draw.DrawImageWithoutSpaces(img.Damage, 5, 55);
            }
            else
            {
                draw.DrawImageWithoutSpaces(img.Damage, 5, 5);
            }
            Console.ResetColor();
        }
    }
}
