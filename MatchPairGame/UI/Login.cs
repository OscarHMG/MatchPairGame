using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardMatch.UI
{
    public partial class windowLogin : Form
    {
        public windowLogin()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Application.Run(new BoardMain());
            this.Hide();
            BoardMain board = new BoardMain();
            board.Show();
            
        }

        private void windowLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
