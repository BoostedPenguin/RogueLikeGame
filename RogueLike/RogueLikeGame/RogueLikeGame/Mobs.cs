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
        public double health { get; set; }             //The CURRENT amount of health
        public double maxHealth { get; set; }          //The MAX HEALTH
        public int evadeChance { get; set; }        //The TOTAL evade chance
        public int abilityChance { get; set; }      //Chance of an ability to happen
        public int spawnChance { get; set; }
        public string debuffString { get; set; }

        public Mobs(MobTypes type, double damage, int evadeChance, int abilityChance, int health, int spawnChance)
        {
            this.type = type;
            this.evadeChance = evadeChance;
            this.damage = damage;
            this.abilityChance = abilityChance;
            this.health = health;
            this.maxHealth = health;
            this.spawnChance = spawnChance;
        }

        //Call this whenever you want a spider to attack instead of DAMAGE
        //5% chance to deal double damage
        public double Attack()
        {
            double multiplier = GlobalSettings.enemyDifficultyMultiplier;
            switch(type)
            {
                case MobTypes.SPIDER:
                    return multiplier * Randomizer.Damage(abilityChance, damage);

                case MobTypes.RAT:
                    if(Randomizer.EnemyAbilityChance(abilityChance))
                    {
                        MobFight.currentRoundOfDebuff = 3; //Rounds of debuff
                    }
                    return damage * multiplier;

                case MobTypes.SHADOW:
                    if(Randomizer.EnemyAbilityChance(abilityChance))
                    {
                        MobFight.currentRoundOfDebuff = 3;
                    }
                    return damage * multiplier;
                case MobTypes.ZOMBIE:
                    if(Randomizer.EnemyAbilityChance(abilityChance))
                    {
                        MobFight.currentRoundOfDebuff = 1;
                    }
                    return damage * multiplier;

                default:                    //Just return crit chance if mob doesnt have an ability
                    return multiplier* Randomizer.Damage(abilityChance, damage);
            }
        }

        public string Ability(Mobs mob, UserSettings user)
        {
            switch(mob.type)
            {
                case MobTypes.SPIDER:   //Use some return that will never be used
                    return null;

                case MobTypes.RAT:  //Amount of damage per round
                    user.currentHealth -= 2;
                    this.debuffString = $"Poisoned for {2} da   mage";
                    return debuffString;

                case MobTypes.SHADOW:
                    user.debuff = 2;
                    this.debuffString =  $"Player damage reduced by {2} times";
                    return debuffString;

                case MobTypes.ZOMBIE: //Amount of heal
                    this.debuffString = $"Self-Regenerated {8} health";
                    if (mob.health + 8 > mob.maxHealth)
                    {
                        mob.health = mob.maxHealth;
                    }
                    else
                    {
                        mob.health += 8;
                    }
                    return debuffString;

                default:
                    return $"";
            }
        }
    }
}
