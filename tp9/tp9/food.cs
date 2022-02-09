using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_10
{
    class food:article
    {
        private int weight;
        public food(string brand,float code,DateTime expirationdate,Typefood  type,int weight):base(brand,code,expirationdate,type)
        {
            try{ if (weight < 0)
                throw new Exception("negative value");
            
            }
            catch(Exception e)
            { 
            	weight=-1*weight;
            
            }
             this.weight = weight;
           
            }
            
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public override void display()
        {
            Console.WriteLine("the food chosen is of brand:" + this.brand + " and of code:" + this.code + " has an expirationdate:" + this.expirationdate + " of type:" + this.type + " of weight:" + this.weight);
        }
        public override string ToString()
        {
            return base.ToString() + " of weight:" + this.weight;
        }
    }
}
