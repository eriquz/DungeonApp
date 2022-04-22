using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        private int _minDamage;
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int BonusHitChance { get; set; }
        public bool IsTwoHanded { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value <= MaxDamage ? value : MaxDamage; }
        }//end MinDamage

        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwoHanded)
        {
            MaxDamage = maxDamage;
            Name = name;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }//end FQCTOR

        public override string ToString()
        {
            return string.Format($"{Name}\nGrip Type: {(!IsTwoHanded ? "Single-Handed" : "Two-Handed")}\nDamage Range: {MinDamage} - {MaxDamage}\nBonus Hit Chance: {BonusHitChance}");
        }//end ToString()

    }
}
