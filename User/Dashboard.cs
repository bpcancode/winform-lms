using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms.User
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookBorrow1.BringToFront();
            bookBorrow1.UpdateDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            returnBook1.BringToFront();
            returnBook1.UpdateDataGrid();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            bookBorrow1.BringToFront();
        }
    }
}
