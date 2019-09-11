using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Core.Entities
{
    public class Author : EntityBase
    {
        public Author()
        {
            Books = new List<Book>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfbirth { get; set; }
        public string Genre { get; set; }
        public ICollection<Book> Books;
    }
}
