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
            Triangle t1, t2;
            int x, y;
            t1 = new Triangle();
            t2 = new Triangle();
            t1.Input();
            t2.Input();
            t1.Display();
            t2.Display();
            Console.WriteLine("Enter the value of x to translate : ");
            x=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of y to translate : ");
            y = int.Parse(Console.ReadLine());
            t2.Translate(x, y);
            t2.Display();
            Console.WriteLine("T1 is of type : " + t1.TriangleType());
            Console.WriteLine("T2 is of type : " + t2.TriangleType());
            Console.WriteLine("Coords of triangle 2 by tostring :\n" + t2.ToString());
            if (t1 == t2) Console.WriteLine("Triangles are equal");
            if (t1 != t2) Console.WriteLine("Triangles are not equal");
            if (t1 > t2) Console.WriteLine("triangle1 greater than triangle 2");
            if (t1 < t2) Console.WriteLine("triangle1 smaller than triangle 2");

            Console.WriteLine("End of program . . . ");
            Console.ReadKey(true);
        }
    }
}
