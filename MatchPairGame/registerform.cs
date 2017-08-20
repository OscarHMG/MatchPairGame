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

namespace MatchPairGame
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCancelRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string name = textBoxName.Text;
            string lastName = textBoxLastName.Text;
            string birthDate = textBirthDate.Text;
            string email = textBoxEmail.Text;

            if (userName.Equals("") || password.Equals("") || name.Equals("") || lastName.Equals("") ||
                birthDate.Equals("") || email.Equals("") )
            {
                MessageBox.Show("Complete el formulario, antes de registrarse");
            }else
            {
                DBConnection db = new DBConnection();
                db.register(userName, password, name, lastName, birthDate, email);
                this.Close();
            }

        }

        private void textBirthDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
