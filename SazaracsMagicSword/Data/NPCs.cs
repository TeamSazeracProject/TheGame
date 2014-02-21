﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;

namespace SazaracsMagicSword.Data
{
    class NPCs
    {
        static Images imgs = new Images();

        public List<NPC> npcList = new List<NPC>{
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
            imgs.Dog),
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
            imgs.HumanWithSword),
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
            imgs.HumanOld),
        // 3 "The Boring Guy"
        new NPC("The Boring Guy",
            new List<string>{"You see an grown man, greeting you with a smiling face",
            "Then he comes your way.",
            "And he starts speaking about some curse...",
            "And he starts speaking about some curse... and about some generations doing something...",
            "And about some planets...",
            "And about some planets... and an eclipse...",
            "You don't really understand anything, but you nod your head every time.",
            "You start to wonder when this will be over.",
            "Gues what?",
            "Gues what? It's not gonna be today.",
            "...",
            "You spend the whole day and the whole night, listening to the boring smart man.",
            "Now you feel smart too, becouse you finally started understanding what he meant.",
            "You say 'Goodbie' and start walking away",
            "You say 'Goodbie' and start walking away, and as you turn your back on the men, you immidiatly forget everything he've told you so far.",
            "You feel stupid again..."
            },
            imgs.HumanOld),
        // 4 "The Smith"
        new NPC("The Smith",
            new List<string>{"You see a muscular smith at his workplace. He's quite busy, but he stops to greet you politly.",
                "The Armour Smith: Choose a weapon to buy or Get Lost!",
                "You: I'm not really sure what I want.",
                "The Smith: Then get lost.",
                "You: How much does that sword over there cost?",
                "The Smith: 5 silver coins.",
                "You: I don't have that kind of money.",
                "The Smith: What kind of money do you have then?",
                "You: I have 3 copper coins and a lady bug.",
                "The Smith: Then Get Lost!",
                "You: Okey, okey! Sheesh...",
                "You: Okey, okey! Sheesh... I don't even have an inventory, but he's yelling at me, as if I'm a theef.",
                "You leave him alone.",
            },
            imgs.HumanWithTwoSabers
            ),
        // 5 "The Assassin"
        new NPC("The Assassin",
            new List<string>{"You see a shady person, and your wallet in his hand. When did he manage to take it from you?",
                "He's not just a thief however. He's an assassin, and his tools of trade are an arcenal of hidden weapons.",
                "The Assassin: Need some help, with them enemyes, syre?",
                "You: I don't have any money, since you took them from me.",
                "The Assassin: You call 'this' money? If so, then I guess you can not afford to use my help.",
                "You: But why did the developers place you hire, if I can not possibly hire you?",
                "The Assassin: Maybe they wanted me to kill you? Did you anger then somehow?",
                "You: No, this can't be it. They are not like that. They are nice guys.",
                "The Assassin: Then why don't you have any money?",
                "You: Becouse...",
                "The Assassin: I think what they wanted to do is to make fun of you, by putting you next to someone like me.",
                "The Assassin: You get it? They put a professional loser next to proffesional killer.",
                "The Assassin: You must've really pissed them off somehow.",
                "You leave him alone and start crying like a little girl.",
            },
            imgs.HumanWithSword
            ),
        // 6 "The Angry Man"
        new NPC("The Angry Man",
            new List<string>{"You see a man, who's very angry.",
            "He's angry, becouse the developers didn't give him any personality",
            "'Leave me alone' he shouts and throws a rock at your dirrection.",
            "You decide to leave him like that."
            },
            imgs.HumanWithSword),
        // 7 "The Troll"
        new NPC("The Troll",
            new List<string>{"You see a VERY rich man. He has gold all over himself.",
            "But there's something else about him...",
            "He's laughing at you!",
            "He's laughing at you! He's a troll.",
            "He's laughing at you! He's a troll. And there's nothing you can do about that.",
            "The Troll: Hi! Wanna come in my House and rob me?",
            "The Troll: But you can't can you?",
            "The Troll: The developers were too lazy to permit you the option of entering a building.",
            "The Troll: I have so much gold and valuables in my home. It's enough to but a small country.",
            "The Troll: And you can't even tuch it!",
            "The Troll: Maaan, You Are So Lame!",
            "The Troll: Lame, lame, lame.",
            "You leave him alone and start crying like a little girl.",
            },
            imgs.HumanOld),
        // 8 "The Drunk"
        new NPC("The Drunk",
            new List<string>{"You see a drinking man at 11 a'clock. He looks very poor.",
            "The Drunk: Hi! Wanna drink some of my booze?",
            "You: No, thank...s..glup,glup...",
            "Before you had any time to respond, he simply emptyed his bottle in your throat.",
            "It stings like hell.",
            "At the next morning, you wake with a bad hangover and you're not really sure what your second name was."
            },
            imgs.HumanOld),
        // 9 "The Guardian"
        new NPC("The Guardian",
            new List<string>{"You see a city guard and he sees you.",
            "'Be carefull out there' he sais and points to the horizon.",
            "'It's very dangerous' he adds.",
            "You thank him for the warning."
            },
            imgs.HumanWithSword)
        
        };
    }
}
