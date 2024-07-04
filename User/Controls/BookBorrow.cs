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
    public partial class BookBorrow : UserControl
    {
        private Library<CD> library = new();
        private Models.User<CD> user = new();
        public BookBorrow()
        {
            InitializeComponent();
            UpdateDataGrid();
        }
         
        private void BookBorrow_Load(object sender, EventArgs e)
        {

        }

        public void UpdateDataGrid()
        {
            dataGridView1.DataSource = typeof(List<Book>);
            dataGridView1.DataSource = Library<CD>.AllBooks;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Book book = (Book)dataGridView1.CurrentRow.DataBoundItem;
            if (book is null) return;
            user.BorrowBook(book);
            UpdateDataGrid();
        }
    }
}
