using MatchPairGame;
using MatchPairGame.Model;
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
            RegisterForm register = new RegisterForm();
            register.Show();
        }



        private void buttonLogin_Click(object sender, EventArgs e)
        {

            
            DBConnection db = new DBConnection();
            MatchPairGame.UI.Board board;

            if (textBoxUserName.Text.Equals("") || textBoxPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese usuario y/o Contraseña");
            }else
            {
                if (db.login(textBoxUserName.Text, textBoxPassword.Text) != -1)
                {
                    this.Hide();
                    board = new MatchPairGame.UI.Board();
                    board.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos");

                }
            }

            
        }

        private void windowLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
