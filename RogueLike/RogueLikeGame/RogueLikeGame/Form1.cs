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
    public partial class Form1 : Form
    {
        public Form1 mainForm;
        public Form1()
        {
            InitializeComponent();
            Items.RepopulateTheLists();
            mainForm = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbxName.Text))
            {
                GlobalSettings.startGame = true;                //Use this to check if a new game has started & change when needed!
                CharacterSelect cs = new CharacterSelect(tbxName.Text, this);
                this.Hide();
                cs.Show();
            }
        }
    }
}
