using System;
using System.Collections.Generic;
using System.Text;

namespace BigMamaLib
{
    public class Pizza
    {
        // instans felter
        private string _fyld;
        private string _name;
        private int _price;
        private int _id;


        // konstruktører

        public Pizza()
        {
            Fyld = "";
            Name = "";
            Price= 0;
            Id= 0;

        }

        public Pizza(string fyld, string name, int price, int id)
        {
            Fyld = fyld;
            Name = name;
            Price = price;
            Id = id;
        }

        // properties

        public string Fyld
        {
            get {  return _fyld; }
            set { _fyld = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Price
        {
            get { return _price; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("pris skal være positiv");
                }
                
                _price = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        // metoder


        public override string ToString()
        {
            return "Fyld: " + Fyld + " Navn: " + Name + " Pris: " + Price + " Id: " + Id;
        }
    }
}
