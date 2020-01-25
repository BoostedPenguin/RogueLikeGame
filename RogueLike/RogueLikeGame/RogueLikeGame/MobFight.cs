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
                            return $"{user.userName} {TextNarrative.SpiderEncounter1}";
                        case 2:
                            return $"{user.userName} {TextNarrative.SpiderEncounter2}";
                        case 3:
                            return $"{TextNarrative.SpiderEncounter3} {user.userName}";
                    }
                    return null;

                case MobTypes.RAT: //If the enemy is a rat
                    i = Randomizer.RandomizeText(3);
                    switch(i)
                    {
                        case 1:
                            return $"{user.userName} {TextNarrative.RatEncounter1}";
                        case 2:
                            return $"{user.userName} {TextNarrative.RatEncounter2}";
                        case 3:
                            return $"{user.userName} {TextNarrative.RatEncounter3}";
                    }
                    return null;
                case MobTypes.SHADOW:
                    i = Randomizer.RandomizeText(3);
                    switch (i)
                    {
                        case 1:
                            return $"{user.userName} {TextNarrative.ShadowEncounter1}";
                        case 2:
                            return $"{user.userName} {TextNarrative.ShadowEncounter2}";
                        case 3:
                            return $"{TextNarrative.ShadowEncounter3} {user.userName}";
                    }
                    return null;
                case MobTypes.ZOMBIE:
                    i = Randomizer.RandomizeText(3);
                    switch (i)
                    {
                        case 1:
                            return $"{user.userName} {TextNarrative.ZombieEncounter1}";
                        case 2:
                            return $"{user.userName} {TextNarrative.ZombieEncounter2}";
                        case 3:
                            return $"{user.userName} {TextNarrative.ZombieEncounter3}";
                    }
                    return null;
                default:
                    return null;
            }
        }

        public static int currentRoundOfDebuff = 0;
        public static int currentRoundOfBuff = 0;

        public static string OnEnemyHit(UserSettings user, Mobs mob) //When enemy hits you
        {
            string debuff = "";

            if (!Randomizer.Evade(user.TotalEvadeChance())) //If the user DOESNT manage to evade (calculated on random factor)
            {
                //Universal fight for every mob
                double damage = mob.Attack();   //Total damage

                if(currentRoundOfDebuff > 0) //Checks if the mob did an ability
                {
                    debuff = mob.Ability(mob, user);
                    if (debuff != null)
                    {
                        currentRoundOfDebuff--;
                    }
                    if(currentRoundOfDebuff <= 0)
                    {
                        user.debuff = 1;
                    }
                }

                damage -= user.TotalArmor();            //Total received damage - counting armor

                if (damage < 0)
                {
                    return $"{user.userName} got hit by {mob.type.ToString()} for 0 damage. {debuff}";
                }

                user.currentHealth -= damage;           //Player hit
                string returnInfo = $"{user.userName} got hit by {mob.type.ToString()} for {damage} damage. {debuff}";
                //if (damage > mob.damage)                //On enemy crit hit
                //{
                //    returnInfo = $"{user.userName} received a critical hit by {mob.type.ToString()} for {damage} damage. {debuff} {user.currentHealth}";
                //}
                return returnInfo;
            }
            else
            {
                if(currentRoundOfDebuff > 0)
                {
                    return mob.Ability(mob, user) + user.currentHealth;
                }
                return $"{user.userName} managed to evade {mob.type}'s attack!";
            }
        }

        public static string OnPlayerHit(int roundNr, UserSettings user, Mobs mob, bool ability)
        {
            user.currentAbilityCooldown++;          //1 round passed > closer to OFF cd

            if (currentRoundOfBuff > 0) //Execute buff on start of round
            {
                switch (user.CharacterName)
                {
                    case Chars.Ghost:
                        break;
                    case Chars.GodKnight:
                        user.GodKnightAbility();
                        break;
                }
            }

            if (!Randomizer.Evade(mob.evadeChance) || ability == true) //If the mob DOESNT evade
            {
                double damage = user.TotalDamage();
                string returnInfo = $"{user.userName} dealt {damage} damage to {mob.type.ToString()}";

                if (ability)                        //If the user uses an ability
                {
                    switch(user.CharacterName)
                    {
                        case Chars.Berserker:
                            damage = user.BerserkerAbility(damage);
                            returnInfo = $"{user.userName} used his ability and did {damage} damage to {mob.type.ToString()}";
                            break;

                        case Chars.Ghost:
                            break;

                        case Chars.GodKnight:
                            user.currentAbilityCooldown = 0;
                            currentRoundOfBuff = 5;
                            returnInfo = user.GodKnightAbility();
                            break;
                    }
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

        private static double BererkerAbility(UserSettings user, double damage)
        {
            damage *= user.Ability();
            user.currentAbilityCooldown = 0;
            return damage;
        }
        private static string GodKnightAbility(UserSettings user)
        {

            if(currentRoundOfBuff > 0)
            {
                user.CurrentHealth += 8; //amount of health that should be added
                currentRoundOfBuff--;
            }
            return $"{user.userName} healed for 8 health";
        }

        public static string PotionUse(Potions pot, UserSettings user, Mobs mob)
        {
            if(pot.IsHealthPotion)
            {
                user.CurrentHealth += pot.Damage;
                user.potions.Remove(pot);
                return $"{user.userName} healed for {pot.Damage} health";
            }
            else
            {
                if(mob != null)
                {
                    mob.health -= pot.Damage;
                    user.potions.Remove(pot);
                    return $"{user.userName} damaged {mob.type} for {pot.Damage} using a potion";
                }
                return "";
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

        public static bool DublicateItems(bool type,string item, UserSettings user) //Prevent dub item: Type true - weapon, false - armor
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
