using JwtAuthentication.Models;

namespace JwtAuthentication.Persistence
{
    public class BookRepository
    {

        public static List<Book> Books = new List<Book>()
        {
            new(){  Id = 1, Title="Passion of Christ",Description="Life Story Of Jesus Christ",Author="Matthew",NumberOfPages=234},

             new(){ Id = 1 ,Title="The Cry of Halidon",Description="Comic Story",Author="James Gardener",NumberOfPages=134},

              new(){ Id = 1, Title="Grief Child",Description="Story Of Life",Author="Anonymous",NumberOfPages=144},
        };
    }
}
