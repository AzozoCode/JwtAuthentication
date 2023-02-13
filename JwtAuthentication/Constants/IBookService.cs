using JwtAuthentication.Models;

namespace JwtAuthentication.Constants
{
    public interface IBookService
    {
        public Book GetBook(int id);

        public IEnumerable<Book> GetBooks();

        public Book CreateBook(Book book);

        public Book UpdateBook(Book book);  

        public bool DeleteBook(int id);
    }
}
