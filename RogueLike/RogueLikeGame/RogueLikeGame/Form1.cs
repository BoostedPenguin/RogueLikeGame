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
        public Form1()
        {
            InitializeComponent();
            Items.RepopulateTheLists();

            string path = Directory.GetCurrentDirectory();
            path += @"\CurrentUserSettings.xml";
            if(!File.Exists(path))
            {
                btnLoadLastSave.Enabled = false;
            }   
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbxName.Text))
            {
                GlobalSettings.startGame = true;                //Use this to check if a new game has started & change when needed!
                CharacterSelect cs = new CharacterSelect(tbxName.Text);
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
                GlobalSettings.startGame = true;                //Use this to check if a new game has started & change when needed!
                MainGUI gui = new MainGUI();
                this.Hide();
                gui.Show();
            }
        }
    }
}
