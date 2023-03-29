using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Store
    {
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Adress { get; set; }


        //Statisk lista
        public static List<Store> stores = new List<Store>();

        //Konstruktor
        public Store(int id, string name, int phoneNumber, string adress)
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Adress = adress;


            //Add THIS objekt to list
            stores.Add(this);

        }
    }
}


