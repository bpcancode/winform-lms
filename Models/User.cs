using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms.Models;

public class User<T>
{
    public string UserId { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public List<Book> BorrowedBook { get; set; }
    public List<T> borrowedItems { get; set;}

    public void BorrowBook(Book book)
    {
        Library<Book>.borrowBook(book);
    }

    public void ReturnBook(Book book)
    {
        Library<Book>.returnBook(book);
    }

    public void BorrowItem (T item)
    {
        Library<T>.borrowItem(item);
    }

    public void ReturnItem(T item)
    {
        Library<T>.returnItem(item);
    }

}
