using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Dragon : Monster
    {
        public bool IsFlying { get; set; }

        public Dragon(string name, int life, int maxLife, int hitChance, int block, int speed, int minDamage, int maxDamage, string description, bool isFlying) : base(name, life, maxLife, hitChance, block, speed, minDamage, maxDamage, description)
        {
            IsFlying = isFlying;
            if (IsFlying)
            {
                Block += Block / 2;
                HitChance -= 10;
                MaxDamage += 2;
                MinDamage += 1;
            }
        }//end FQCTOR

        public override string ToString()
        {
            return string.Format($"{ base.ToString()}{(IsFlying ? "\nIt flies through the air around you, making it a more difficult target. Your ablility to dodge is greater, though." : "")}");
        }
    }
}
