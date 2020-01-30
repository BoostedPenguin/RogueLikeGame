using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public enum GameCharacters //All available characters
    {
        Berserker,
        Ghost,
        GodKnight
    }

    public class Characters
    {
        public GameCharacters CharacterName { get; set; } //The name > use to check & display
        public int MaxHealth { get; set; }          //Max Health of the character
        public double Damage { get; set; }       //Base damage MULTIPLIER based on character ex: 1.5 x damage
        public int Armor { get; set; }           //Base armor ADDITIVE not MULTIPLICATIVE
        public int EvadeChance { get; set; }     //Chance to evade an attack
        public int AbilityCooldown { get; set; } //The ability cooldown in TURNS
        public Weapons StartWeapon { get; set; } //The starting weapon given on start of game
        public Armor StartArmor { get; set; }    //The starting armor given on start of game
        public int SecondChance { get; set; }


        public Characters()
        {

        }

        public Characters(GameCharacters characterName, int maxHealth, double damage, int armor, int evadeChance, int AbilityCooldown, string startwep, string startarm, int secondch, Items allitems)   //If you want to change a character stats use this!
        {
            this.CharacterName = characterName;
            this.UpdateArmor(startarm, allitems);
            this.UpdateWeapon(startwep, allitems);
            this.MaxHealth = maxHealth;
            this.Damage = damage;
            this.Armor = armor;
            this.EvadeChance = evadeChance;
            this.AbilityCooldown = AbilityCooldown;
            this.SecondChance = secondch;
        }

        public Characters(Items item, GameCharacters characters)
        {
            int index = 0;
            for(int i = 0; i < item.allCharacters.Count; i++)
            {
                if(item.allCharacters[i].CharacterName == characters)
                {
                    index = i;
                    break;
                }
            }
            Characters s = item.allCharacters[index];
            this.CharacterName = s.CharacterName;
            this.StartArmor = s.StartArmor;
            this.StartWeapon = s.StartWeapon;
            this.MaxHealth = s.MaxHealth;
            this.Damage = s.Damage;
            this.Armor = s.Armor;
            this.EvadeChance = s.EvadeChance;
            this.AbilityCooldown = s.AbilityCooldown;
            this.SecondChance = s.SecondChance;
        }

        //Send all items & startwep
        public void UpdateWeapon(string startwep, Items allItems) //Used for updating the startwep
        {
            var item = allItems.allWeapons.Where(x => (x.WeaponName == startwep)).FirstOrDefault();
            if (item != null)
            {
                this.StartWeapon = item;
            }
            else
            {
                this.StartWeapon = allItems.allWeapons[0];
            }
        }

        public void UpdateArmor(string startarmor, Items allItems) //Used for updating the startarmor
        {
            var item = this.StartArmor = allItems.allArmor.Where(x => (x.ArmorName == startarmor)).FirstOrDefault();
            if (item != null)
            {
                this.StartArmor = item;
            }
            else
            {
                this.StartArmor = allItems.allArmor[0];
            }
        }
    }
}
