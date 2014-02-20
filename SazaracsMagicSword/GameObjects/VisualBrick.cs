using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.GameObjects
{
    public struct VisualBrick
    {
        ConsoleColor color;
        char ch;
        
        public VisualBrick (ConsoleColor color, char ch) : this()
        {
            this.color = color;
            this.ch = ch;
        }
    }
}
