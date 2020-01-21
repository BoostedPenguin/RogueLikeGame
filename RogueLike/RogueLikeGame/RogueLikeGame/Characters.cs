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
        public Characters(string characterName, Items items) //If you want to change a character stats use this!
        {
            if(characterName == "Berserker")
            {
                this.CharacterName = Chars.Berserker;
                UpdateArmor(items.allArmor, "Basic Armor"); //Give him this on game start
                UpdateWeapon(items.allWeapons, "Blunt Saweword"); // ^
                this.Health = 150;
                this.Damage = 1.5;
                this.Armor = 5;
                this.EvadeChance = 10;
                this.AbilityCooldown = 5;
            }
            else if(characterName == "Ghost")
            {
                this.CharacterName = Chars.Ghost;
                string startWep = "Blunt Sword"; //Change this later
                UpdateWeapon(items.allWeapons, startWep);
                this.Health = 1;
                this.Damage = 1.5;
                this.Armor = 5;
                this.EvadeChance = 10;
                this.AbilityCooldown = 5;
            }
            else if(characterName == "GodKnight")
            {
                this.CharacterName = Chars.GodKnight;
                string startWep = "Blunt Sword"; //Change this later
                UpdateWeapon(items.allWeapons, startWep);
                this.Health = 200;
                this.Damage = 1;
                this.Armor = 5;
                this.EvadeChance = 10;
                this.AbilityCooldown = 8;
            }
        }

        //Send all items & startwep
        private void UpdateWeapon(List<Weapons> weapons, string startwep) //Used for updating the startwep
        {
            foreach (Weapons a in weapons)
            {
                if (a.WeaponName == startwep)
                {
                    this.StartWeapon = a;
                }
            }
        }

        private void UpdateArmor(List<Armor> armor, string startarmor) //Used for updating the startarmor
        {
            foreach(Armor a in armor)
            {
                if(a.ArmorName == startarmor)
                {
                    this.StartArmor = a;
                }
            }
        }
    }
}
