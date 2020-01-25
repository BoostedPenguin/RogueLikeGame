using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public static class Randomizer
    {
        static Random r = new Random();


        public static int OnPlayerFleeRandomizer(UserSettings user, Mobs mob)
        {
            int escapeChance = r.Next(0, 100);
            if(escapeChance > 70) //30% chance to flee the attack
            {
                return -1;
            }
            else
            {
                //Deals damage on failed flee attemp - random between 0 and the player maxHealth
                int receiveDamage = r.Next(0, (int)user.maxHealth);
                user.CurrentHealth -= receiveDamage;
                return receiveDamage;
            }
        }

        public static MobTypes EnemyRandomizer()
        {
            int totalProbability = Items.allMobs.Sum(t => t.spawnChance);
            int mr = r.Next(0, totalProbability);

            foreach (Mobs a in Items.allMobs)
            {
                if(mr < a.spawnChance)
                {
                    return a.type;
                }
                mr -= a.spawnChance;
            }
            return MobTypes.RAT;
        }

        //If the OBJECT manages to evade an attack
        public static bool Evade(int evadeChance)
        {
            int ec = r.Next(0, 100);
            if(evadeChance >= ec)
            {
                return true;
            }
            return false;
        }

        //If the enemy manages to use his ABILITY   
        public static bool EnemyAbilityChance(int enemyAbChance)
        {
            int ac = r.Next(0, 100);
            if(enemyAbChance >= ac)
            {
                return true;
            }
            return false;
        }

        //Randomize the given text options
        public static int RandomizeText(int amount)
        {
            int rm = r.Next(1, amount + 1);
            return rm;
        }

        //Calculates damage with critical chance
        public static double Damage(int critchance, double damage)
        {
            int ra = r.Next(0, 100);
            if(critchance >= ra) //If crit chance is 30 >= random chance to 100;
            {
                damage *= 2; //Double damage on critical strike
                return damage;
            }
            return damage;
        }

        //On Enemy death loot items
        public static dynamic EnemyDeathLoot() //Dynamic - returns object depending on case
        {
            int wepArmPotNull = r.Next(0, 100); // 20% chance for each item // 40% chance for nothing
            if(wepArmPotNull < GlobalSettings.weaponDropChance)
            {
                int totalProbability = Items.allWeapons.Sum(t => t.DropChance); //LINQ Holds the total probability of the items
                int chance = r.Next(0, totalProbability);                       //Gets a number -> Higher = better loot
                foreach(Weapons weap in Items.allWeapons)
                {
                    if(chance < weap.DropChance)                                //If the rng is lower than the dropchance u
                    {                                                           //get the item
                        return weap;
                    }
                    chance -= weap.DropChance;                                  // !Remove the last drop chance so it can find an item
                }
            }
            else if(GlobalSettings.weaponDropChance < wepArmPotNull && wepArmPotNull < GlobalSettings.armorDropChance) //Armor
            {
                int totalProbability = Items.allArmor.Sum(t => t.DropChance); //LINQ Holds the total probability of the items
                int chance = r.Next(0, totalProbability);
                foreach (Armor b in Items.allArmor)
                {
                    if (chance < b.DropChance)
                    {
                        return b;
                    }
                    chance -= b.DropChance;
                }
            }
            else if(GlobalSettings.armorDropChance < wepArmPotNull && wepArmPotNull < GlobalSettings.potionDropChance) //Potion
            {
                int totalProbability = Items.allPotions.Sum(t => t.DropChance);
                int chance = r.Next(0, totalProbability);

                foreach (Potions a in Items.allPotions)
                {
                    if(chance < a.DropChance)
                    {
                        return a;
                    }
                    chance -= a.DropChance;
                }
            }
            return null;
        }
    }
}
