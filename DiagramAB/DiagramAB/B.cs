using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramAB
{
    class B
    {
        public B()
        {
            A.counter++;
            for (int i = 1; i <= A.counter; i++)
                Console.Write("B ");
            Console.WriteLine();
            A a;
                if (A.counter < A.size)
                     a = new A();
        }
    }
}
