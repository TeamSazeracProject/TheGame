using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.GameObjects
{
    class NPC : Human
    {
        List<string> conversation;

        public NPC(string Name, List<string> conversation)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Name is empty");
            }
            if (conversation.Count == 0)
            {
                throw new ArgumentException("Conversation is empty");
            }
            this.Name = Name;
            this.conversation = conversation;
        }
    }
}
