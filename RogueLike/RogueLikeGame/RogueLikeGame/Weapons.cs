using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public class Weapons
    {
        public string WeaponName { get; set; } //Weapon Name > check using .contains
        public int CriticalDamage { get; set; } //Crit CHANCE
        public double DamageBase { get; set; } //Base damage
        public int DropChance { get; set; }     //Chance to drop from a source

        public Weapons(string name, double damage, int critical, int dropChance)
        {
            this.WeaponName = name;
            this.DamageBase = damage;
            this.DropChance = dropChance;
            this.CriticalDamage = critical;
        }

        public double Damage() //Call this when attacking > adds a crit chance to the attack
        {
            return Randomizer.Damage(this.CriticalDamage, this.DamageBase);
        }
    }
}
