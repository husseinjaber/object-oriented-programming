using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_9_10
{
   protected class Article
    {
        private string _brand;
        private float _code;
        private DateTime _expirationdate;
        public enum FoodType { healthy, unhealthy, normal };
        private FoodType _type;

        public Article(string b, float c, DateTime e, FoodType t)
        {
            _brand = b;
            _code = c;
            _expirationdate = e;
            _type = t;
        }
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public float Code
        {
            get { return _code; }
            set { _code = value; }
        }
        public DateTime ExpirationDate
        {
            get { return _expirationdate; }
            set { _expirationdate = value; }
        }
        public FoodType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override string ToString()
        {
            return "Brand:" + _brand + "\tCode:" + _code + "\tExpirationDate" + _expirationdate + "\tType:" + _type;

        }
        public void Display()
        {
            Console.WriteLine(this.ToString());
        }

        public override bool operator ==(Article a1, Article a2)
        {
            if (a1.Brand == a2.Brand && a1.Code == a2.Code)
                return true;
            else return false;
        }
        public override bool operator !=(Article a1, Article a2)
        {
            if (a1.Brand == a2.Brand && a1.Code == a2.Code)
                return false;
            else return true;
        }

               
       3

               
    }
}

