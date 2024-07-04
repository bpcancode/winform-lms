using lms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms.Admin.Controls.Users
{
    public partial class RemoveUser : UserControl
    {
        Library library = new();
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void RemoveUser_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        public void UpdateDataGrid()
        {
            dataGridView1.DataSource = typeof(List<Models.User>);
            dataGridView1.DataSource = Library.AllUsers;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.User usr = (Models.User)dataGridView1.CurrentRow.DataBoundItem;
            if (usr is null) return;
            library.RemoveUser(usr);
            UpdateDataGrid();
        }
    }
}
