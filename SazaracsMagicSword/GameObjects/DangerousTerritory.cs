using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.GameObjects
{
    public class DangerousTerritory
    {
        double Chance { get; set; }
        Enemy enemyToAppear { get; set; }

        public DangerousTerritory(double Chance, Enemy enemyToAppear)
        {
            this.Chance = Chance;
            this.enemyToAppear = enemyToAppear;
        }
    }
}
