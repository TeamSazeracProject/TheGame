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
            HeroTypes types = new HeroTypes();
            return types.Warrior();
        }
    }
}
