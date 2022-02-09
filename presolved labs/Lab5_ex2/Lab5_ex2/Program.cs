using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Xa");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ya");
            int y = int.Parse(Console.ReadLine());
            Point A = new Point(x, y);
            Console.WriteLine("Enter Xb");
             x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Yb");
             y = int.Parse(Console.ReadLine());
            Point B = new Point(x, y);
            Console.WriteLine("Enter Xc");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Yc");
            y = int.Parse(Console.ReadLine());
            Point C = new Point(x, y);
            Triangle T1 = new Triangle(A, B, C);
            int s = T1.TypeTriangle();
            switch (s)
            {
                case 1: Console.WriteLine("Equilateral Triangle"); break;
                case 2: Console.WriteLine("Isosceles Triangle"); break;
                case 3: Console.WriteLine("Right Triangle"); break;
                case 4: Console.WriteLine("Right Isosceles Triangle"); break;
                case 5: Console.WriteLine("Any Triangle"); break;
            }
            Console.WriteLine("Enter Xd");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Yd");
            y = int.Parse(Console.ReadLine());
            Point D = new Point(x, y);
            Console.WriteLine("Enter Xe");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ye");
            y = int.Parse(Console.ReadLine());
            Point E = new Point(x, y);
            Console.WriteLine("Enter Xf");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Yf");
            y = int.Parse(Console.ReadLine());
            Point F = new Point(x, y);

            Triangle T2= new Triangle(D,E,F);

            if (T1==T2)
                Console.WriteLine("The Triangles are equal");
                else Console.WriteLine("The Triangles are not equal");
            Console.WriteLine("Enter Xg");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Yg");
            y = int.Parse(Console.ReadLine());
            ColorPoint Cp = new ColorPoint(x, y, "None");
            Cp.Display();
            Console.WriteLine("Choose the new Color");
            Console.WriteLine("1) Red");
            Console.WriteLine("2) Blue");
            Console.WriteLine("3) Green");
            Console.WriteLine("4) Yellow");
            int j=int.Parse(Console.ReadLine());
            Cp.SetColor(j);
            Cp.Display();





            



            


            
            

            




        }
    }
}
