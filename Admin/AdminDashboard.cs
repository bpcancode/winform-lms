using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            addBook1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            allBooks1.BringToFront();
            allBooks1.updateDataGrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            allUsers1.BringToFront();
            allUsers1.UpdateDataGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addUser1.BringToFront();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            allBooks1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            removeUser1.BringToFront();
            removeUser1.UpdateDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            removeBook1.BringToFront();
            removeBook1.UpdateDataGrid();
        }
    }
}
