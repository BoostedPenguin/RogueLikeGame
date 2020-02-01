using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace RogueLikeGame
{
    public partial class Form1 : Form
    {
        Items allItems;
        GlobalSettings allSettings;
        Dictionary<string, int> scores = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            allItems = new Items();
            allSettings = new GlobalSettings();
            allItems.RepopulateTheLists();
            if(!File.Exists(Directory.GetCurrentDirectory() + @"\CurrentUserSettings.xml"))
            {
                btnLoadLastSave.Enabled = false;
            }
            if(!File.Exists(Directory.GetCurrentDirectory() + @"\CurrentGlobalSettings.xml"))
            {
                XmlSerialization.SerializeObject(allSettings);       //<-- USE THESE 2 ONLY WHEN EDITING A SETTING
            }
            if(!File.Exists(Directory.GetCurrentDirectory() + @"\CurrentItems.xml"))
            {
                XmlSerialization.SerializeObject(allItems);    //<-- OR USING SYSTEM DEFAULT
            }
            if(File.Exists(Directory.GetCurrentDirectory() + @"\UserScores.xml"))
            {
                Randomizer.dict = (Dictionary<string, int>)XmlSerialization.Deserialize(); //No need for system default scores
            }

            allSettings = (GlobalSettings)XmlSerialization.DeserializeObject(1);
            allItems = (Items)XmlSerialization.DeserializeObject(2);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbxName.Text))
            {
                if(File.Exists(Directory.GetCurrentDirectory() + @"\CurrentUserSettings.xml"))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to proceed? Your current save will be overwritten", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        StartNewGame();
                    }
                }
                else
                {
                    StartNewGame();
                }
            }
        }

        private void StartNewGame()
        {
            CharacterSelect cs = new CharacterSelect(tbxName.Text, allItems, allSettings);
            this.Hide();
            cs.Show();
        }

        private void TbxName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnStart_Click(sender, e);
            }
        }

        private void BtnLoadLastSave_Click(object sender, EventArgs e)
        {
            MainGUI gui = new MainGUI(allItems, allSettings);
            this.Hide();
            gui.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            DeveloperSettings dev = new DeveloperSettings(allItems, allSettings);
            dev.Show();
            this.Hide();
        }
    }
}
