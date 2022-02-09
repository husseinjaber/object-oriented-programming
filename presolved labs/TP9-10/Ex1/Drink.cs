using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Drink:Article
    {
        private float volume;

        //constructor
        public Drink(string brand, float Code, DateTime ExpirationDate, Foodtype Type)
            : base(brand, Code, ExpirationDate, Type)
        {
            this.volume = volume;
        }

        //properties
        public string _brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public float _Code
        {
            get { return Code; }
            set { Code = value; }
        }

        public DateTime _ExpirationDate
        {
            get { return ExpirationDate; }
            set { ExpirationDate = value; }
        }

        public Foodtype _Type
        {
            get { return Type; }
            set { Type = value; }
        }

        public float _volume
        {
            get { return volume; }
            set { volume = value; }
        }

        //methods
        public void Display()
        {
            Console.WriteLine("(Brand: " + brand + " , Code: " + Code + " , ExpirationDate: " + ExpirationDate + " , Type: " + Type + " , Volume: " + volume + " )");
        }

        public override string ToString()
        {
            return "( " + brand + " , " + Code + " , " + ExpirationDate + " , " + Type + " , " + volume + " )";
        }
    }
}
