using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car A, B, C;
            Console.WriteLine(Car.NbC);
            A = new Car("Volvo", "Yellow", 1234, 2000);
            Console.WriteLine(Car.NbC);
            B = new Car("Toyota", "Silver", 1652, 2500);
            Console.WriteLine(Car.NbC);
            C = A;
            Console.WriteLine(Car.NbC);
            Console.WriteLine(C);
            A.TraveledKM = 3500;
            Console.WriteLine(A);
            B.modifyKM(20);
            Console.WriteLine(B);
            A.TraveledKM = 3000;
            Console.WriteLine(A);
            Console.ReadKey();

        }
    }
}
