namespace NoahsArk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@userName", username },
                { "@password", password },
                { "@firstName", firstName },
                { "@lastName", lastName }
            };

            DatabaseMethods.ExecuteStoredProcedure("spSignUp", parameters);
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
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
