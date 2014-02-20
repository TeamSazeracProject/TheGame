using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;

namespace SazaracsMagicSword.Data
{
    class NPCs
    {
        List<NPC> npcList = new List<NPC>{
        // 0 "Filthy Dog"
        new NPC("Filthy Dog",
            new List<string>{"You see a filthy dog lying on the ground and eating some sort of a banana bread.",
                "You lean towards the dog and politly greet it with 'Hallo'.",
                "It ignores you compleatly.",
                "Feeling lucky, you decide to pet the dog",
                "'Rrrrrr...'",
                "The dog barks at you with evil red eyes.",
                "'Waf, Waf, Waf!!!'",
                "You decide to leave."
            },
            ""),
        // 1 "Quest Giver"
        new NPC("The Quest Giver",
            new List<string>{"You see a man who looks troulbled.",
            "He's waving at people to come and listen to him, but nobody stops by.",
            "...except you...",
            "Quest Giver: Greetings, My friend. Are you looking for a quest, perchance?",
            "You: Mayhap. What do you offer?",
            "Quest Giver: I need you to collect 5 yellow ants from the shores of Mahmar sea.",
            "You: What!? ",
            "You: What!? That place is 5 days away on a horce back! ",
            "You: What!? That place is 5 days away on a horce back!\nAnd it's creeping with evil demons!",
            "Quest Giver: I really need those ants.",
            "You: Look. I'm sory. This game doesn't have a quest system yet.\nIt's imposible for me to take on your request.",
            "Quest Giver: Yeah, right. Like I'll bite that!",
            "You decide to leave the men alone. Let him find someone else to trouble."
            },
            ""),
        // 2 "The Witch"
        new NPC("The Witch",
            new List<string>{"You see an old woman with tight black clothes and a pointy hat.",
            "The Witch: Come here, boy. I'll aid your wounds",
            "The Witch: Come here, boy. I'll aid your wounds for nothing more than a silver coin.",
            "You: I'm not really wounded.",
            "The Witch: Then you are not really a hero!",
            "The Witch: Go get yourself wounded, boy!",
            "The Witch: And then come back to me.",
            "You: No... actually I simply can not get injured.",
            "The Witch: Why?",
            "You: Becouse the developers of the game didn't implement such an option.",
            "The Witch: They are a bunch of lazy assholes, aren't they?",
            "You: I woudn't say it like that...",
            "You: I woudn't say it like that... but yes, they are."
            },
            ""),
        // 3 "The Boring Guy"
        new NPC("The Boring Guy",
            new List<string>{"You see an grown man, greeting you with a smiling face",
            "Then he comes your way.",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
            },
            ""),
        // 4
        // 5
        // 6
        // 7
        // 8
        // 9
        
        
        
        
        
        };
    }
}
