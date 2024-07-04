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

namespace lms.Admin.Controls
{
    public partial class AllBooks : UserControl
    {

        private Library<Book> library = new();
        public AllBooks()
        {
            InitializeComponent();
            updateDataGrid();
        }

        private void AllBooks_Load(object sender, EventArgs e)
        {
            var books = Library<Book>.AllBooks;
            dataGridView1.DataSource = books;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var searchKey = textBox1.Text;
            if (string.IsNullOrEmpty(searchKey))
            {
                var allbooks = Library<Book>.AllBooks;
                dataGridView1.DataSource = allbooks;
                return;
            }
            var books = library.SearchBookTitle(searchKey);
            dataGridView1.DataSource = books;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = (Book)dataGridView1.CurrentRow.DataBoundItem;
            if (book is null) return;
            library.RemoveBook(book);
            updateDataGrid();
        }

        public void updateDataGrid()
        {
            dataGridView1.DataSource = typeof(List<Book>);
            dataGridView1.DataSource = Library<Book>.AllBooks;
        }
    }
}
