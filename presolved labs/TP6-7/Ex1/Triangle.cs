using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Triangle
    {
        //attributes
        private Point a, b, c;

        //constructors
        public Triangle(Point x, Point y, Point z)
        {
            a = new Point(x);
            b = new Point(y);
            c = new Point(z);
        }

        public Triangle(int a1, int a2, int b1, int b2, int c1, int c2)
        {
            a = new Point(a1,a2);
            b = new Point(b1,b2);
            c = new Point(c1,c2);
        }

        public Triangle(Triangle t)
        {
            a = t.a;
            b = t.b;
            c = t.c;
        }

        public Triangle()
        {
            a = new Point();
            b = new Point();
            c = new Point();
        }

        //methods
        public void Input()
        {
            Console.WriteLine("Coordinates of A : ");
            a.Input();
            Console.WriteLine("Coordinates of B : ");
            b.Input();
            Console.WriteLine("Coordinates of C : ");
            c.Input();
        }

        public void Display()
        {
            Console.Write("A : ");
            a.Display();
            Console.Write("B : ");
            b.Display();
            Console.Write("C : ");
            c.Display();
        }

        public void Translate(int x,int y)
        {
            a.Translate(x, y);
            b.Translate(x, y);
            c.Translate(x, y);
        }

        public int TriangleType()
        {
            double ab, bc, ac;
            ab = a.Distance(b);
            bc = b.Distance(c);
            ac = a.Distance(c);
            if (ab == ac && ab == bc) return 1;
            if ((ab == ac && bc == ab + ac) || (ab == bc && ac == ab + bc) || (ac == bc && ab == ac + ab)) return 4;
            if (ab == ac || ab == bc || ac == bc) return 2;
            if (ab == ac + bc || ac == ab + bc || bc == ab + ac) return 3;
            return 5;
        }

        public override string ToString()
        {
            return ("A:(" + a.X + "," + a.Y + ")\tB:(" + b.X + "," + b.Y + ")\tC:(" + c.X + "," + c.Y + ")");
        }

        public double Perimeter()
        {
            double ab, ac, bc;
            ab = a.Distance(b);
            bc = b.Distance(c);
            ac = a.Distance(c);
            return ab + bc + ac;
        }
        public static bool operator ==(Triangle t1, Triangle t2)
        {
            if (t1.Perimeter() == t2.Perimeter()) return true;
            else return false;
        }

        public static bool operator !=(Triangle t1, Triangle t2)
        {
            if (t1.Perimeter() != t2.Perimeter()) return true;
            else return false;
        }

        public static bool operator >(Triangle t1, Triangle t2)
        {
            if (t1.Perimeter() > t2.Perimeter()) return true;
            else return false;
        }

        public static bool operator <(Triangle t1, Triangle t2)
        {
            if (t1.Perimeter() < t2.Perimeter()) return true;
            else return false;
        }
    }
}
