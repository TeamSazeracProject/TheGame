using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;

namespace SazaracsMagicSword.Data
{
    class HeroTypes
    {
        Weapons weaps = new Weapons();
        Spells spls = new Spells();
        Images imgs = new Images();

        public Hero Warrior()
        {
            Weapon weap = weaps.WeakWeapons[2]; // Hammer
            weap.changeMagic(spls.BasicSpells[0]); // of Flash

            return new Hero("hero",
                new Statistics(25, 10, 5),
                weap,
                imgs.HumanWithShieldAndBigSword,
                new Statistics(10, 5, 0)
                );
        }
        public Hero Rogue()
        {
            Weapon weap = weaps.WeakWeapons[1]; // short sword
            weap.changeMagic(spls.BasicSpells[2]); // of Freeze

            return new Hero("hero",
                new Statistics(10, 20, 10),
                weap,
                imgs.HumanWithTwoSabers,
                new Statistics(3, 9, 3)
                );
        }
        public Hero Mage()
        {
            Weapon weap = weaps.WeakWeapons[0]; // Knive
            weap.changeMagic(spls.BasicSpells[1]); // of Fireball

            return new Hero("hero",
                new Statistics(5, 10, 25),
                weap,
                imgs.HumanWithStaff,
                new Statistics(0, 5, 10)
                );
        }
        public Hero Cheater()
        {
            Weapon weap = new Weapon("Tester's Sword", 100, new Magic("Tester's Magic", 50, 50, 0.6));
            return new Hero("Cheater",
                new Statistics(50, 50, 50),
                weap,
                imgs.HumanInFlame,
                new Statistics(20, 20, 20)
                );
        }
    }
}