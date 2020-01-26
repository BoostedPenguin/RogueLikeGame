using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public enum Chars //All available characters
    {
        Berserker,
        Ghost,
        GodKnight
    }

    public class Characters
    {
        public Chars CharacterName { get; set; } //The name > use to check & display
        public int Health { get; set; }          //Max Health of the character
        public double Damage { get; set; }       //Base damage MULTIPLIER based on character ex: 1.5 x damage
        public int Armor { get; set; }           //Base armor ADDITIVE not MULTIPLICATIVE
        public int EvadeChance { get; set; }     //Chance to evade an attack
        public int AbilityCooldown { get; set; } //The ability cooldown in TURNS
        public Weapons StartWeapon { get; set; } //The starting weapon given on start of game
        public Armor StartArmor { get; set; }    //The starting armor given on start of game
        public int secondChance { get; set; }

        public Characters(Chars characterName)   //If you want to change a character stats use this!
        {
            if(Chars.Berserker == characterName)
            {
                this.CharacterName = Chars.Berserker;
                UpdateArmor("Basic Armor"); //Give him this on game start
                UpdateWeapon("Blunt Sword"); // ^
                this.Health = 150;
                this.Damage = 1.5;
                this.Armor = 5;
                this.EvadeChance = 10;
                this.AbilityCooldown = 5; //How many PLAYER ROUNDS it takes for it to refresh
                this.secondChance = 0;
            }
            else if(Chars.Ghost == characterName)
            {
                this.CharacterName = Chars.Ghost;
                UpdateArmor("Basic Armor");
                UpdateWeapon("Blunt Sword");
                this.Health = 100;
                this.Damage = 2;
                this.Armor = 2;
                this.EvadeChance = 20;
                this.AbilityCooldown = 15;
                this.secondChance = 1;
            }
            else if(Chars.GodKnight == characterName)
            {
                this.CharacterName = Chars.GodKnight;
                UpdateArmor("Basic Armor");
                UpdateWeapon("Blunt Sword");
                this.Health = 200;
                this.Damage = 1;
                this.Armor = 8;
                this.EvadeChance = 5;
                this.AbilityCooldown = 20;
                this.secondChance = 0;
            }
        }

        //Send all items & startwep
        private void UpdateWeapon(string startwep) //Used for updating the startwep
        {
            var item = Items.allWeapons.Where(x => (x.WeaponName == startwep)).FirstOrDefault();
            if (item != null)
            {
                this.StartWeapon = item;
            }
            else
            {
                this.StartWeapon = Items.allWeapons[0];
            }
        }

        private void UpdateArmor(string startarmor) //Used for updating the startarmor
        {
            var item = this.StartArmor = Items.allArmor.Where(x => (x.ArmorName == startarmor)).FirstOrDefault();
            if (item != null)
            {
                this.StartArmor = item;
            }
            else
            {
                this.StartArmor = Items.allArmor[0];
            }
        }
    }
}
