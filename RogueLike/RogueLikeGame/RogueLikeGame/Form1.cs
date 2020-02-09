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
        readonly DictionaryEntries scores;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            allItems = new Items();
            allSettings = new GlobalSettings();
            scores = new DictionaryEntries();
            allItems.RepopulateTheLists();
            if(!File.Exists(Directory.GetCurrentDirectory() + @"\CurrentUserSettings.xml"))
            {
                btnLoadLastSave.Enabled = false;
                btnLoadLastSave.BackColor = Color.FromArgb(78, 31, 3);
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
                scores = (DictionaryEntries)XmlSerialization.DeserializeObject(3);
            }

            allSettings = (GlobalSettings)XmlSerialization.DeserializeObject(1);
            allItems = (Items)XmlSerialization.DeserializeObject(2);

            lbxScores.Items.Clear();
            lbxScores.Items.Add($"Id\tName\t\tScore");
            for (int i = 0; i < scores.Id.Count; i++)
            {
                lbxScores.Items.Add($"{scores.Id[i]}\t{scores.Name[i]}\t\t{scores.Points[i]}");
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbxName.Text) && tbxName.Text.Length < 6)
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
            else
            {
                lblWrongUsername.Text = $"Use a name between 1-6 characters";
                tbxName.BackColor = Color.IndianRed;
            }
        }

        private void StartNewGame()
        {
            CharacterSelect cs = new CharacterSelect(tbxName.Text, allItems, allSettings, scores);
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
            MainGUI gui = new MainGUI(allItems, allSettings, scores);
            this.Hide();
            gui.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            DeveloperSettings dev = new DeveloperSettings(allItems, allSettings);
            dev.Show();
            this.Hide();
        }

        private void BtnScores_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }
    }
}
