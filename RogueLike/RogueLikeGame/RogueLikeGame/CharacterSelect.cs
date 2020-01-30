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
        string name;
        public CharacterSelect(string name)
        {
            InitializeComponent();
            this.name = name;
            //GlobalSettings.ChangeSoundImage(btnMusic);
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
            MainGUI gui = new MainGUI(userSettings);
            gui.Show();
            this.Dispose();
        }

        private void BtnMusic_Click(object sender, EventArgs e)
        {
            //GlobalSettings.SoundToggle();
            //GlobalSettings.ChangeSoundImage((Button)sender);
        }

        private void CharacterSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalSettings.OnApplicationExit(e);
        }
    }
}
