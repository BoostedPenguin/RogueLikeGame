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

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            RadioButton rbt = this.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            switch(rbt.Name)
            {
                case "rbtBerserker":
                    OnCharacterSelection(GameCharacters.Berserker);
                    break;
                case "rbtGhost":
                    OnCharacterSelection(GameCharacters.Ghost);
                    break;
                case "rbtGodKnight":
                    OnCharacterSelection(GameCharacters.GodKnight);
                    break;
            }
        }

        private void OnCharacterSelection(GameCharacters type)
        {
            UserSettings userSettings = new UserSettings(name, type); //ALWAYS pass this <- holds all USER related information
            gui = new MainGUI(userSettings, userForm);
            this.Dispose();
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
