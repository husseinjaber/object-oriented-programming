using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExceptionDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c; bool ok = false;
            do
            {
                try
                {
                    Console.Write("Give two integers: ");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("c = " + c);
                    ok = true;
                }
                catch (DivideByZeroException E)
                {
                    Console.WriteLine("Warning division by zero!! " + E.Message);
                }
                catch (FormatException E)
                {
                    Console.WriteLine("Error while converting!! " + E);
                }
                finally
                {
                    Console.WriteLine("Execution continues...");
                }
            } while (!ok);
            Console.WriteLine("End of the program...");
            Console.ReadKey();
        }
    }
}
