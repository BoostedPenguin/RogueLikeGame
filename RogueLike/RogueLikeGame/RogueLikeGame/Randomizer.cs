﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public static class Randomizer
    {
        static Random r = new Random();

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
        public static dynamic EnemyDeathLoot(Items items) //Dynamic - returns object depending on case
        {
            int wepArmPotNull = r.Next(0, 100); // 20% chance for each item // 40% chance for nothing
            if(wepArmPotNull < 20)
            {
                int totalProbability = items.allWeapons.Sum(t => t.DropChance); //LINQ Holds the total probability of the items
                int chance = r.Next(0, totalProbability);                       //Gets a number -> Higher = better loot
                foreach(Weapons weap in items.allWeapons)
                {
                    if(chance < weap.DropChance)                                //If the rng is lower than the dropchance u
                    {                                                           //get the item
                        return weap;
                    }
                    chance -= weap.DropChance;                                  // !Remove the last drop chance so it can find an item
                }
            }
            else if(20 < wepArmPotNull && wepArmPotNull < 40) //Armor
            {
                int totalProbability = items.allArmor.Sum(t => t.DropChance); //LINQ Holds the total probability of the items
                int chance = r.Next(0, totalProbability);
                foreach (Armor b in items.allArmor)
                {
                    if (chance < b.DropChance)
                    {
                        return b;
                    }
                    chance -= b.DropChance;
                }
            }
            else if(40 < wepArmPotNull && wepArmPotNull < 60) //Potion
            {
                int totalProbability = items.allPotions.Sum(t => t.DropChance);
                int chance = r.Next(0, totalProbability);

                foreach (Potions a in items.allPotions)
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
