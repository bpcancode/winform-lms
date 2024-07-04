using lms.Admin;
using lms.User;

namespace lms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password cannot be empty");
                return;
            }

            if (username == "user" && password == "user")
            {
                Dashboard dashboard = new();
                dashboard.Show();
                this.Hide();
                MessageBox.Show("Welcome User. Login successed");
                return;
            }

            if (username == "admin" && password == "admin")
            {
                AdminDashboard dashboard = new();
                dashboard.Show();
                this.Hide();
                MessageBox.Show("Welcome admin. Login Successed");
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
