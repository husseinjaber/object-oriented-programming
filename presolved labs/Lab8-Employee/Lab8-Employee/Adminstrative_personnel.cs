using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8_Employee
{
    class Adminstrative_personnel:Employee
    {
        private string _function;

        public Adminstrative_personnel(string f, string l, DateTime d, string fun)
            : base(f, l, d)
        {
            _function = fun;
        }

        public string Function
        {
            get { return _function; }
            set { _function = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " Function:" + _function;
        }
        public new void Display()
        {
            Console.WriteLine(this.ToString());
        }


    }
}
