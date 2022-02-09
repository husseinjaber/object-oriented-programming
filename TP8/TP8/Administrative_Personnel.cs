using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class Administrative_Personnel:Employee
    {
        string function;

        public string Function
        {
            get
            {
                return function;
            }

            set
            {
                function = value;
            }
        }

        public Administrative_Personnel(string Lname,string Fname,int DDN,string function):base(Lname,Fname,DDN)
        {
            this.function = function;
        }

        public override void Display()
        {
            
            Console.WriteLine("{0} {1}", function,base.ToString());
         }

        public override string ToString()
        {
            return string.Format("Last Name: {0}\nFirst Name: {1}\nDDN: {2}\n{3}", lname, fname, ddn, function);
        }

    }
}
