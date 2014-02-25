using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.GameObjects
{  [Serializable]
    public struct Statistics
    {
        public int strength;
        public int dexterity;
        public int willpower;
        public int hitPoints;

        public Statistics(int str, int dex, int will)
        {
            this.strength = str;
            this.dexterity = dex;
            this.willpower = will;

            this.hitPoints = this.strength * 4 + this.dexterity * 3 + this.willpower * 2;
        }
        public int RefreshHP()
        {
            return this.strength * 4 + this.dexterity * 3 + this.willpower * 2;
        }
    }
}
