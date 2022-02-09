using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Lab8_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First name of the First Instructor");
            string F = Console.ReadLine();
            Console.WriteLine("Enter the Last name of the First Instrusctor");
            string L = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth of the First Instructor");
            DateTime D = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the code of first course ");
            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the code of the second course");
            int c2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Departmnet");
            string dep = Console.ReadLine();

            Instructor I1 = new Instructor(F, L, D, c1, c2, dep);

            Console.WriteLine("Enter the First name of the Second Instructor");
            F = Console.ReadLine();
            Console.WriteLine("Enter the Last name of the Second Instrusctor");
            L = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth of the Second Instructor");
            D = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the code of first course ");
            c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the code of the second course");
            c2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Departmnet");
            dep = Console.ReadLine();

            Instructor I2 = new Instructor(F, L, D, c1, c2, dep);

            Console.WriteLine("Enter the First Name of the First Adminstrative Personnel");
            F = Console.ReadLine();
            Console.WriteLine("Enter the Last Name of the First Adminstrative Personnel");
            L = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth of the First Adminstrative Personnel");
            D = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the function");
            string fun = Console.ReadLine();

            Adminstrative_personnel P1 = new Adminstrative_personnel(F, L, D, fun);

            Console.WriteLine("Enter the First Name of the Second Adminstrative Personnel");
            F = Console.ReadLine();
            Console.WriteLine("Enter the Last Name of the Second Adminstrative Personnel");
            L = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth of the Second Adminstrative Personnel");
            D = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the function");
            fun = Console.ReadLine();

            Adminstrative_personnel P2 = new Adminstrative_personnel(F, L, D, fun);

            ListEmployee l = new ListEmployee();
            l.AddEmployee(I1);
            l.AddEmployee(I2);
            l.AddEmployee(P1);
            l.AddEmployee(P2);
            l.DisplayEmployee();
            l.DisplayInstructor();




        }
       
    }
}
