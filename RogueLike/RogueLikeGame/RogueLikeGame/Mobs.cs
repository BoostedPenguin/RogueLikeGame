using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public enum MobTypes
    {
        SPIDER,
        RAT,
        SHADOW,
        ZOMBIE
    }
    public class Mobs
    {
        public MobTypes type { get; set; }          //Type of enemy
        public double damage { get; set; }          //The BASE damage
        public int health { get; set; }             //The CURRENT amount of health
        public int maxHealth { get; set; }          //The MAX HEALTH
        public int evadeChance { get; set; }        //The TOTAL evade chance
        public int abilityChance { get; set; }      //Chance of an ability to happen

        public Mobs(MobTypes type, double damage, int evadeChance, int abilityChance, int health)
        {
            this.type = type;
            this.evadeChance = evadeChance;
            this.damage = damage;
            this.abilityChance = abilityChance;
            this.health = health;
            this.maxHealth = health;
        }

        //Call this whenever you want a spider to attack instead of DAMAGE
        //5% chance to deal double damage
        public double SpiderAttack()
        {
            return Randomizer.Damage(abilityChance, damage);
        }

        //Still in concept
        public double RatAttack()
        {
            if(Randomizer.EnemyAbilityChance(abilityChance))
            {
                //at the end of the round deduct -4 health from the user
                return this.damage + 4;
            }
            else
            {
                return this.damage;
            }
        }
    }
}
