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
    public partial class PickUp : Form
    {
        public string username;

        public PickUp(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ParentChildList(username).Show();
        }

        private void PickUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@userName", username }
            };

            DatabaseMethods.ExecuteStoredProcedure("spLogout", parameters);
        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {
            string parentPhoneNumber = txtParentPhoneNumber.Text;
            string childUniqueCode = txtChildUniqueCode.Text;

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@phoneNumber", parentPhoneNumber },
                { "@childUniqueCode", childUniqueCode }
            };

            DatabaseMethods.ExecuteStoredProcedure("spPickUp", parameters);
        }
    }
}
