using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;
using System.Threading;

namespace SazaracsMagicSword.RunTime
{
    class Conversation
    {
        public void DrawConversation(Hero hero, NPC npc)
        {
            Drawer draw = new Drawer();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            draw.DrawImage(hero.image, ConsoleColor.Black, 5, 5);
            draw.DrawImage(npc.image, ConsoleColor.Black, 5, 55);
            
            draw.PrintConversation(npc.conversation);

            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            // the matrix must be rewriten now
        }

    }
}
