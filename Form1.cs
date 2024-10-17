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
            String firstName = txtFirstName.Text;
            String lastName = txtLastName.Text;
            String username = txtUsername.Text;
            String password = txtPassword.Text;

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
    }
}
