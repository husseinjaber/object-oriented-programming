using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person1718
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1, P2, P3, P4;
            Console.WriteLine(Person.NbP);
            P1 = new Person("Jad", 20);
            P2 = new Person("Fadi");
            P3 = P2;
            Console.WriteLine(Person.NbP);
           // P4 = new Person(25, "Ali"); //error
            P4 = new Person(25);
            Console.WriteLine(Person.NbP);
           // Person.NbP = 5;// error the property Nbp dont has a set method
            Console.WriteLine(P2.Age); //0
            Console.WriteLine(P4.Name);//empty string
            
            // set age for P2
            P2.Age = -5;
            Console.WriteLine(P2.Age);// 0
            
            P2.Age = 5;
            Console.WriteLine(P2.Age);//5
            
            Console.WriteLine(P1.ToString());
            Console.WriteLine(P1);// implicit call to ToString
            Console.WriteLine(P1 + "\n" + P2 + "\n" + P3 + "\n" + P4);
           
            Console.ReadKey();
        }
    }
}
