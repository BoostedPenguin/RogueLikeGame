using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public static class MobFight
    {
        public static string TBStartFight(Mobs mob, UserSettings user) //On start of fight (First round)
        {
            int i;
            switch (mob.type)
            {
                case MobTypes.SPIDER: //If the enemy is a SPIDER
                    i = Randomizer.RandomizeText(3); //3 - amount of items to randomize
                    switch (i)
                    {
                        case 1:
                            return $"{user.userName} stumbled on a gigantic spider";
                        case 2:
                            return $"{user.userName} stuck upon a spider nest, with the queen getting ready to attack";
                        case 3:
                            return $"An ugly gigantic spider sits on the way of {user.userName}";
                    }
                    return null;

                case MobTypes.RAT: //If the enemy is a rat
                    i = Randomizer.RandomizeText(3);
                    switch(i)
                    {
                        case 1:
                            return "";
                        case 2:
                            return "";
                        case 3:
                            return "";
                    }
                    return null;
                default:
                    return null;
            }
        }

        public static int currentRoundOfDebuff = 0;

        public static string OnEnemyHit(UserSettings user, Mobs mob) //When enemy hits you
        {
            string debuff = "";

            if (!Randomizer.Evade(user.TotalEvadeChance())) //If the user DOESNT manage to evade (calculated on random factor)
            {
                //Universal fight for every mob >>->> Change mob.attack for specific abilities
                int damage = (int)mob.Attack();   //Total damage

                if(currentRoundOfDebuff > 0 && mob.Ability(mob.type) != -1) //Checks if the mob did an ability
                {
                    user.currentHealth -= (int)mob.Ability(mob.type);
                    currentRoundOfDebuff--;
                    debuff = $"Poisoned for {mob.Ability(mob.type)} damage";
                }

                damage -= user.TotalArmor();            //Total received damage - counting armor

                if (damage < 0)
                {
                    return $"{user.userName} got hit by {mob.type.ToString()} for 0 damage. {debuff}";
                }

                user.currentHealth -= damage;           //Player hit
                string returnInfo = $"{user.userName} got hit by {mob.type.ToString()} for {damage} damage. {debuff}";
                if (damage > mob.damage)                //On enemy crit hit
                {
                    returnInfo = $"{user.userName} received a critical hit by {mob.type.ToString()} for {damage} damage. {debuff}";
                }
                return returnInfo;
            }
            else
            {
                if(currentRoundOfDebuff > 0)
                {
                    user.currentHealth -= (int)mob.Ability(mob.type);
                    return $"Poisoned for {mob.Ability(mob.type)} damage";
                }
                return $"{user.userName} managed to evade {mob.type}'s attack!";
            }
        }

        public static string OnPlayerHit(int roundNr, UserSettings user, Mobs mob, bool ability)
        {
            user.currentAbilityCooldown++;          //1 round passed > closer to OFF cd
            if (!Randomizer.Evade(mob.evadeChance)) //If the mob DOESNT evade
            {
                int damage = (int)user.TotalDamage();
                string returnInfo = $"{user.userName} dealt {damage} damage to {mob.type.ToString()}";
                if (ability)                        //If the user uses an ability (WORKS ONLY FOR BERSERKER)
                {
                    damage = (int)CharacterAbility(user, damage);
                    returnInfo = $"{user.userName} used his ability and did {damage} damage to {mob.type.ToString()}";
                }
                mob.health -= damage;               //Deduct the enemy health

                //If hit was critical
                if (damage / user.characterDamage / GlobalSettings.characterDamageMultiplier > user.currentWeapon.DamageBase && !ability)
                {
                    returnInfo = $"{user.userName} dealt a critical hit for {damage} damage to {mob.type.ToString()}";
                }
                return returnInfo;
            }
            else
            {
                return $"{mob.type.ToString()} managed to evade your attack!";
            }
        }


        public static double CharacterAbility(UserSettings user, int damage) //on use of ability
        {
            if(user.CharacterName == Chars.Berserker) //If it was the berserker
            {
                if (user.currentAbilityCooldown >= user.abilityCooldown)
                {
                    damage *= (int)user.Ability();
                    user.currentAbilityCooldown = 0;
                }
                return damage;
            }
            else
            {
                return 1;
            }
        }

        public static string DeathOfEnemy(int roundNr, UserSettings user, Mobs mob) //On enemy death
        {
            string onKill = $"You managed to defeat {mob.type.ToString()}";
            switch (Randomizer.EnemyDeathLoot()) //Gives me 1 item or null, everytime this is called
            {
                case Weapons Weapon:
                    if(DublicateItems(true, Weapon.WeaponName, user))
                    {
                        user.weapons.Add(Weapon); //Adds it to the user 
                    }
                    return onKill += $", and you discovered {Weapon.WeaponName}";
                case Potions Potion:
                    user.potions.Add(Potion);
                    return onKill += $", and you discovered {Potion.PotionName}";
                case Armor Armor:
                    if(DublicateItems(false, Armor.ArmorName, user))
                    {
                        user.armor.Add(Armor);
                    }
                    return onKill += $", and you discovered {Armor.ArmorName}";
                default:
                    return onKill += $", but you didn't find any loot";
            }
        }

        public static bool DublicateItems(bool type,string item, UserSettings user) //Type true - weapon, false - armor
        {
            if (type)
            {
                if (user.weapons.Find(x => x.WeaponName == item) == null)
                {
                    return true;
                }
            }
            else 
            {
                if (user.armor.Find(y => y.ArmorName == item) == null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
