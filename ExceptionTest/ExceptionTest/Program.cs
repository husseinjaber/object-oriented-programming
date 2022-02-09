using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = new string[] { "12","17","hello", "16","4.5"};
            int v ;
            for (int i=0; i<6 ; i++)
            {  
                try
                {
                    v = int.Parse(t[i])/i;
                    Console.WriteLine(t[i] + "/" + i + "=" + v);
                }
                catch (DivideByZeroException e)
                {Console.WriteLine("Invalid instruction");}
                catch (IndexOutOfRangeException e)
                {Console.WriteLine("Out of bound"); }
                catch (FormatException e)
                { Console.WriteLine("Invalid input");}
                finally
                { Console.WriteLine("Execution continues...");}
            }
            Console.WriteLine("End of the program");
            Console.ReadKey();
        }
    }
}
