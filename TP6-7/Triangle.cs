using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5;
namespace TP6
{
    class Triangle
    {
        Point A, B, C;

        #region Constructors
        public Triangle(Point A,Point B,Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public Triangle(double x1,double y1,double x2,double y2,double x3,double y3)
        {
            A = new Point(x1, y1);
            B = new Point(x2, y2);
            C = new Point(x3, y3);
        }

        public Triangle (Triangle triangle)
        {
            A = triangle.A;
            B = triangle.B;
            C = triangle.C;
        }
        #endregion


        public void input()
        {
            double x, y;

            Console.WriteLine("abscissa: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ordinate: ");
            y = double.Parse(Console.ReadLine());
            A.Input(x, y);

            Console.WriteLine("abscissa: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ordinate: ");
            y = double.Parse(Console.ReadLine());
            B.Input(x, y);

            Console.WriteLine("abscissa: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ordinate: ");
            y = double.Parse(Console.ReadLine());
            C.Input(x, y);

        }


        public void display()
        {
            A.Display();
            B.Display();
            C.Display();
        }

        public void translate(double dx,double dy)
        {
          
            A.translate(dx, dy);
            B.translate(dx, dy);
            C.translate(dx, dy);
        }

       public int TriangleType()
        {
            double AB = A.Distance(B);
            double BC = B.Distance(C);
            double AC = A.Distance(C);

            if (AB == AC && AB == BC) //equilateral
                return 1;
            if ((AB == AC + BC) || (AC == AB + BC) || (BC == AB + AC)) //if right then check if isosceles or not
                if ((AB == AC) || (AC == BC) || (BC == AB))
                    return 4; //right isosceles
                else return 3; //right

            if ((AB == AC) || (AC == BC) || (BC == AB)) //isosceles
                return 2;

            return 5; //any
        }

        public double perimeter()
        {
            double AB = A.Distance(B);
            double BC = B.Distance(C);
            double AC = A.Distance(C);
            return AB + BC + AC;
        }

        public override string ToString()
        {
            return string.Format("Point1: ({0},{1})\nPoint1: ({2},{3})\nPoint1: ({4},{5})",A.X,A.Y,B.X,B.Y,C.X,C.Y);
        }

       public static bool operator == (Triangle t1, Triangle t2)
        {
            if (t1.perimeter() == t2.perimeter())
                return true;
            else return false;
        }
        public static bool operator !=(Triangle t1, Triangle t2)
        {
            if (t1.perimeter() != t2.perimeter())
                return true;
            else return false;
        }

        public static bool operator >(Triangle t1, Triangle t2)
        {
            if (t1.perimeter() > t2.perimeter())
                return true;
            else return false;
        }
        public static bool operator <(Triangle t1, Triangle t2)
        {
            if (t1.perimeter() < t2.perimeter())
                return true;
            else return false;
        }

    }
}
