using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle A, B;
            A = new Circle(-2, 3, 5);
            B = new Circle(4, 6, 7);
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(A.perimeter());
            Circle C = new Circle(23.5f, 12.1f,-5.2f);
            Console.WriteLine(C);
            int x, y, r;


            Console.ReadKey();
        }
    }
}
