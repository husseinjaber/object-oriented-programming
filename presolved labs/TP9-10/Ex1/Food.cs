using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Food:Article
    {
        private float weight;

        //constructor
        public Food(string brand, float Code, DateTime ExpirationDate, Foodtype Type)
            : base(brand, Code, ExpirationDate, Type)
        {
            this.weight = weight;
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

        public float _weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //methods
        public void Display()
        {
            Console.WriteLine("(Brand: " + brand + " , Code: " + Code + " , ExpirationDate: " + ExpirationDate + " , Type: " + Type + " , Weight: " + weight + " )");
        }

        public override string ToString()
        {
            return "( " + brand + " , " + Code + " , " + ExpirationDate + " , " + Type + " , " + weight + " )";
        }
    }
}
