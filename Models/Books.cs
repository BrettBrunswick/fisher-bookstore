//Named this model "Books" instead of "Book" assuming it needs to match the names
//of my views and controllers as those are plural?

using System;

namespace Fisher.Bookstore.Models
{
    public class Books
    {
        public int BookId {get; set;}

        public string Title {get; set;}

        public Authors Author {get; set;}
        //changed "Author" to "Authors" assuming this is calling the "Authors" Model

        public void SellBook()
        {
            //code to sell book
        }
        
    }
}