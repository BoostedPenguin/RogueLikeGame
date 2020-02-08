using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Mobs currentMob;
        public int roundCounter = 0; 

        #region PlayerDecisions
        public int actionCounter = 0;      //Keeps track of all encounters that have passed since the start        //save in user

        public int choice = 0;
        public bool ability = false; //False = ability on cd, True = ability available     //save in user
        public bool userAttack = false; //If it's the users turn to attack                 //save in user

        public bool firstSequence = true;          //save in user
        public bool secondSequence = false;        //save in user

        public bool firstButtonPressed = false;    //save in user
        public bool secondButtonPressed = false;   //save in user
        public bool thirdButtonPressed = false;    //save in user

        public bool encounter = false;             //save in user

        public bool riddleSetup = false;           //save in user
        public bool treasureEncounter = false;     //save in user
        public bool mobEncounter = false;          //save in user
        public bool riddleEncounter = false;       //save in user

        public bool elderDragonSetup = false;      //save in user
        public bool behemothSetup = false;
        public bool reaperSetup = false;

        public int currentRoundOfDebuff = 0;     //Debuff from enemy to player
        public int currentRoundOfBuff = 0;       //Debuff from player to player

        public MobTypes type;

        public bool bossEncounter = false;  //save in user
        #endregion

        #region LastRecordedOptions

        public List<string> textsLbl = new List<string>();
        public List<string> textsBtn = new List<string>();
        public List<bool> isEnabled = new List<bool>();
        public List<bool> isGpxEnabled = new List<bool>();
        public List<string> lbxCombatText = new List<string>();
        public string lastNarrative;

        public void PoppulateOnClose(List<string> buttonstxt, List<bool> buttonsEnb, List<string> labelstxt, List<string> combatLbx, string narrative, List<bool> gpxEnabled)
        {
            textsLbl = labelstxt;
            textsBtn = buttonstxt;
            isEnabled = buttonsEnb;
            lbxCombatText = combatLbx;
            lastNarrative = narrative;
            isGpxEnabled = gpxEnabled;
        }

        #endregion
        public UserSettings(string username, GameCharacters character, Items allItems) : base(allItems, character)
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
        public UserSettings() : base()
        {

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

        public double TotalDamage(GlobalSettings allSettings) //Returns total damage 
        {
            return base.Damage  * this.currentWeapon.Damage() * allSettings.characterDamageMultiplier / debuff;
        }

        public double TotalDamageWithoutCrit(GlobalSettings allSettings)
        {
            return base.Damage * this.currentWeapon.DamageBase * allSettings.characterDamageMultiplier / debuff;
        }

        public int TotalArmor(GlobalSettings allSettings) //Returns total armor
        {
            return (base.Armor + this.currentArmor.ItemArmor) * allSettings.characterArmorMultiplier;
        }

        public string GodKnightAbility()
        {
            if(this.currentRoundOfBuff > 0)
            {
                this.CurrentHealth += 8;
                this.currentRoundOfBuff--;
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
