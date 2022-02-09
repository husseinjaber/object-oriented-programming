using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_ex2
{
    class Point
    {
        private int _X;
        private int _Y;

        public int X
        {
            get
            {
                return _X;
            }
            set
            {
                if (value != null)
                    _X = value;
            }
        }
        public int Y
        {
            get { return _Y; }
            set
            {
                if (value != null)
                    _Y = value;
            }
        }
        public Point(int x,int y)
        {
        this._X=x;
        this._Y=y;
        }

        public Point()
        { _Y = 0; _X = 0; }

        public Point(Point p)
        {
            _X=p.X;
            _Y = p.Y;
        }

        public void Input()
        {
            Console.WriteLine("Enter X");
            
            _X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y");

            _Y = int.Parse(Console.ReadLine()); 
        }
        public void Display()
        {
            Console.WriteLine("X=" + _X + "\tY=" + _Y);
        }
        public double Distance(Point p)
        {
            if (_X == p.X && _Y == p.Y)
                throw new Exception("Same Point");
            return (Math.Pow(_X - p.X, 2) + Math.Pow(_Y - p.Y, 2));
        }

        public void Translate(int a, int b)
        {
            _X = _X + a;
            _Y = _Y + b;
        }





    }
}
