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
            InitializeComponent();
            this.username = username;
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
    }
}
