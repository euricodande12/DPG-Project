using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NoahsArk
{
    public partial class CreateOrUpdateClass : Form
    {
        public string username;

        public CreateOrUpdateClass(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text;

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@className", className },
                { "@username", username }
            };

            DatabaseMethods.ExecuteStoredProcedure("spCreateClass", parameters);

            txtClassOldName.Text = "";
            txtClassNewName.Text = "";
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            string classOldName = txtClassOldName.Text;
            string classNewName = txtClassNewName.Text;

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@username", username },
                { "@classOldName", classOldName },
                { "@classNewName", classNewName }
            };

            DatabaseMethods.ExecuteStoredProcedure("spUpdateClassDetails", parameters);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ParentChildList(username).Show();
        }

        private void CreateOrUpdateClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@userName", username }
            };

            DatabaseMethods.ExecuteStoredProcedure("spLogout", parameters);
        }
    }
}
