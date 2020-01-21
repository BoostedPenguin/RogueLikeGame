using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogueLikeGame
{
    public partial class CharacterSelect : Form
    {
        Items items = new Items(); //ALWAYS pass this whatever you do. It contains all created application objects
        MainGUI gui;
        Form1 userForm; //Always pass this, as it's the main form that needs to be closed to exit the application //Or use (app.exit)
        string name;
        public CharacterSelect(string name, Form1 userform)
        {
            InitializeComponent();
            this.name = name;
            this.userForm = userform;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if(rbtBerserker.Checked)                                    //This part was used for testing only: FINAL CHANGES SHOULD BE MADE!
            {
                Characters character = new Characters("Berserker", items);
                UserSettings userSettings = new UserSettings(name, character, items);
                //Randomizer newrandomizer = new Randomizer();


                //Character evade chance
                MessageBox.Show(Randomizer.Evade(userSettings.TotalEvadeChance()).ToString());
                //Mob evade chance
                MessageBox.Show(Randomizer.Evade(items.ReturnMobEvChance(MobTypes.SPIDER)).ToString());

                //Item randomizer on enemy death
                switch(Randomizer.EnemyDeathLoot(items)) //Gives me 1 or null, everytime this is called
                {
                    case Weapons Weapon:
                        Weapons wep = Weapon;
                        MessageBox.Show($"{wep.WeaponName}");
                        break;
                    case Potions Potion:
                        Potions pot = Potion;
                        MessageBox.Show($"{pot.PotionName}");
                        break;
                    case Armor Armor:
                        Armor arm = Armor;
                        MessageBox.Show($"{arm.ArmorName} {arm.DropChance} {arm.ItemArmor}");
                        break;
                    default:
                        MessageBox.Show("No items");
                        break;
                }
            }
            else if(rbtGhost.Checked)
            {
                Characters character = new Characters("Berserker", items); //Creates a new character based on userinput
                UserSettings userSettings = new UserSettings(name, character, items); //ALWAYS pass this <- holds all USER related information
                gui = new MainGUI(items, userSettings, this, userForm);
                this.Hide();
                gui.Show();

            }
            else if(rbtGodKnight.Checked)
            {

            }
        }
    }
}
