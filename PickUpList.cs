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
    public partial class PickUpList : Form
    {
        public string username;

        public PickUpList(string username)
        {
            InitializeComponent();
            this.username = username;

            DatabaseMethods.LoadDataIntoADataGridView(dgvTodaysPickUpList, "spDisplayTodaysPickUpInformation");
        }

        private void PickUpList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@userName", username }
            };

            DatabaseMethods.ExecuteStoredProcedure("spLogout", parameters);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ParentChildList(username).Show();
        }
    }
}
