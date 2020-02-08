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
        readonly Items allItem;
        readonly GlobalSettings allSettings;
        readonly DictionaryEntries scores;
        readonly string name;
        public CharacterSelect(string name, Items items, GlobalSettings settings, DictionaryEntries scores)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.name = name;
            this.scores = scores;
            this.allItem = items;
            this.allSettings = settings;
        }

        private void OnCharacterSelection(GameCharacters type)
        {
            UserSettings userSettings = new UserSettings(name, type, allItem); //ALWAYS pass this <- holds all USER related information
            MainGUI gui = new MainGUI(userSettings, allItem, allSettings, scores);
            gui.Show();
            this.Dispose();
        }

        private void CharacterSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            allSettings.OnApplicationExit(e);
        }

        private void BtnBerserker_Click(object sender, EventArgs e)
        {
            OnCharacterSelection(GameCharacters.Berserker);
        }

        private void BtnGhost_Click(object sender, EventArgs e)
        {
            OnCharacterSelection(GameCharacters.Ghost);
        }

        private void BtnGodKnight_Click(object sender, EventArgs e)
        {
            OnCharacterSelection(GameCharacters.GodKnight);
        }
    }
}
