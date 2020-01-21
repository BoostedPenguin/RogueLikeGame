using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogueLikeGame
{
    public static class GlobalSettings
    {
        public static bool startGame = false;               //Starts the game whenever the player starts a new game OR dies and restarts
        public static int globalEvadeChance = 1;            // Evade calculated: x * multiplier = evade_chance 
        public static int enemyDifficultyMultiplier = 1;    //Enemy dmg is calculated:   x * multiplier = dmg
        public static int characterHealthMultiplier = 1;    //Character health is calculated: x * multiplier = health
        public static int characterArmorMultiplier = 1;     //Character armor is calculated: (base + items) * multiplier = amount blocked 
                                                            //Ex: dragon deals 20 dmg, you have 10 armor = 10 dmg received
        public static int characterDamageMultiplier = 1;    //Character damage is calculated: (base * items) * multiplier = amount dealt
        public static Dictionary<int, string> scores = new Dictionary<int, string>();   //Score of user, name of user

        public static bool isInFight = false;               //If the user is currently in fight

        //public static dynamic ReturnItem(Items items, string nameOfGear, dynamic itemType)
        //{
        //    var foundItem = items.allArmor.Where(a => a.ArmorName == nameOfGear).Select(a => a);
        //    var foundItem = items.
        //    if (temp != null)
        //    {
        //        return temp;
        //    }
        //    else
        //    {
        //        return (Weapons)weapons.Where(x => (x.WeaponName == "Blunt Sword")).First();
        //    }
        //}

        public static void OnApplicationExit(FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialog = MessageBox.Show($"Are you sure you want to exit? {Environment.NewLine} Your current game won't be saved", "Warning", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
