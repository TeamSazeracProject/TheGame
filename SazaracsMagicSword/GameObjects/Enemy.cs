using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace SazaracsMagicSword.GameObjects
{
    public class Enemy : Human
    {
        public double chanceToAppear;
        public Statistics statistics;
        public double chanceToEscape;
        public Weapon weapon;

        public Enemy(string Name, double chanceToAppear, Statistics statistics, double chanceToEscape, Weapon weapon, string[] image)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name is empty.");
            }
            if (chanceToAppear <= 0 || chanceToAppear > 1)
            {
                throw new ArgumentException("chanceToAppear must be in the diapason of (0, 1].");
            }
            if (chanceToEscape < 0 || chanceToEscape > 1)
            {
                throw new ArgumentException("chanceToEscape must be in the diapason of [0, 1].");
            }
            this.Name = Name;
            this.chanceToAppear = chanceToAppear;
            this.statistics = statistics;
            this.chanceToEscape = chanceToEscape;
            this.weapon = weapon;
            this.image = image;
        }
    }
}
