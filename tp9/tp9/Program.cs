using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_10
{
    class Program
    {
    	static void disp(article A)
    	{
    		Console.WriteLine(A.ToString());
    	}
        

        static void Main(string[] args)
        {
            food f1,f2;
           
                 f1 = new food("markiz", 20, DateTime.Parse("15/6/1998"), Typefood.healthy, -80);
                 f2 = new food("dalia", 19, DateTime.Parse("9/12/1998"), Typefood.normal, 52);
            
            drink d1 = new drink("thh", 42, DateTime.Parse("9/6/2009"), Typefood.unhealthy, 99);
             drink d2 = new drink("thh", 42, DateTime.Parse("19/6/2009"), Typefood.healthy, 95);
            supermarket s = new supermarket();
            s.AddArticle(f1);
            s.AddArticle(f2);
            s.AddArticle(d1);
            s.AddArticle(d2);
            s.displayArticleBrand("markiz");
            
            s.displayFood(Typefood.healthy);
            disp(f1);
            disp(d1);
            
            Console.ReadKey();
        }
    }
}
