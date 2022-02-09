using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor I1, I2;
            Administrative_personnel P1, P2;
            listEmployee L;
            I1 = new Instructor("Majid", "Kadiri", DateTime.Parse("5/11/1995"), "OOP", "RDB","CCNE");
            I2 = new Instructor("Mhmd", "Ali", DateTime.Parse("10/2/1991"), "Math", "Algebra", "GC");
            P1 = new Administrative_personnel("Ahmad", "Hajjar", DateTime.Parse("1/7/1992"), "Director");
            P2 = new Administrative_personnel("Ali", "Saleh", DateTime.Parse("8/1/1993"), "Supervisor");
            L= new listEmployee();
            L.AddEmployee(I1);
            L.AddEmployee(I2);
            L.AddEmployee(P1);
            L.AddEmployee(P2);
            L.DisplayEmployee();
            L.DisplayInstructor();
            Console.ReadKey(true);
        }
    }
}
