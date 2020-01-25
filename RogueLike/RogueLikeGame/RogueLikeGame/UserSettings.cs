using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public class UserSettings
    {
        public Chars CharacterName;
        public string userName;             //Changed by user input
        public Characters pickedCharacter;  //Changed by user input
        public double maxHealth;               //Changed by picked_character selection
        public double currentHealth;           //Changed by events
        public int characterArmor;          //Changed by pickup_character selection || (character_armor + current_armor(armor)) * multiplier
        public double characterDamage;         //Changed by pickup_character selection || (character_damage * current_weapon) * character_damage_multiplier
        public int characterEvadeChance;      //Changed by pickup_character selection || (character_evade_chance + current_armor(evade_chance)) * multiplier
        public List<Weapons> weapons;       //Stores all collected weapons
        public List<Armor> armor;           //Stores all collected armor
        public List<Potions> potions; 		//Stores all collected potions
        public Weapons currentWeapon;       //Stores the equipped weapon
        public Armor currentArmor;          //Stores the equipped armor
        public int abilityCooldown;     	//Changed by pickup_character selection
        public int currentAbilityCooldown; //Resets to 0 after pickup, +1 each turn; Available to use after it's same as character_ability_cooldown
        public double debuff;

        //Check for armor and weapon values != null
        //When actually trying to inflict or receive damage


        public UserSettings(string username, Characters character)
        {
            //Stores your inventory list
            this.weapons = new List<Weapons>();
            this.armor = new List<Armor>();
            this.potions = new List<Potions>();
            //Adds starting items to inventory list
            weapons.Add(character.StartWeapon);
            armor.Add(character.StartArmor);
            //Changes user data based on the selected character
            this.CharacterName = character.CharacterName;
            this.abilityCooldown = character.AbilityCooldown;
            this.currentAbilityCooldown = character.AbilityCooldown;
            this.currentArmor = character.StartArmor;
            this.currentWeapon = character.StartWeapon;
            this.userName = username;
            this.pickedCharacter = character;
            this.maxHealth = character.Health;
            this.characterArmor = character.Armor;
            this.characterDamage = character.Damage;
            this.characterEvadeChance = character.EvadeChance;
            this.currentHealth = this.maxHealth;
            this.debuff = 1;
        }

        public double CurrentHealth
        {
            get { return this.currentHealth; }
            set
            {
                if(value > this.maxHealth)
                {
                    this.currentHealth = maxHealth;
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
            return this.characterEvadeChance + this.currentArmor.EvadeChance;
        }

        public double TotalDamage() //Returns total damage 
        {
            return this.characterDamage * this.currentWeapon.Damage() * GlobalSettings.characterDamageMultiplier / debuff;
        }

        public double TotalDamageWithoutCrit()
        {
            return this.characterDamage * this.currentWeapon.DamageBase * GlobalSettings.characterDamageMultiplier / debuff;
        }

        public int TotalArmor() //Returns total armor
        {
            return (this.characterArmor + this.currentArmor.ItemArmor) * GlobalSettings.characterArmorMultiplier;
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
