using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramAB
{
    class A
    {
        public static int size = 10;
        public static int counter = 0;
        public A()
        {
            B b;
            counter++;
            for (int i = 1; i <= counter; i++)
                Console.Write("A ");
            Console.WriteLine();
            if (counter < size)
                 b = new B();
        }   
    }
}
