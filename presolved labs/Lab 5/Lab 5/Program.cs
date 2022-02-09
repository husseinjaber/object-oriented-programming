using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Length ? :");
            int L = int.Parse(Console.ReadLine());
            Console.WriteLine("character ? :");
            char C = char.Parse(Console.ReadLine());
            Square S = new Square(L, C);
            Console.WriteLine("This is the square:");
            S.Display();
            Console.WriteLine("Perimeter:"+ S.perimeter());
            Console.WriteLine("Area:" + S.Area());
            Console.WriteLine("Extend the square => 3 times more bigger");
            S.Extend(3);
           



            
        }
    }
}
