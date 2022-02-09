using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square S;
            int L, E;
            char C;
            Console.WriteLine("Enter the length of side :");
            L = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Character :");
            C = char.Parse(Console.ReadLine());
            S = new Square(L, C);
            S.Display();
            Console.WriteLine();
            Console.WriteLine("Area = " + S.Area());
            Console.WriteLine("Perimeter = " + S.Perimeter());
            Console.WriteLine();
            Console.WriteLine("Enter a value to extend");
            E = int.Parse(Console.ReadLine());
            Console.WriteLine("Extend the square=> " + E + " more times bigger\n");
            S.Extend(E);
            S.Display();
            Console.WriteLine("End of program . . . ");
            Console.ReadKey(true);
        }
    }
}
