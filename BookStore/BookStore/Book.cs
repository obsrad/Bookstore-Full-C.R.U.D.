using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Book
    {
        //Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }


        //Statisk lista

        public static List<Book> books = new List<Book>();

        //Konstruktor
        public Book(int id, string title, int AuthorId)
        {
            this.Id = id;
            this.Title = title;
            this.AuthorId = AuthorId;



            //Add THIS objekt to list
            books.Add(this);

        }

    }
}
