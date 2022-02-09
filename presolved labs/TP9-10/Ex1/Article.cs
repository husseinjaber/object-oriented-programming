using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Article
    {
        public enum Foodtype { healthy, unhealthy, normal };
        protected string brand;
        protected float Code;
        protected DateTime ExpirationDate;
        protected Foodtype Type;

        //constructor
        public Article(string brand, float Code, DateTime ExpirationDate, Foodtype Type)
        {
            this.brand = brand;
            this.Code = Code;
            this.ExpirationDate = ExpirationDate;
            this.Type = Type;
        }

        //properties
        public string _brand
        {
            get {return brand;}
            set {brand=value;}
        }

        public Foodtype _Type
        {
            get { return this.Type; }
            set { Type = value; }
        }

        public override string ToString()
        {
            return "( " + brand + " , " + Code + " , " + ExpirationDate + " , " + Type + " )";
        }

        public static bool operator ==(Article a1, Article a2)
        {
            if (a1.Code == a2.Code && a1.brand == a2.brand) return true;
            else return false;
        }

        public static bool operator !=(Article a1, Article a2)
        {
            if (a1.Code != a2.Code || a1.brand != a2.brand) return true;
            else return false;
        }
    }
}
