using Final_Projext_Group_Project.Models;

namespace Final_Projext_Group_Project.Data
{
    public class BookService : BookContract
    {
        FinalContext ctx;
        public BookService(FinalContext Context)
        {
            ctx = Context;
        }
        public int? AddBook(Book b)
        {
            var book = this.GetBookById(b.Id);
            if (book != null)
            {
                return null;
            }
            ctx.Books.Add(b);
            return ctx.SaveChanges();
        }
        public List<Book> GetAllBooks()
        {
            return ctx.Books.ToList();
        }

        public Book GetBookById(int Id)
        {
            return ctx.Books.FirstOrDefault(x => x.Id == Id);
        }
        public int? RemoveBookbyId(int id)
        {
            var book = this.GetBookById(id);
            if (book == null)
            {
                return null;
            }
            ctx.Books.Remove(book);
            return ctx.SaveChanges();
        }

        public int? RemoveBookById(int id)
        {
            var book = this.GetBookById(id);
            if (book == null)
            {
                return null;
            }
            ctx.Books.Remove(book);
            return ctx.SaveChanges();
        }

        public int? UpdateBook(Book b)
        {
            ctx.Books.Update(b);
            return ctx.SaveChanges();
        }
    }
}
