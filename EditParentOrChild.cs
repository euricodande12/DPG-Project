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
    public partial class EditParentOrChild : Form
    {
        public string username;

        public EditParentOrChild(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ParentChildList(username).Show();
        }

        private void EditParentOrChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@userName", username }
            };

            DatabaseMethods.ExecuteStoredProcedure("spLogout", parameters);
        }

        private void btnEditParentInformation_Click(object sender, EventArgs e)
        {
            string parentID = txtParentID.Text;
            string parentFirstName = txtParentFirstName.Text;
            string parentLastName = txtParentLastName.Text;
            string parentEmail = txtParentEmail.Text;
            string parentPhoneNumber = txtParentPhoneNumber.Text;

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@parentID", parentID },
                { "@parentFirstName", parentFirstName },
                { "@parentLastName", parentLastName },
                { "@email", parentEmail },
                { "@parentPhoneNumber", parentPhoneNumber }
            };

            DatabaseMethods.ExecuteStoredProcedure("spUpdateParentDetails", parameters);
        }

        private void btnEditChildInformation_Click(object sender, EventArgs e)
        {
            string childUniqueCode = txtChildUniqueCode.Text;
            string childFirstName = txtChildFirstName.Text;
            string childLastName = txtChildLastName.Text;
            DateTime childDateOfBirth = dtpDateOfBirth.Value;

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@childUniqueCode", childUniqueCode },
                { "@firstName", childFirstName },
                { "@lastName", childLastName },
                { "@dateOfBirth", childDateOfBirth }
            };

            DatabaseMethods.ExecuteStoredProcedure("spUpdateChildDetails", parameters);
        }
    }
}
