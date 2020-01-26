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
        MainGUI gui;
        Form1 userForm; //Always pass this, as it's the main form that needs to be closed to exit the application //Or use (app.exit)
        string name;
        public CharacterSelect(string name, Form1 userform)
        {
            InitializeComponent();
            this.name = name;
            this.userForm = userform;
            GlobalSettings.ChangeSoundImage(btnMusic);
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if(rbtBerserker.Checked)                                    //This part was used for testing only: FINAL CHANGES SHOULD BE MADE!
            {
                OnCharacterSelection(Chars.Berserker);
            }
            else if(rbtGhost.Checked)
            {
                OnCharacterSelection(Chars.Ghost);
            }
            else if(rbtGodKnight.Checked)
            {
                OnCharacterSelection(Chars.GodKnight);
            }
        }

        private void OnCharacterSelection(Chars type)
        {
            Characters character = new Characters(type); //Creates a new character based on userinput
            UserSettings userSettings = new UserSettings(name, character); //ALWAYS pass this <- holds all USER related information
            gui = new MainGUI(userSettings, this, userForm);
            this.Hide();
            gui.Show();
        }

        private void BtnMusic_Click(object sender, EventArgs e)
        {
            GlobalSettings.SoundToggle();
            GlobalSettings.ChangeSoundImage((Button)sender);
        }

        private void CharacterSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalSettings.OnApplicationExit(e);
        }
    }
}
