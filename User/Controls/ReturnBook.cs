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

namespace lms.User.Controls
{
    public partial class ReturnBook : UserControl
    {
        private Library library = new();
        private Models.User user = new();
        public ReturnBook()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Library.AllBooks;
        }

        public void UpdateDataGrid()
        {
            dataGridView1.DataSource = typeof(List<Book>);
            dataGridView1.DataSource = Library.AllBooks;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = (Book)dataGridView1.CurrentRow.DataBoundItem;
            if (book is null) return;
            user.ReturnBook(book);
            UpdateDataGrid();
        }
    }
}
