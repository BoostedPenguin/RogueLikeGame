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
            allSettings = (GlobalSettings)XmlSerialization.DeserializeObject(1);
            allItems = (Items)XmlSerialization.DeserializeObject(2);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbxName.Text))
            {
                CharacterSelect cs = new CharacterSelect(tbxName.Text, allItems, allSettings);
                this.Hide();
                cs.Show();
            }
        }

        private void TbxName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnStart_Click(sender, e);
            }
        }

        private void BtnMusic_Click(object sender, EventArgs e)
        {
            //GlobalSettings.SoundToggle();
            //GlobalSettings.ChangeSoundImage((Button)sender);
        }

        private void BtnLoadLastSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxName.Text))
            {
                MainGUI gui = new MainGUI(allItems, allSettings);
                this.Hide();
                gui.Show();
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            DeveloperSettings dev = new DeveloperSettings(allItems, allSettings);
            dev.Show();
            this.Hide();
        }
    }
}
