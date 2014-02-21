using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.GameObjects
{
    class NPC : Human
    {
        
        public Position position;

        public NPC(string Name, string[] image)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Name is empty");
            }
            
            this.Name = Name;
            //this.conversation = conversation;
            this.image = image;
        }
    }
}
