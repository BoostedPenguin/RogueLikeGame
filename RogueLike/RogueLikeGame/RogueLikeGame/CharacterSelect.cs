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
        Items allItem;
        GlobalSettings allSettings;
        string name;
        public CharacterSelect(string name, Items items, GlobalSettings settings)
        {
            InitializeComponent();
            this.name = name;
            this.allItem = items;
            this.allSettings = settings;
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
            UserSettings userSettings = new UserSettings(name, type, allItem); //ALWAYS pass this <- holds all USER related information
            MainGUI gui = new MainGUI(userSettings, allItem, allSettings);
            gui.Show();
            this.Dispose();
        }

        private void CharacterSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            allSettings.OnApplicationExit(e);
        }
    }
}
