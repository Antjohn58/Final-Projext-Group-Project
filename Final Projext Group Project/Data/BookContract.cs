using Final_Projext_Group_Project.Models;

namespace Final_Projext_Group_Project.Data
{
    public interface BookContract
    {
        int? AddBook(Book b);
        List<Book> GetAllBooks();
        Book GetBookById(int Id);
        int? RemoveBookById(int id);
        int? UpdateBook(Book b);
    }
}

