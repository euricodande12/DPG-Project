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
    public partial class DropOff : Form
    {
        public string username;
        public DropOff(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ParentChildList(username).Show();
        }

        private void DropOff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@userName", username }
            };

            DatabaseMethods.ExecuteStoredProcedure("spLogout", parameters);
        }

        private void btnDropOff_Click(object sender, EventArgs e)
        {
            //New Parent Data
            string parentFirstName = txtParentFirstName.Text;
            string parentLastName = txtParentLastName.Text;
            string parentEmail = txtParentEmail.Text;
            string parentPhoneNumber = txtParentPhoneNumber.Text;

            //New Child Data
            string childFirstName = txtChildFirstName.Text;
            string childLastName = txtChildLastName.Text;
            DateTime childDateOfBirth = dtpChildDateOfBirth.Value;
            string className = txtClassName.Text;

            string parentID = txtParentID.Text;
            string childUniqueCode = txtChildUniqueCode.Text;

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@userName", username },
                { "@parentFirstName", parentFirstName },
                { "@parentLastName", parentLastName },
                { "@email", parentEmail },
                { "@parentPhoneNumber", parentPhoneNumber },
                { "@childFirstName", childFirstName },
                { "@childLastName", childLastName },
                { "@dateOfBirth", childDateOfBirth },
                { "@className", className },
                { "@parentID", parentID },
                { "@childUniqueCode", childUniqueCode },
            };

            DatabaseMethods.ExecuteStoredProcedure("spDropOff", parameters);
        }
    }
}
