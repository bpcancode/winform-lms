
using System.Text.Json;

namespace lms.Models;

public  class Library<T>
{
    public static List<T> items = new List<T>();
    public static List<Book> AllBooks { get; set; } =[];
    public static List<User<T>> AllUsers { get; set; } = [];
    public Library()
    {

        AllBooks.Clear();
        AllUsers.Clear();
        FillBook();
        FillUser();
    }



    private void FillBook()
    {
        
        foreach (string line in File.ReadLines(GetFilePath("inventory.txt")))
        {
            var book = JsonSerializer.Deserialize<Book>(line);
            AllBooks.Add(book);
        }
    }

    private void FillUser()
    {
        foreach (string line in File.ReadLines(GetFilePath("users.txt")))
        {
            var book = JsonSerializer.Deserialize<User<T>>(line);
            AllUsers.Add(book);
        }
    }
    public  void AddBook(Book book)
    {
        AllBooks.Add(book);
    }

    public  void RemoveBook(Book book)
    {
        /*string bookStr = JsonSerializer.Serialize(book);
        var linesToKeep = File.ReadLines(GetFilePath("inventory.txt")).Where(l => l != bookStr);
        File.WriteAllLines(GetFilePath("inventory.txt"), linesToKeep);
        FillUser();*/
        AllBooks.Remove(book);
    }

    public  List<Book> AvailableBook()
    {
        return AllBooks;
    }

    public  List<Book> SearchBookTitle(string title)
    {
        
        return AllBooks.Where(book => book.Title == title).ToList();

    }


    public void AddUser(Models.User<T> usr)
    {
        AllUsers.Add(usr);
        MessageBox.Show("User Added Successfully");
    }

    public void RemoveUser(Models.User<T> usr)
    {
        AllUsers.Remove(usr);
        MessageBox.Show("User Remove Successfully");
    }

    public List<User<T>> AllUser()
    {
        return AllUsers;
    }

    public static void borrowItem(T item)
    {
        User<T> user = new User<T>();
        user.borrowedItems.Add(item);
    }

    public static void returnItem(T item)
    {
        User<T> user = new User<T>();
        user.borrowedItems.Remove(item);
    }

    public static void borrowBook(Book book)
    {
        if(book.IsAvailable)
        {
            book.Status = "Borrowed";
            MessageBox.Show("Book borrowed Successfully");
            return;
        }
        MessageBox.Show("Sorry Book is not available to Borrow");
    }

    public static void returnBook(Book book)
    {
        if (book.IsAvailable)
        {
            book.Status = "Available";
            MessageBox.Show("Book Returned Successfully");
            return;
        }
        MessageBox.Show("Sorry Book is not Borrowed. You cannot return it.");
    }

    private  string GetFilePath(string file)
    {
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        return Path.Combine(docPath, file);
    }
}
