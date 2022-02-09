using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    abstract class Employee
    {
        string Lname;
        static int NbEmployee = 0;
        public static int nbEmployee
            {
            get { return NbEmployee; }
            }

        public string lname
        {
            get
            { return Lname; }
            set { Lname = value; }
        }

        string Fname;
        public string fname
        {
            get { return Fname; }
            set { Fname = value; }
        }

        public int ddn
        {
            get { return DDN; }
            set { DDN = value; }
        }
        int DDN;
        //public Employee() { }
        public Employee(string Lname,string Fname, int DDN)
        {
            this.Lname = Lname;
            this.Fname = Fname;
            this.DDN = DDN;
            NbEmployee++;
        }
        public abstract void Display();
        public override string ToString()
        {
            return string.Format("Last Name: {0}\nFirst Name: {1}\nDDN: {2}", Lname, Fname, DDN);
        }
    }
}
