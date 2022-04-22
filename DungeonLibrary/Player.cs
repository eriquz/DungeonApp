using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        public PlayerRace Race { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Player(string name, int life, int maxLife, int hitChance, int block, int speed, PlayerRace race, Weapon equippedWeapon) : base(name, life, maxLife, hitChance, block, speed)
        {
            Race = race;
            EquippedWeapon = equippedWeapon;

            switch (race)
            {
                case PlayerRace.Elf:
                    MaxLife += 5;
                    Life += 5;
                    break;
                case PlayerRace.Mage:
                    Speed -= 5;
                    Block += 5;
                    break;
                case PlayerRace.Ogre:
                    HitChance += 10;
                    Speed -= 10;
                    break;
            }

        }//end FQCTOR

        public override string ToString()
        {
            return string.Format($"{Name}\nRace: {Race}\nLife {Life} of {MaxLife}\nHitChance: {(CalcHitChance())}%\n" +
                $"Block Chance: {Block}%\n" +
                $"Equipped Weapon: {EquippedWeapon}");
        }

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }
    }
}
