using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.GameObjects;

namespace SazaracsMagicSword.Data
{
    class Dangers
    {
        static Enemyes enms = new Enemyes();

        public List<DangerousTerritory> Level1Dangers = new List<DangerousTerritory>()
        {
            new DangerousTerritory(0.1, enms.WeakEnemyes[0]),
            new DangerousTerritory(0.1, enms.WeakEnemyes[1]),
            new DangerousTerritory(0.1, enms.WeakEnemyes[2]),
            new DangerousTerritory(1, enms.Bosses[0]) /// Boss
        };
        public List<DangerousTerritory> Level2Dangers = new List<DangerousTerritory>()
        {
            new DangerousTerritory(0.2, enms.AverageEnemyes[0]),
            new DangerousTerritory(0.2, enms.AverageEnemyes[1]),
            new DangerousTerritory(0.2, enms.AverageEnemyes[2]),
            new DangerousTerritory(1, enms.Bosses[1]) /// Boss
        };
        public List<DangerousTerritory> Level3Dangers = new List<DangerousTerritory>()
        {
            new DangerousTerritory(0.3, enms.StrongEnemyes[0]),
            new DangerousTerritory(0.3, enms.StrongEnemyes[1]),
            new DangerousTerritory(0.3, enms.StrongEnemyes[2]),
            new DangerousTerritory(1, enms.Bosses[2]) /// Boss
        };
    }
}
