using System;
using System.Collections.Generic;
using SazaracsMagicSword.GameObjects;

namespace SazaracsMagicSword.Data
{
    class Enemyes
    {
        static Images img = new Images();
        static Weapons wpns = new Weapons();

        public List<Enemy> WeakEnemyes = new List<Enemy>()
        {
            new Enemy(
                "Wolf",
                0.1,
                new Statistics(15, 15, 0),
                0.9,
                wpns.WeakClaws,
                img.Dog
                ),
            new Enemy(
                "Gnome",
                0.1,
                new Statistics(15, 15, 0),
                0.9,
                wpns.GnomeSword,
                img.Gnome
                ),
            new Enemy(
                "Bandit",
                0.1,
                new Statistics(10, 10, 10),
                0.9,
                wpns.ShortSword,
                img.HumanWithSword
                )
        };

        public List<Enemy> AverageEnemyes = new List<Enemy>()
        {
            new Enemy(
                "Strong Bandit",
                0.1,
                new Statistics(15, 15, 10),
                0.7,
                wpns.Sword,
                img.HumanWithTwoSabers
                ),
            new Enemy(
                "Bear",
                0.1,
                new Statistics(20, 20, 0),
                0.7,
                wpns.AverageClaw,
                img.Bear
                ),
            new Enemy(
                "Huge Spider",
                0.1,
                new Statistics(15, 25, 0),
                0.7,
                wpns.Venom,
                img.Spider
                )
        };
        public List<Enemy> StrongEnemyes = new List<Enemy>()
        {
            new Enemy(
                "Assassin",
                0.1,
                new Statistics(20, 20, 20),
                0.5,
                wpns.HiddenDagers,
                img.HumanWithTwoSabers
                ),
            new Enemy(
                "Magician",
                0.1,
                new Statistics(10, 10, 40),
                0.5,
                wpns.ChaoticMagic,
                img.HumanWithStaff
                ),
            new Enemy(
                "Demon",
                0.1,
                new Statistics(25, 10, 25),
                0.5,
                wpns.DemonicMagic,
                img.Demon
                )
        };

        public List<Enemy> Bosses = new List<Enemy>()
        {
            new Enemy(
                "The Lord Of Fire",
                0.1,
                new Statistics(10, 15, 20),
                0.5,
                wpns.FireMagic,
                img.HumanInFlame
                ),
            new Enemy(
                "The WareWolf",
                0.1,
                new Statistics(40, 15, 10),
                0.5,
                wpns.StrongClaws,
                img.WareWolf
                ),
            new Enemy(
                "Sazarac",
                0.1,
                new Statistics(30, 30, 30),
                0.5,
                wpns.SazaracMagicSword,
                img.HumanWithShieldAndBigSword
                )
        };
    }
}