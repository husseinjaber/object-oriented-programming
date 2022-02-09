using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_10
{
    class drink:article
    {
        private double volume;
        public drink(string brand,float code,DateTime expirationdate,Typefood type,double volume):base(brand,code,expirationdate,type)
        {
            
            
            if (this.volume < 0)
                throw new Exception("negative value");
            else 
               this.volume = volume;
        }
        public double Volume
        {
            set { volume = value; }
            get { return volume; }
        }
        public override void display()
        {
            Console.WriteLine("the food chosen is of brand:" + this.brand + " and of code:" + this.code + " has an expirationdate:" + this.expirationdate + " of type:" + this.type + " of weight:" + this.volume);
        }
        public override string ToString()
        {
            return base.ToString() + "volume:" + this.volume;
        }

    }
}

