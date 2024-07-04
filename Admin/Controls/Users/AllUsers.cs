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
    public partial class AllUsers : UserControl
    {

        Library library = new();
        public AllUsers()
        {
            InitializeComponent();
        }

        public void AllUsers_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        public void UpdateDataGrid()
        {
            dataGridView1.DataSource = typeof(List<Models.User>);
            dataGridView1.DataSource = Library.AllUsers;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
