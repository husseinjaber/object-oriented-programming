using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_9_10
{
    class Food:Article
    {
        private int _weight;
        public Food(string b, float c, DateTime e, FoodType t, int w)
            : base(b, c, e, t)
        {
            _weight = w;
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public override string ToString()
        {
            return base.ToString() + "\tWeight:" + _weight;
        }

        public new void Display()
        {
            Console.WriteLine(this.ToString());
        }


    }
}
