using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_9_10
{
    class Drink:Article
    {
        private int _volume;

        public Drink(string b, float c, DateTime e, FoodType t, int v)
            : base(b, c, e, t)
        {
            _volume = v;
        }
        public int Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\tVolume:" + _volume; 
        }

        public new void Display()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
