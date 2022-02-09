using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class Administrative_personnel:Employee
    {
        //attribute
        private string function;

        //constructor
        public Administrative_personnel(string fname, string lname, DateTime dob, string function): base(fname, lname, dob)
        {
            this.function = function;
            nbEmployee += 1;
        }

        //properties
        public string Function
        {
            get { return function; }
            set { function = value; }
        }

        //methods
        public override string ToString()
        {
            return ("(" + fname + ";" + lname + ";" + dob + ";" + function + ")");
        }
        public void Display()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
