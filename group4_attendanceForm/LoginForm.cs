using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group4_attendanceForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check for a dummy admin credential without using SQL
            if (txtUserName.Text == "admin" && txtPassword.Text == "1234")
            {
                this.Hide();
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Invalid Admin Credentials!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
