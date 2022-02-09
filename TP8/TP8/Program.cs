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
           Employee I1 = new Instructor("Reda", "Ali", 01, "CCNE", "programming", "Electronics");
            
            Console.Write("\n\n\n\n\n\n\n");
            Employee I2 = new Instructor("Khaled", "Karim", 30, "CCNE", "web", "optics");
            Employee p1 = new Administrative_Personnel("Saad", "Ali", 02, "Supervisor");
            Employee p2 = new Administrative_Personnel("hoteit", "nour", 03, "dean");
            Employee p3 = new Administrative_Personnel("khalifa", "ali", 2, "natoor");
            listEmployee L = new listEmployee();
            L.AddEmployee(I1);
            L.AddEmployee(I2);
            L.AddEmployee(p1);
            L.AddEmployee(p2);
            L.AddEmployee(p3);
            L.DisplayEmployee();
            L.DisplayInstructor();
            Console.ReadKey(true);
        }
    }
}
