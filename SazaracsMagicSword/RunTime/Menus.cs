using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;
using SazaracsMagicSword.Data;

namespace SazaracsMagicSword.RunTime
{
    class Menus
    {
        public Hero ChooseHeroFromConsole() /// Will be a more complex menu with a few choices in it
        {
            Weapons weaps = new Weapons();
            Spells spls = new Spells();

            Weapon wpn =  weaps.WeakWeapons[0];
            wpn.changeMagic(spls.BasicSpells[0]);
            return new Hero(
                "Hero",
                new Statistics(15, 15, 15),
                wpn,
                "",
                new Statistics(5, 5, 5)
                );
        }
    }
}
