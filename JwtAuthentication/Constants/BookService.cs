using JwtAuthentication.Models;
using JwtAuthentication.Persistence;
using System.Reflection;

namespace JwtAuthentication.Constants
{
    public class BookService : IBookService
    {
        

        
       
        public Book CreateBook(Book book)
        {
            book.Id = BookRepository.Books.Count + 1;
            BookRepository.Books.Add(book);
            return book;
        }

        public bool DeleteBook(int id)
        {
           var book = BookRepository.Books.FirstOrDefault(x => x.Id == id);
            if(book != null)
            {
                BookRepository.Books.Remove(book);
                return true;
            }
            return false;
        }

        public Book GetBook(int id)
        {
            var book = BookRepository.Books.FirstOrDefault(x => x.Id == id);
            if(book is not null)
            {
                return book;
            }
            return null;
        }

        public IEnumerable<Book> GetBooks()
        {
            
            return BookRepository.Books.ToList();
        }

        public Book? UpdateBook(Book newBook)
        {
            var oldBook = BookRepository.Books.Find(book => book.Id == newBook.Id);
            if (oldBook is null) return null;

            oldBook.Title = newBook.Title;
            oldBook.Description = newBook.Description;
            oldBook.Author = newBook.Author;
            oldBook.NumberOfPages = newBook.NumberOfPages;


           
        }
    }
}
