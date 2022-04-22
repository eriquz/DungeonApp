using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        private int _minDamage;
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value <= MaxDamage ? value : MaxDamage; }
        }//end MinDamage

        public Monster(string name, int life, int maxLife, int hitChance, int block, int speed, int minDamage, int maxDamage, string description) : base(name, life, maxLife, hitChance, block, speed)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }//end FQCTOR

        public override string ToString()
        {
            return string.Format($"{Name}\n{Description}\n" +
                $"{(Life == MaxLife ? "It is uninjured." : Life >= MaxLife / 2 ? "It is wounded, but angry." : "It is gravely wounded. Now is your time to strike.")}");
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
    }
}
