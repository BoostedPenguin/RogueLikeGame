using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public class Potions
    {
        public string PotionName { get; set; }  //Pot name .contains
        public double Damage { get; set; }      //Pot damage / health depending on IsHealth
        public int DropChance { get; set; }     //Chance to drop
        public bool IsHealthPotion { get; set; }    //If its a health pot

        public Potions(string name, double damage, int dropChance, bool isHealth)
        {
            this.IsHealthPotion = isHealth;
            this.PotionName = name;
            this.Damage = damage;
            this.DropChance = dropChance;
        }
    }
}
