using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;

namespace SazaracsMagicSword.RunTime
{
    class Conversation
    {
        public void DrawConversation(Hero hero, NPC npc)
        {
            Drawer draw = new Drawer();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            draw.DrawImage(hero.image, 5, 5);
            draw.DrawImage(npc.image, 5, 55);

            Console.ReadLine();
            Console.Clear();
            // the matrix must be rewriten now
        }
    }
}
