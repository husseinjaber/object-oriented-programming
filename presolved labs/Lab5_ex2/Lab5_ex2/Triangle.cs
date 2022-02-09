using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_ex2
{
    class Triangle
    {
        private Point _A;
        private Point _B;
        private Point _C;



        public Triangle(Point a, Point b, Point c)
        {
            this._A = new Point(a);
            this._B = new Point(b);
            this._C = new Point(c);
        }




        public Triangle(int Xa, int Ya, int Xb, int Yb, int Xc, int Yc)
        {
            this._A = new Point(Xa, Ya);
            this._B = new Point(Xb, Yb);
            this._C = new Point(Xc, Yc);
        }





        public Triangle(Triangle T)
        {
            this._A = new Point(T._A);
            this._B = new Point(T._B);
            this._C = new Point(T._C);
        }

        public void Input()
        {

            Console.WriteLine("First Point:");
            _A.Input();
            Console.WriteLine("Second Point");
            _B.Input();
            Console.WriteLine("Third Point");
            _C.Input();
        }

        public void Display()
        {
            Console.WriteLine("First Point");
            _A.Display();
            Console.WriteLine("Second Point");
            _B.Display();
            Console.WriteLine("Third Point");
            _C.Display();
        }

        public void Translate(int a, int b, int c, int d, int e, int f)
        {
            _A.Translate(a, b);
            _B.Translate(c, d);
            _C.Translate(e, f);
        }

        public int TypeTriangle()
        {
            double AB, AC, BC;
            AB = _A.Distance(_B);
            AC = _A.Distance(_C);
            BC = _B.Distance(_C);
            if (AB == AC && AC == BC)
                return 1;
            if (AB == BC && AC == BC + AB)
                return 4;
            if (AC == BC && AB == AC + BC)
                return 4;
            if (AB == AC && BC == AC + AB)
                return 4;
            if (AB == AC || AC == BC || AB == BC)
                return 2;
            if (AB == AC + BC || AC == BC + AB || BC == AC + AB)
                return 3;

            return 5;
        }

        public override string ToString()
        {
            return "A(" + _A.X + "," + _A.Y + ")     B(" + _B.X + "," + _B.Y + ")      C(" + _C.X + "," + _C.Y + ")";
        }

        static public bool operator ==(Triangle T1, Triangle T2)
        {
            double t1AB, t1AC, t1BC, t2AB, t2AC, t2BC;
            t1AB = T1._A.Distance(T1._B);
            t1AC = T1._A.Distance(T1._C);
            t1BC = T1._B.Distance(T1._C);
            t2AB = T2._A.Distance(T2._B);
            t2AC = T2._A.Distance(T2._C);
            t2BC = T2._B.Distance(T2._C);
            if (t1AB + t1AC + t1BC == t2AB + t2AC + t2BC)
                return true;
            return false;
        }

        static public bool operator != (Triangle T1, Triangle T2)
        {
            double t1AB, t1AC, t1BC, t2AB, t2AC, t2BC;
            t1AB = T1._A.Distance(T1._B);
            t1AC = T1._A.Distance(T1._C);
            t1BC = T1._B.Distance(T1._C);
            t2AB = T2._A.Distance(T2._B);
            t2AC = T2._A.Distance(T2._C);
            t2BC = T2._B.Distance(T2._C);
            if (t1AB + t1AC + t1BC != t2AB + t2AC + t2BC)
                return true;
            return false;
        }

        static public bool operator >(Triangle T1, Triangle T2)
        {
            double t1AB, t1AC, t1BC, t2AB, t2AC, t2BC;
            t1AB = T1._A.Distance(T1._B);
            t1AC = T1._A.Distance(T1._C);
            t1BC = T1._B.Distance(T1._C);
            t2AB = T2._A.Distance(T2._B);
            t2AC = T2._A.Distance(T2._C);
            t2BC = T2._B.Distance(T2._C);
            if (t1AB + t1AC + t1BC > t2AB + t2AC + t2BC)
                return true;
            return false;
        }

        static public bool operator <(Triangle T1, Triangle T2)
        {
            double t1AB, t1AC, t1BC, t2AB, t2AC, t2BC;
            t1AB = T1._A.Distance(T1._B);
            t1AC = T1._A.Distance(T1._C);
            t1BC = T1._B.Distance(T1._C);
            t2AB = T2._A.Distance(T2._B);
            t2AC = T2._A.Distance(T2._C);
            t2BC = T2._B.Distance(T2._C);
            if (t1AB + t1AC + t1BC < t2AB + t2AC + t2BC)
                return true;
            return false;
        }






    }
}