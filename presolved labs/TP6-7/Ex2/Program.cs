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
            ColorPoint a, b;
            int x, y;
            string c;
            Console.WriteLine("Enter the abscissa of the point : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ordinate of the point : ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the color of the point : ");
            c = Console.ReadLine();
            a = new ColorPoint(x, y, c);
            Console.WriteLine("Enter the abscissa of the point : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ordinate of the point : ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the color of the point : ");
            c = Console.ReadLine();
            b = new ColorPoint(x, y, c);

            a.Display();
            b.Display();

            Console.WriteLine("Enter a number to change color of point 2");
            int f = int.Parse(Console.ReadLine());
            b.SetColor(f);

            b.Display();

            Console.WriteLine("End of pogram . . . ");
            Console.ReadKey(true);
        }
    }
}
