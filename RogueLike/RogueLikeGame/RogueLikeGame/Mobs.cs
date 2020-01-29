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
        ZOMBIE,
        ELDERDRAGON
    }
    public class Mobs
    {
        public MobTypes Type { get; set; }          //Type of enemy
        public double Damage { get; set; }          //The BASE damage
        public double Health { get; set; }             //The CURRENT amount of health
        public double MaxHealth { get; set; }          //The MAX HEALTH
        public int EvadeChance { get; set; }        //The TOTAL evade chance
        public int AbilityChance { get; set; }      //Chance of an ability to happen
        public int SpawnChance { get; set; }
        public string DebuffString { get; set; }
        public int AbilityCounter { get; set; }

        public Mobs(MobTypes type, double damage, int evadeChance, int abilityChance, int health, int spawnChance)
        {
            this.Type = type;
            this.EvadeChance = evadeChance;
            this.Damage = damage;
            this.AbilityChance = abilityChance;
            this.Health = health;
            this.MaxHealth = health;
            this.SpawnChance = spawnChance;

            this.AbilityCounter = -1;
        }

        //Call this whenever you want a spider to attack instead of DAMAGE
        //5% chance to deal double damage
        public double Attack()
        {
            double multiplier = GlobalSettings.enemyDifficultyMultiplier;
            switch(Type)
            {
                case MobTypes.SPIDER:
                    return multiplier * Randomizer.Damage(AbilityChance, Damage);

                case MobTypes.RAT:
                    if(Randomizer.EnemyAbilityChance(AbilityChance))
                    {
                        MobFight.currentRoundOfDebuff = 3; //Rounds of debuff
                    }
                    return Damage * multiplier;

                case MobTypes.SHADOW:
                    if(Randomizer.EnemyAbilityChance(AbilityChance))
                    {
                        MobFight.currentRoundOfDebuff = 3;
                    }
                    return Damage * multiplier;

                case MobTypes.ZOMBIE:
                    if(Randomizer.EnemyAbilityChance(AbilityChance))
                    {
                        MobFight.currentRoundOfDebuff = 1;
                    }
                    return Damage * multiplier;

                case MobTypes.ELDERDRAGON:
                    if(Randomizer.EnemyAbilityChance(AbilityChance))
                    {
                        if (AbilityCounter == -1) //Doesnt overlap abilities
                        {
                            if (Randomizer.ElderDragonAbiliyRandomizer() == 0) //0, 1 randomize - 2 different abilities
                            {
                                MobFight.currentRoundOfDebuff = 3; //3 rounds of fire on player
                                this.AbilityCounter = 0;
                            }
                            else
                            {
                                MobFight.currentRoundOfDebuff = 1;
                                this.AbilityCounter = 1;
                            }
                        }
                    }
                    return Damage * multiplier;

                default:                    //Just return crit chance if mob doesnt have a timed round debuff ability
                    return multiplier* Randomizer.Damage(AbilityChance, Damage);
            }
        }

        public string Ability(Mobs mob, UserSettings user)
        {
            switch(mob.Type)
            {
                case MobTypes.SPIDER:   //Use some return that will never be used
                    return null;

                case MobTypes.RAT:  //Amount of damage per round
                    user.CurrentHealth -= 2;
                    this.DebuffString = $"Poisoned for {2} damage";
                    return DebuffString;

                case MobTypes.SHADOW:
                    user.debuff = 2;
                    this.DebuffString =  $"Player damage reduced by {2} times";
                    return DebuffString;

                case MobTypes.ZOMBIE: //Amount of heal
                    this.DebuffString = $"Self-Regenerated {8} health";
                    if (mob.Health + 8 > mob.MaxHealth)
                    {
                        mob.Health = mob.MaxHealth;
                    }
                    else
                    {
                        mob.Health += 8;
                    }
                    return DebuffString;

                case MobTypes.ELDERDRAGON:
                    if (AbilityCounter == 0)
                    {
                        this.DebuffString = "The dragon used his fire breath to inflict heavy damage on the player";
                        user.CurrentHealth -= 15;
                    }
                    else if(AbilityCounter == 1)
                    {
                        this.DebuffString = "The dragon used it's claws and wounded the player";
                        user.CurrentHealth -= 40;
                    }
                    return DebuffString;
                default:
                    return $"";
            }
        }
    }
}
