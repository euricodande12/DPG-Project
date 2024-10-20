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
    public partial class ParentChildList : Form
    {
        public String username;
        public ParentChildList(string username)
        {
            this.username = username;
            InitializeComponent();
            DatabaseMethods.LoadDataIntoADataGridView(tblParentsAndChildren, "spDisplayParentsAndChildrenDetails");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@userName", username }
            };

            DatabaseMethods.ExecuteStoredProcedure("spLogout", parameters);
            this.Hide();
            new Login().Show();
        }

        private void btnCreateOrEditClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateOrUpdateClass(username).Show();
        }

        private void btnClassList_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClassList(username).Show();
        }

        private void btnDropOff_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DropOff(username).Show();
        }

        private void ParentChildList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@userName", username }
            };

            DatabaseMethods.ExecuteStoredProcedure("spLogout", parameters);
        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PickUp(username).Show();
        }

        private void btnDropOffList_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DropOffList(username).Show();
        }

        private void btnPickUpList_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PickUpList(username).Show();
        }

        private void btnEditParent_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditParentOrChild(username).Show();
        }
    }
}
