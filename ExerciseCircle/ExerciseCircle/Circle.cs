using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseCircle
{
    class Circle
    {
        private float x, y, r;
        //constructor
        public Circle(float x, float y, float r)
        {
            this.x = x; this.y = y;
            if (r > 0)
                this.r = r;
        }
        //properties
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public float R
        {
            get { return r; }
            set
            {
                if (value > 0)
                    r = value;
            }
        }
        public override string ToString()
        {
            return "Center : (" + x + "," + y + ") \nRadius : " + r + "\n";
        }
        public double perimeter()
        {
            return 2 * r * Math.PI;
        }
        public double area()
        {
            return r * r * Math.PI;
        }
    }

}
