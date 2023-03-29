using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Author
    {
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }


        //Statisk lista
        public static List<Author> authors = new List<Author>();

        //Konstruktor
        public Author(int id, string name)
        {
            this.Id = id;
            this.Name = name;


            //Add THIS objekt to list
            authors.Add(this);

        }
    }
}
