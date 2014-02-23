using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace SazaracsMagicSword.GameObjects
{
    public class Hero : Human, IMove
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
        public Hero()
        {

        }
        public void LevelUp()
        {
            this.level++;
            this.statistics.strength += this.levelUpStats.strength;
            this.statistics.dexterity += this.levelUpStats.dexterity;
            this.statistics.willpower += this.levelUpStats.willpower;
            this.statistics.RefreshHP();
        }
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.up:
                    this.position.row += -1;
                    break;
                case Direction.down:
                    this.position.row += 1;
                    break;
                case Direction.left:
                    this.position.col += -1;
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
