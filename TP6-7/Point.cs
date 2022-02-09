using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    class Point
    {
        double x;
        double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        


        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point (double x, double y)
        {
            this.x = x;
            this.y = y;
        } 
        public Point()
        {

        }

        public void Input (double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Display ()
        {
            Console.WriteLine("The X coordinate is: {0}\nThe Y coordinate is: {1}", x, y);
        }

        public void translate(double translationX, double translationY)
        {
            x += translationX;
            y += translationY;
        }

        public double Distance(Point Point2)
        {
            return Math.Pow(Point2.X - x, 2) + Math.Pow(Point2.Y - y, 2);
        }
    }
}
