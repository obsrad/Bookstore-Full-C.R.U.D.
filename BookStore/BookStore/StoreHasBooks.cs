using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{


    internal class StoreHasBooks
    {
        //Properties
        public int Store_StoreId { get; set; }
        public int Books_BooksId { get; set; }


        //Statisk lista
        public static List<StoreHasBooks> storehasbooks = new List<StoreHasBooks>();

        //Konstruktor
        public StoreHasBooks(int store_storeId, int books_booksId)
        {
            this.Store_StoreId = store_storeId;
            this.Books_BooksId = books_booksId;


            //Add THIS objekt to list
            storehasbooks.Add(this);

        }

    }
}
