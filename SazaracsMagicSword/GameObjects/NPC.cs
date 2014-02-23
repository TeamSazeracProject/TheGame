using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.GameObjects
{
    class NPC : Human
    {
        //public List<string> conversation;
        public Position position;
        public string conversationPath;
        public NPC(string Name, string conversationPath, string[] image)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Name is empty");
            }
            if (conversationPath == null)
            {
                throw new ArgumentException("Conversation is empty");
            }
            this.Name = Name;
            this.conversationPath = conversationPath;
            this.image = image;
        }
    }
}
