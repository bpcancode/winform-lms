using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms.Models;

public class User
{
    public string UserId { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public List<Book> BorrowedBook { get; set; }

    public void BorrowBook(Book book)
    {
        Library.borrowBook(book);
    }

    public void ReturnBook(Book book)
    {
        Library.returnBook(book);
    }

}
