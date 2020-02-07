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
        ELDERDRAGON,
        FLESHBEHEMOTH,
        LIFEREAPER
    }
    public class Mobs
    {
        public MobTypes Type { get; set; }          //Type of enemy
        public double Damage { get; set; }          //The BASE damage
        public double Health                        //Current health.. cant use full property cuz xml sucks
        {
            get;
            set;
        }
        public double MaxHealth { get; set; }       //The MAX HEALTH
        public int EvadeChance { get; set; }        //The TOTAL evade chance
        public int AbilityChance { get; set; }      //Chance of an ability to happen
        public int SpawnChance { get; set; }        //Chance of the enemy to spawn
        public string DebuffString { get; set; }    //Debuff string 
        public int AbilityCounter { get; set; }     //Switcher for multiple-abilities mobs
        public bool Boss { get; set; }              //If it's a boss enemy

        public Mobs(MobTypes type, double damage, int evadeChance, int abilityChance, int health, int spawnChance, bool boss)
        {
            this.Type = type;
            this.EvadeChance = evadeChance;
            this.Damage = damage;
            this.AbilityChance = abilityChance;
            this.MaxHealth = health;
            this.Health = health;
            this.SpawnChance = spawnChance;
            this.Boss = boss;
            this.AbilityCounter = -1;
        }

        public Mobs()
        {

        }

        //Call this whenever you want a spider to attack instead of DAMAGE
        //5% chance to deal double damage
        public double Attack(GlobalSettings allSettings, UserSettings user)
        {
            double multiplier = allSettings.enemyDifficultyMultiplier;
            switch(Type)
            {
                case MobTypes.SPIDER:
                    return multiplier * Randomizer.Damage(AbilityChance, Damage);

                case MobTypes.RAT:
                    if(Randomizer.EnemyAbilityChance(AbilityChance))
                    {
                        user.currentRoundOfDebuff = 3; //Rounds of debuff
                    }
                    return Damage * multiplier;

                case MobTypes.SHADOW:
                    if(Randomizer.EnemyAbilityChance(AbilityChance))
                    {
                        user.currentRoundOfDebuff = 7;
                    }
                    return Damage * multiplier;

                case MobTypes.ZOMBIE:
                    if(Randomizer.EnemyAbilityChance(AbilityChance))
                    {
                        user.currentRoundOfDebuff = 1;
                    }
                    return Damage * multiplier;

                case MobTypes.ELDERDRAGON:
                    if(Randomizer.EnemyAbilityChance(AbilityChance))
                    {
                        if (AbilityCounter == -1) //Doesnt overlap abilities
                        {
                            if (Randomizer.BossAbilityRandomizer() == 0) //0, 1 randomize - 2 different abilities
                            {
                                user.currentRoundOfDebuff = 3; //3 rounds of fire on player
                                this.AbilityCounter = 0;
                            }
                            else
                            {
                                user.currentRoundOfDebuff = 1;
                                this.AbilityCounter = 1;
                            }
                        }
                    }
                    return Damage * multiplier;

                case MobTypes.FLESHBEHEMOTH:
                    if(Randomizer.EnemyAbilityChance(AbilityChance))
                    {
                        if(AbilityCounter == -1)
                        {
                            user.currentRoundOfDebuff = 10;
                        }
                    }
                    return Damage * multiplier;

                case MobTypes.LIFEREAPER:
                    if(Randomizer.EnemyAbilityChance(AbilityChance))
                    {
                        user.currentRoundOfDebuff = 1;
                        this.AbilityCounter = 1;
                    }
                    return Damage * multiplier;

                default:                    //Just return crit chance if mob doesnt have a timed round debuff ability
                    return multiplier* Randomizer.Damage(AbilityChance, Damage);
            }
        }

        public bool FirstEncounter = true;
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
                    if(this.Health + 8 > MaxHealth)
                    {
                        this.Health = this.MaxHealth;
                    }
                    else
                    {
                        this.Health += 8;
                    }
                    return DebuffString;

                case MobTypes.ELDERDRAGON:
                    if (AbilityCounter == 0)
                    {
                        this.DebuffString = "The dragon used his fire breath to inflict heavy damage on the player";
                        user.CurrentHealth -= 5;
                    }
                    else if(AbilityCounter == 1)
                    {
                        this.DebuffString = "The dragon used it's claws and wounded the player";
                        user.CurrentHealth -= 5;
                    }
                    return DebuffString;

                case MobTypes.FLESHBEHEMOTH:
                    this.AbilityCounter = 0;  //Prevents doing an ability once an ability is already in place
                    this.DebuffString = $"Death incoming in {user.currentRoundOfDebuff}";
                    if(user.currentRoundOfDebuff == 1)
                    {
                        user.CurrentHealth = 0; //kills the player
                    }
                    return DebuffString;

                case MobTypes.LIFEREAPER:
                    if(AbilityCounter == 0 && FirstEncounter)
                    {
                        FirstEncounter = false;
                        DebuffString = "The life reaper respawns";
                        this.Health = MaxHealth / 2;
                    }
                    else if(AbilityCounter == 1)
                    {
                        DebuffString = $"{mob.Type} sucks the life on {user.userName}";
                        if(mob.Health + 10 > mob.MaxHealth)
                        {
                            mob.Health = mob.MaxHealth;
                        }
                        else
                        {
                            mob.Health += 10;
                        }
                        user.CurrentHealth -= 10;
                    }
                    return DebuffString;

                default:
                    return $"";
            }
        }
        public string AbilityString()
        {
            switch(this.Type)
            {
                case MobTypes.SPIDER:
                    return "Crit for double damage";
                case MobTypes.RAT:
                    return "Poison the player";
                case MobTypes.SHADOW:
                    return "Reduce the damage the player inflicts";
                case MobTypes.ZOMBIE:
                    return "Regenerate health";
                case MobTypes.ELDERDRAGON:
                    return "Inflict damage on player with claws or fire breath";
                case MobTypes.FLESHBEHEMOTH:
                    return "Insta-Kill the player after a couple of rounds";
                case MobTypes.LIFEREAPER:
                    return "Vampirize health from the player";
                default:
                    return null;
            }
        }
    }
}
