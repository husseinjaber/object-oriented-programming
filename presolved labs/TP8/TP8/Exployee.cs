using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    abstract class Employee
    {
        //attribute
        protected string lname, fname;
        protected DateTime dob;
        protected int nbEmployee=0;

        //constructors
        public Employee(string fname, string lname, DateTime dob)
        {
            this.lname = lname;
            this.fname = fname;
            this.dob = dob;
            nbEmployee += 1;
        }

        //properties
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public int NbEmployee
        {
            get{return nbEmployee;}
        }

        //methods
        public override string ToString()
        {
            return ("(" + fname + ";" + lname + ";" + dob + ")");
        }
        public void Diplay()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
