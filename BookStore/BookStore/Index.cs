using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Index
    {
        //Properties
        public int Number { get; set; }

        //Statisk lista
        public static List<Index> index = new List<Index>();

        //Konstruktor
        public Index(int number)
        {
            this.Number = number;

            //Add THIS objekt to list
            index.Add(this);
        }

        //Converta från Index till int
        public static implicit operator int(Index v)
        {
            return v.Number;
        }
    }
}
