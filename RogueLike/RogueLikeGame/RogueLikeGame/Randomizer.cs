using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public static class Randomizer
    {
        static readonly Random r = new Random();
        public static int RandomEncounter()
        {
            return r.Next(0, 2); //0 - Mob, 1 - Treasure Chest
        }
        public static string OnChestOpen(UserSettings user)
        {
            string returnInformation = "";

            int result = r.Next(0, 3);
            switch(result)
            {
                case 0: //Return loot
                    switch (Randomizer.EnemyDeathLoot(true))
                    {
                        case Weapons weapons:
                            returnInformation = $"You found {weapons.WeaponName}. But you had it already.";
                            if(MobFight.DublicateItems(true, weapons.WeaponName, user))
                            {
                                returnInformation = $"You found {weapons.WeaponName}.";
                                user.weapons.Add(weapons);
                            }
                            return returnInformation;

                        case Armor armor:
                            returnInformation = $"You found {armor.ArmorName}. But you had it already.";
                            if (MobFight.DublicateItems(false, armor.ArmorName, user))
                            {
                                returnInformation = $"You found {armor.ArmorName}.";
                                user.armor.Add(armor);
                            }
                            return returnInformation;

                        case Potions potions:
                            returnInformation = $"You found {potions.PotionName}.";
                            user.potions.Add(potions);
                            return returnInformation;
                    }
                    break;
                case 1: //Return enemy encounter
                    GlobalSettings.roundCounter = 0; //Will create a new mob
                    return "You tried to open the chest, but a hostile mob was hiding inside!";
                case 2: //Inflict damage on player
                    user.CurrentHealth -= GlobalSettings.damageOnFailedOpen;
                    return $"The chest is filled with poison. You got damaged for a total of {GlobalSettings.damageOnFailedOpen} damage";
            }
            return null;
        }

        public static int OnPlayerFleeRandomizer(UserSettings user)
        {
            int escapeChance = r.Next(0, 100);
            if(escapeChance > 70) //30% chance to flee the attack
            {
                return -1;
            }
            else
            {
                //Deals damage on failed flee attemp - random between 0 and the player maxHealth
                int receiveDamage = r.Next(0, (int)user.MaxHealth);
                user.CurrentHealth -= receiveDamage;
                return receiveDamage;
            }
        }

        public static MobTypes EnemyRandomizer()
        {
            int totalProbability = Items.allMobs.Sum(t => t.SpawnChance);
            int mr = r.Next(0, totalProbability);

            foreach (Mobs a in Items.allMobs)
            {
                if(mr < a.SpawnChance)
                {
                    return a.Type;
                }
                mr -= a.SpawnChance;
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
        public static dynamic EnemyDeathLoot(bool onEncounter) //Dynamic - returns object depending on case
        {
            int wepArmPotNull = r.Next(0, 100); // 20% chance for each item // 40% chance for nothing
            if (onEncounter)
            {
                wepArmPotNull = r.Next(0, GlobalSettings.totalChance);
            }



            if (wepArmPotNull <= GlobalSettings.weaponDropChance)
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
            else if(GlobalSettings.weaponDropChance < wepArmPotNull && wepArmPotNull <= GlobalSettings.armorDropChance) //Armor
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
            else if(GlobalSettings.armorDropChance < wepArmPotNull && wepArmPotNull <= GlobalSettings.potionDropChance) //Potion
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
