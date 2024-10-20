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
    public partial class DropOffList : Form
    {
        public string username;
        public DropOffList(string username)
        {
            InitializeComponent();
            this.username = username;

            DatabaseMethods.LoadDataIntoADataGridView(dgvTodaysDropOffList, "spDisplayTodaysDropOffInformation");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ParentChildList(username).Show();
        }

        private void DropOffList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@userName", username }
            };

            DatabaseMethods.ExecuteStoredProcedure("spLogout", parameters);
        }
    }
}
