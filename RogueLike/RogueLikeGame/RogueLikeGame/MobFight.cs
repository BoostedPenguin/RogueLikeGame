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
            switch (mob.Type)
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
                case MobTypes.ELDERDRAGON:
                    i = Randomizer.RandomizeText(2);
                    switch(i)
                    {
                        case 1:
                            return $"{user.userName} {TextNarrative.ElderDragonEncounter1}";
                        case 2:
                            return $"{user.userName} {TextNarrative.ElderDragonEncounter2}";
                    }
                    return null;
                case MobTypes.FLESHBEHEMOTH:
                    return $"{user.userName} {TextNarrative.BehemothEncounter1}";
                case MobTypes.LIFEREAPER:
                    return $"{user.userName} {TextNarrative.LifeReaperEncounter1}";
                default:
                    return null;
            }
        }

        public static string OnEnemyHit(UserSettings user, Mobs mob, GlobalSettings allSettings) //When enemy hits you
        {
            string debuff = "";                             //Return string for information on current debuff

            if (!Randomizer.Evade(user.TotalEvadeChance())) //If the user DOESNT manage to evade (calculated on random factor)
            {
                double damage = mob.Attack(allSettings, user);               //Total damage

                if(user.currentRoundOfDebuff > 0)                //Checks if the mob did an active debuff on the player
                {
                    debuff = mob.Ability(mob, user);

                    if (debuff != null)                     //Will never be null
                    {
                        user.currentRoundOfDebuff--;             //1 less round for the remaining debuff
                    }
                    if(user.currentRoundOfDebuff <= 0)           //If debuffs gets to 0 - reset the debuff
                    {
                        mob.AbilityCounter = -1;
                        user.debuff = 1;
                    }
                }

                damage -= user.TotalArmor(allSettings);            //Total received damage - counting armor

                if (damage < 0)                         //Return string
                {
                    return $"{user.userName} got hit by {mob.Type.ToString()} for 0 damage. {debuff}";
                }

                user.currentHealth -= damage;           //Player hit

                string returnInfo = $"{user.userName} got hit by {mob.Type.ToString()} for {damage} damage. {debuff}";
                return returnInfo;
            }
            else
            {
                if(user.currentRoundOfDebuff > 0)
                {
                    debuff = mob.Ability(mob, user);
                    user.currentRoundOfDebuff--;
                    if(user.currentRoundOfDebuff <= 0)
                    {
                        mob.AbilityCounter = -1;
                        user.debuff = 1;
                    }
                    return debuff;
                }
                return $"{user.userName} managed to evade {mob.Type}'s attack!";
            }
        }

        public static string OnPlayerHit(UserSettings user, Mobs mob, bool ability, GlobalSettings allSettings)
        {
            user.currentAbilityCooldown++;          //1 round passed > closer to OFF cd

            if (user.currentRoundOfBuff > 0) //Execute buff on start of round
            {
                switch (user.CharacterName)
                {
                    case GameCharacters.GodKnight:
                        user.GodKnightAbility();
                        break;
                }
            }

            if (!Randomizer.Evade(mob.EvadeChance) || ability == true) //If the mob DOESNT evade
            {
                double damage = user.TotalDamage(allSettings);
                string returnInfo = $"{user.userName} dealt {damage} damage to {mob.Type.ToString()}";

                if (ability)                        //If the user uses an ability
                {
                    switch(user.CharacterName)
                    {
                        case GameCharacters.Berserker:
                            damage = user.BerserkerAbility(damage);
                            returnInfo = $"{user.userName} used his ability and did {damage} damage to {mob.Type.ToString()}";
                            break;

                        case GameCharacters.Ghost:
                            user.roundCounter = 0;
                            user.mobEncounter = false;
                            user.encounter = true;
                            user.currentAbilityCooldown = 0;
                            return $"{user.userName} used his ability and fled from {mob.Type.ToString()}";

                        case GameCharacters.GodKnight:
                            user.currentAbilityCooldown = 0;
                            user.currentRoundOfBuff = 5;
                            returnInfo = user.GodKnightAbility();
                            break;
                    }
                }

                mob.Health -= damage;               //Deduct the enemy health
                //If hit was critical
                if (damage / user.Damage / allSettings.characterDamageMultiplier > user.currentWeapon.DamageBase && !ability)
                {
                    returnInfo = $"{user.userName} dealt a critical hit for {damage} damage to {mob.Type.ToString()}";
                }
                if (mob.Health <= 0 && mob.Type == MobTypes.LIFEREAPER && mob.FirstEncounter)
                {
                    mob.AbilityCounter = 0;
                    returnInfo = mob.Ability(mob, user);
                }
                return returnInfo;
            }
            else
            {
                return $"{mob.Type.ToString()} managed to evade your attack!";
            }
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
                    mob.Health -= pot.Damage;
                    user.potions.Remove(pot);
                    return $"{user.userName} damaged {mob.Type} for {pot.Damage} using a potion";
                }
                return "";
            }
        }

        public static string DeathOfEnemy(UserSettings user, Mobs mob, GlobalSettings allSettings, Items allItems) //On enemy death
        {
            string onKill = $"You managed to defeat {mob.Type.ToString()}";
            switch (Randomizer.EnemyDeathLoot(false, allSettings, allItems))               //Gives me 1 item or null, everytime this is called
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

        public static string OnPlayerFlee(UserSettings user, Mobs mob)
        {
            int receivedDamage = Randomizer.OnPlayerFleeRandomizer(user);
            if (receivedDamage == -1) //Sucessfuly fled
            {
                return null;
            }
            else
            {
                return $"Unsucessfully fled {mob.Type}. You received {receivedDamage} damage";
            }
        }
    }
}
