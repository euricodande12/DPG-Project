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
    public partial class ClassList : Form
    {
        public string username;

        public ClassList(string username)
        {
            this.username = username;
            InitializeComponent();
            DatabaseMethods.LoadDataIntoADataGridView(dgvClassListTable, "spDisplayClassList");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ParentChildList(username).Show();
        }

        private void ClassList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@userName", username }
            };

            DatabaseMethods.ExecuteStoredProcedure("spLogout", parameters);
        }
    }
}
