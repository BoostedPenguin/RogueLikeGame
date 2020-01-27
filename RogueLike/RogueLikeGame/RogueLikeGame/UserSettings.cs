using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public class UserSettings : Characters
    {
        public string userName;                  //Changed by user input
        public double currentHealth;             //Changed by events
        public List<Weapons> weapons;            //Stores all collected weapons
        public List<Armor> armor;                //Stores all collected armor
        public List<Potions> potions; 	         //Stores all collected potions
        public Weapons currentWeapon;            //Stores the equipped weapon
        public Armor currentArmor;               //Stores the equipped armor
        public int currentAbilityCooldown;       //Resets to 0 after pickup, +1 each turn; Available to use after it's same as character_ability_cooldown
        public double debuff;                    //Mob debuff for damage: damage / debuff = currentDamage 

        public UserSettings(string username, GameCharacters character) : base(character)
        {
            //Stores your inventory list
            this.weapons = new List<Weapons>();
            this.armor = new List<Armor>();
            this.potions = new List<Potions>();
            //Adds starting items to inventory list
            weapons.Add(base.StartWeapon);
            armor.Add(base.StartArmor);
            //Changes user data based on the selected character
            this.currentAbilityCooldown = base.AbilityCooldown;
            this.currentArmor = base.StartArmor;
            this.currentWeapon = base.StartWeapon;
            this.userName = username;                               //Set the users input as username
            this.currentHealth = base.MaxHealth;                    //Set the currentHealth to character MaxHealth
            this.debuff = 1;                                        //Mob debuff for damage: damage / debuff = currentDamage 
        }

        public double CurrentHealth
        {
            get { return this.currentHealth; }
            set
            {
                if(value > base.MaxHealth)
                {
                    this.currentHealth = base.MaxHealth;
                }
                else if(value < 0)
                {
                    this.currentHealth = 0;
                }
                else
                {
                    this.currentHealth = value;
                }
            }
        }

        public int AmountPotions(bool isHealthPot) //Returns the amount of specific potions: false - poison, true - health
        {
            int count = 0;
            foreach(Potions a in potions)
            {
                if(a.IsHealthPotion == isHealthPot)
                {
                    count++;
                }
            }
            return count;
        }

        public int TotalEvadeChance() //Returns total evade chance
        {
            return base.EvadeChance + this.currentArmor.EvadeChance;
        }

        public double TotalDamage() //Returns total damage 
        {
            return base.Damage  * this.currentWeapon.Damage() * GlobalSettings.characterDamageMultiplier / debuff;
        }

        public double TotalDamageWithoutCrit()
        {
            return base.Damage * this.currentWeapon.DamageBase * GlobalSettings.characterDamageMultiplier / debuff;
        }

        public int TotalArmor() //Returns total armor
        {
            return (base.Armor + this.currentArmor.ItemArmor) * GlobalSettings.characterArmorMultiplier;
        }

        public string GodKnightAbility()
        {
            if(MobFight.currentRoundOfBuff > 0)
            {
                this.CurrentHealth += 8;
                MobFight.currentRoundOfBuff--;
            }
            return $"{this.userName} healed for {8} health";
        }

        public double BerserkerAbility(double damage)
        {
            damage *= 3; //Change this to determine the amount of damage you want it to do;
            currentAbilityCooldown = 0;
            return damage;
        }
    }
}
