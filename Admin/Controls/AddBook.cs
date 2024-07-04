using lms.Models;


namespace lms.Admin.Controls
{
    public partial class AddBook : UserControl
    {
        private readonly Library _library = new();

        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string author = authorTextBox.Text;
            string isbn = isbnTextBox.Text;

            if(string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(isbn) )
            {
                MessageBox.Show("Please enter value in all form field");
                return;
            }

            _library.AddBook(new Book { Author = author, Title= title,  Isbn = isbn});
            MessageBox.Show("New Book Added Successfully");
        }
    }
}
