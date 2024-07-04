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

        Library<Models.User<Book>> library = new();
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
            dataGridView1.DataSource = typeof(List<Models.User<Book>>);
            dataGridView1.DataSource = Library<Models.User<Book>>.AllUsers;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
