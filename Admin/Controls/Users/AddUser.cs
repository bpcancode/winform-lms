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
    public partial class AddUser : UserControl
    {
        Library library = new();
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = this.textBox1.Text;
            string userName = this.textBox2.Text;

            if(string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(userName) )
            {
                MessageBox.Show("Please fill all field to creata a new user");
                return;
            }
            
            library.AddUser(new Models.User { UserId = userId, UserName = userName});
        }
    }
}
