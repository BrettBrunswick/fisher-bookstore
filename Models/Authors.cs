//Named this model "Authors" instead of "Author" assuming it needs 
//to match the names of my views and controllers as those are plural?

using System;

namespace Fisher.Bookstore.Models
{
    public class Authors
    {
        public int AuthorId {get; set;}

        public string Name {get; set;}
        
    }
}