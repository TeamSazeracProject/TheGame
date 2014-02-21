using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;

namespace SazaracsMagicSword.RunTime
{
    class Battle
    {
        public void StartBattle(Hero hero, Enemy enemy)
        {
            DrawBattle(hero, enemy);

            Console.ReadLine();
        }
        public void DrawBattle(Hero hero, Enemy enemy)
        {
            Drawer draw = new Drawer();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            
            draw.DrawString("",,)
            draw.DrawImage(hero.image, 5, 5);

            draw.DrawImage(enemy.image, 5, 55);

        }
    }
}
