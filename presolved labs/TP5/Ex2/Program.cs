using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Point P1, P2;
            P1 = new Point();
            P1.Input();
            P2 = new Point();
            P2.Input();
            P1.Display();
            P2.Display();
            Console.WriteLine("Distance between the points = " + P1.Distance(P2));
            Console.WriteLine("Enter the value of a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b : ");
            b = int.Parse(Console.ReadLine());
            P2.Translate(a, b);
            P2.Display();
            Console.WriteLine("End of program . . . ");
            Console.ReadKey(true);
        }
    }
}
