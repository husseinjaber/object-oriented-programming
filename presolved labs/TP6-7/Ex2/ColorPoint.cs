using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class ColorPoint:Point
    {
        //attributes
        private string color;

        //Constructors
        public ColorPoint(int a, int b, string color):base(a,b)
        {
            this.color = color;
        }

        public ColorPoint(Point a, string color):base(a)
        {
            this.color = color;
        }

        //properties
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //methods
        public override void Display()
        {
            Console.WriteLine("(" + x + "," + y + ")\t" + color);
        }

        public void SetColor(int c)
        {
            switch (c)
            {
                case 1: color = "red"; break;
                case 2: color = "blue"; break;
                case 3: color = "brown"; break;
                default: color = "black"; break;
            }
        }
    }
}
