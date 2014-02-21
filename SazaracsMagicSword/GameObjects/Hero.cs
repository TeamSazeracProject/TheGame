using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace SazaracsMagicSword.GameObjects
{
    class Hero : Human, IMove
    {
        public int level = 1;
        public Statistics statistics;
        public Statistics levelUpStats;
        public Weapon weapon;
        public Position position;

        public Hero(string Name, Statistics statistics, Weapon weapon, string[] image, Statistics levelUpStats)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name is empty.");
            }
            this.Name = Name;
            this.statistics = statistics;
            this.weapon = weapon;
            this.levelUpStats = levelUpStats;
            this.image = image;
        }
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.up:
<<<<<<< HEAD
                    this.position.row += -1;
=======
                        this.position.row += -1;
>>>>>>> 07fd6d369b660aad067c07c66f4146517ed20644
                    break;
                case Direction.down:
                    this.position.row += 1;
                    break;
                case Direction.left:
<<<<<<< HEAD
                    this.position.col += -1;
=======
                        this.position.col += -1;
>>>>>>> 07fd6d369b660aad067c07c66f4146517ed20644
                    break;
                case Direction.right:
                    this.position.col += 1;
                    break;
                default:
                    break;
            }
        }
    }
}
