using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public class Armor
    {
        public string ArmorName { get; set; } //Armor name > use .contains to check
        public int ItemArmor { get; set; } //Amount of armor
        public int EvadeChance { get; set; } //Chance to evade an attack
        public int DropChance { get; set; } //Chance to drop from a source

        public Armor(string name, int armor,int evade, int dropChance)
        {
            this.ArmorName = name;
            this.EvadeChance = evade;
            this.ItemArmor = armor;
            this.DropChance = dropChance;
        }

        public Armor()
        {

        }
    }
}
