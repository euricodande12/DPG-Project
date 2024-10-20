using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoahsArk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@userName", username },
                { "@password", password }
            };

            // Execute the stored procedure
            int isAuthenticated = DatabaseMethods.ExecuteStoredProcedureWithOutput("spLogin", parameters);

            if (isAuthenticated == 1)
            {
                this.Hide();
                new ParentChildList(username).Show();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
