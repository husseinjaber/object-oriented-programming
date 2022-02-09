using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        public void Display(Article a)
        {
            Console.WriteLine(a.ToString());
        }
        static void Main(string[] args)
        {
            Food F1, F2;
            Drink D1, D2;
            SuperMarket S = new SuperMarket();
            F1 = new Food("Torku", 15428,DateTime.Parse("11 / 10 / 2015"), Food.Foodtype.healthy);
            F2 = new Food("Nestle", 12485, DateTime.Parse("9 / 5 / 2015"), Food.Foodtype.normal);
            D1 = new Drink("Pepsi", 11364, DateTime.Parse("4 / 3 / 2015"), Food.Foodtype.unhealthy);
            D2 = new Drink("Milk", 10289, DateTime.Parse("1 / 3 / 2015"), Food.Foodtype.healthy);

            F1._weight = 1000;
            F2._weight = 1250;
            D1._volume = 2250;
            D2._volume = 1000;

            S.Add(F1);
            S.Add(F2);
            S = S + D1;
            S = S + D2;
            Console.WriteLine("Enter the brand to search for");
            string a = Console.ReadLine();
            S.DiplayArticleBrand(a);

            Console.WriteLine("This item exits : "+ S.CountArticleBrand(a));

            Console.WriteLine("Enter the type of food to search for : ");
            string h = Console.ReadLine();
            Console.WriteLine("The items having this foodtype are :");
            S.DisplayArticleT(h);

            Console.WriteLine("End of program . . . ");
            Console.ReadKey(true);
        }
    }
}
