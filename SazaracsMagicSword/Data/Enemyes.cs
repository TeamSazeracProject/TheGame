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
                new Weapon("Claws", 5, null),
                img.Dog
                ),
            new Enemy(
                "Gnome",
                0.1,
                new Statistics(15, 15, 0),
                0.9,
                new Weapon("Gnome Sword", 7, null),
                img.Gnome
                ),
            new Enemy(
                "Bandit",
                0.1,
                new Statistics(10, 10, 10),
                0.9,
                wpns.WeakWeapons[1],
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
                wpns.AverageWeapons[1],
                img.HumanWithTwoSabers
                ),
            new Enemy(
                "Bear",
                0.1,
                new Statistics(20, 20, 0),
                0.7,
                new Weapon("Claws", 15, null),
                img.Bear
                ),
            new Enemy(
                "Huge Spider",
                0.1,
                new Statistics(15, 25, 0),
                0.7,
                new Weapon("Venom", 15, null),
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
                new Weapon("Hidden Dagers", 30, null),
                img.HumanWithTwoSabers
                ),
            new Enemy(
                "Magician",
                0.1,
                new Statistics(10, 10, 40),
                0.5,
                new Weapon("Chaotic Magic", 35, null),
                img.HumanWithStaff
                ),
            new Enemy(
                "Demon",
                0.1,
                new Statistics(25, 10, 25),
                0.5,
                new Weapon("Demonic Magic", 40, null),
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
                new Weapon("Fire Magic", 15, null),
                img.HumanInFlame
                ),
            new Enemy(
                "The WareWolf",
                0.1,
                new Statistics(40, 15, 10),
                0.5,
                new Weapon("Claws", 30, null),
                img.WareWolf
                ),
            new Enemy(
                "Sazarac",
                0.1,
                new Statistics(30, 30, 30),
                0.5,
                new Weapon("Sazarak's Sword", 70, null),
                img.HumanWithShieldAndBigSword
                )
        };
    }
}
