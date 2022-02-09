using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5_ex2
{
    class ColorPoint:Point
    {
        private string Color;

        public ColorPoint(int X, int Y, string color)
            : base(X, Y)
        {
            this.Color = color;
        }

        public ColorPoint(Point P, string color)
            : base(P)
        {
            this.Color = color;
        }

        public new void Display()
        {
            Console.WriteLine("X=" + X + "\tY=" + Y + "\tColor: " + Color);
        }
        public void SetColor(int c)
        {
            switch (c)
            {
                case 1: Color = "red"; break;
                case 2: Color = "blue"; break;
                case 3: Color = "green"; break;
                case 4: Color = "yellow"; break;
                default: Color = "black"; break;
            }
        }




         

       
    }
}
