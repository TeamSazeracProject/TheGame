using System;
using System.Collections.Generic;
using SazaracsMagicSword.GameObjects;

namespace SazaracsMagicSword.Data
{
    #region Spells/Magic
    public class Spells
    {
        private List<Magic> basicSpells = new List<Magic>()
        {
            new Magic("Flash", 1, 0, 0.9),
            new Magic("FireBall", 10, 0,  0.1),
            new Magic("Freaze", 5, 0, 0.5)
        };

        private List<Magic> advancedSpells = new List<Magic>()
        {
            new Magic("Heal", 0, -20, 0),
            new Magic("Slow Time", 5, 0, 0.9),
            new Magic("Rock Slide", 15, 0, 0.4)
        };

        private List<Magic> masterSpells = new List<Magic>()
        {
            new Magic("Tornado", 35, 0, 0.2),
            new Magic("Bless", 0, -50, 0.5),
            new Magic("Curse", 50, 10, 0.2)
        };

        //Property is kept for legacy issues
        public List<Magic> BasicSpells { get { return this.basicSpells; } }

        //Property is kept for legacy issues
        public List<Magic> AdvancedSpells { get { return this.advancedSpells; } }

        //Property is kept for legacy issues
        public List<Magic> MasterSpells { get { return this.masterSpells; } }

        public Magic Flash { get { return this.basicSpells[0]; } }
        public Magic FireBall { get { return this.basicSpells[1]; } }
        public Magic Freeze { get { return this.basicSpells[2]; } }
        public Magic Heal { get { return this.advancedSpells[0]; } }
        public Magic SlowTime { get { return this.advancedSpells[1]; } }
        public Magic RockSlide { get { return this.advancedSpells[2]; } }
        public Magic Tornado { get { return this.masterSpells[0]; } }
        public Magic Bless { get { return this.masterSpells[1]; } }
        public Magic Curse { get { return this.masterSpells[2]; } }
    }
    #endregion

    #region Weapons
    public class Weapons
    {
        private List<Weapon> weakWeapons = new List<Weapon>()
        {
            new Weapon("Knive", 5, null),
            new Weapon("Short Sword", 8, null),
            new Weapon("Hammer", 12, null)
        };

        private List<Weapon> averageWeapons = new List<Weapon>()
        {
            new Weapon("Bow", 10, null),
            new Weapon("Sword", 13, null),
            new Weapon("Spear", 18, null)
        };

        private List<Weapon> goodWeapons = new List<Weapon>()
        {
            new Weapon("Revolver", 25, null),
            new Weapon("Holly Sword", 33, null),
            new Weapon("Heavy Hammer", 40, null)
        };

        private List<Weapon> uniques = new List<Weapon>()
        {
            new Weapon("Fork of DOOM", 1, new Magic("DOOM", 70, 20)), // a joke
            new Weapon("Sazarac's Magic Sword", 55, new Magic("Steal Life", 30, -30, 0.3)) // the weapon of the final boss - Sazarac
        };

        //Property is kept for legacy issues
        public List<Weapon> WeakWeapons { get { return this.weakWeapons; } }

        //Property is kept for legacy issues
        public List<Weapon> AverageWeapons { get { return this.averageWeapons; } }

        //Property is kept for legacy issues
        public List<Weapon> GoodWeapons { get { return this.goodWeapons; } }

        //Property is kept for legacy issues
        private List<Weapon> Uniques { get { return this.uniques; } }

        public Weapon Knive { get { return this.weakWeapons[0]; } }
        public Weapon ShortSword { get { return this.weakWeapons[1]; } }
        public Weapon Hammer { get { return this.weakWeapons[2]; } }
        public Weapon Bow { get { return this.averageWeapons[0]; } }
        public Weapon Sword { get { return this.averageWeapons[1]; } }
        public Weapon Spear { get { return this.averageWeapons[2]; } }
        public Weapon Revolver { get { return this.goodWeapons[0]; } }
        public Weapon HollySword { get { return this.goodWeapons[1]; } }
        public Weapon HeavyHammer { get { return this.goodWeapons[2]; } }
        public Weapon ForkОfDOOM { get { return this.uniques[0]; } }
        public Weapon MagicSword { get { return this.uniques[1]; } }
    }
    #endregion
}