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
    public partial class RemoveBook : UserControl
    {
        private Library<Book> _library = new();
        public RemoveBook()
        {
            InitializeComponent();
        }

        private void RemoveBook_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        public void UpdateDataGrid()
        {
            dataGridView1.DataSource = typeof(List<Book>);
            dataGridView1.DataSource = Library<Book>.AllBooks;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = (Book)dataGridView1.CurrentRow.DataBoundItem;
            if (book is null) return;
            _library.RemoveBook(book);
            UpdateDataGrid();
        }
    }
}
