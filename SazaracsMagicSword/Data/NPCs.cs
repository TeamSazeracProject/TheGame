using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;

namespace SazaracsMagicSword.Data
{
    class NPCs
    {
        static Images imgs = new Images();

        public List<NPC> npcList = new List<NPC>
        {
            // 0 "Filthy Dog"
            new NPC("Filthy Dog", imgs.Dog),
            // 1 "Quest Giver"
            new NPC("The Quest Giver",imgs.HumanWithSword),
            // 2 "The Witch"
            new NPC("The Witch",imgs.HumanOld),
            // 3 "The Boring Guy"
            new NPC("The Boring Guy",imgs.HumanOld),
            // 4 "The Smith"
            new NPC("The Smith",imgs.HumanWithTwoSabers),
            // 5 "The Assassin"
            new NPC("The Assassin",imgs.HumanWithSword),
            // 6 "The Angry Man"
            new NPC("The Angry Man",imgs.HumanWithSword),
            // 7 "The Troll"
            new NPC("The Troll", imgs.HumanOld),
            // 8 "The Drunk"
            new NPC("The Drunk",imgs.HumanOld),
            // 9 "The Guardian"
            new NPC("The Guardian", imgs.HumanWithSword)
        
        };

    }
}
