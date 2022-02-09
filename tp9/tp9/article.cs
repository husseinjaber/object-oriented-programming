using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_10
{
    public enum Typefood { healthy, unhealthy, normal }
    class article
    {
        protected string brand;
        protected float code;
        protected DateTime expirationdate;
        protected Typefood type;

        public article(string brand,float code,DateTime expirationdate, Typefood type)
        {
            this.brand = brand;
            this.code = code;
            this.expirationdate = expirationdate;
            this.type = type;
                   

        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }

        }
        public float Code
        {
            get { return code; }
            set { code = value; }
        }
        public DateTime Exp
        {
            get { return expirationdate; }
            set { expirationdate = value; }
        }
        public Typefood Type
        {
            get { return type; }
            set { type = value; }
        }
        public virtual void display()
        {
            Console.WriteLine("the food chosen is of brand:" + this.brand + " and of code:" + this.code + " has an expirationdate:" + this.expirationdate + " of type:" + this.type);
        }
        public override string ToString()
        {
            return "brand:" + this.brand + " code:" + this.code + " expiration date:" + this.expirationdate + " type:" + this.type;
        }
        public static bool operator ==(article a1,article a2)
        {
            return a1.brand == a2.brand;
        }
        public static bool operator !=(article a1, article a2)
        {
            return a1.brand != a2.brand;
        }

    }
}

