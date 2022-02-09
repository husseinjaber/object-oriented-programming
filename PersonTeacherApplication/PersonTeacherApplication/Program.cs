using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonTeacherApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Person P1;
            string name, address; int age;
            Console.Write("Give name, age, address : ");
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            address = Console.ReadLine();
            P1 = new Person(name, age, address);
            //2
            Console.WriteLine(P1.identity());
            //3
            Teacher T1; int salary;
            Console.Write("Give salary : ");
            salary = int.Parse(Console.ReadLine());
            T1 = new Teacher(P1, salary);
            //4
            Console.WriteLine(T1.identity());
            //display the name of T1
            Console.WriteLine(T1.P.Name);
            //creation of another teacher
            Teacher T2 = new Teacher(new Person("Jad", 25, "Beirut"), 1500);
            //display the name of T2
            Console.WriteLine(T2.P.Name);
            // fill an array of 3 Teachers
            Teacher[] T = new Teacher[3];
            for (int i = 0; i < T.Length; i++)
            {
                Console.Write(" Give name age address salary");
                name = Console.ReadLine();
                age = int.Parse(Console.ReadLine());
                address = Console.ReadLine();
                salary = int.Parse(Console.ReadLine());
                T[i] = new Teacher(new Person(name, age, address), salary);
            }
            //-	multiply by 2 the salary of the teachers
            for (int i = 0; i < T.Length; i++)
                T[i].Salary *= 2;
            // increase by 1 the age of the second teacher
            T[1].P.Age++;
            //display the identities of the teachers
            for (int i = 0; i < T.Length; i++)
                Console.WriteLine(T[i].identity());
            //diplay the ages of the teachers
            for (int i = 0; i < T.Length; i++)
                Console.WriteLine(T[i].P.Age); 
            Console.ReadKey();
            


             
        }
    }
}
