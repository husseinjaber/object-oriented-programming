using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Point
    {
        //attributes
        private int x, y;

        //Constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point A)
        {
            this.x = A.x;
            this.y = A.y;
        }

        public Point()
        {
            x = 0;
            y = 0;
        }
        //properties
        public int X
        {
            get { return x; }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
            }
        }

        //Methods

        public void Input()
        {
            Console.WriteLine("Enter the abscissa of point : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ordinate of point : ");
            y = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("(" + x + "," + y + ")");
        }

        public double Distance(Point p1)
        {
            return Math.Pow(x - p1.x, 2) + Math.Pow(y - p1.y, 2);
        }

        public void Translate(int a, int b)
        {
            x += a;
            y += b;
        }
    }
}
