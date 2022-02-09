using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class Instructor:Employee
    {
        //attribute
        private string dep, course1, course2;

        //constructor
        public Instructor(string fname,string lname,DateTime dob,string course1,string course2,string dep):base(fname,lname,dob)
        {
            this.course1 = course1;
            this.course2 = course2;
            this.dep = dep;
            nbEmployee += 1;
        }

        //properties
        public string Course1
        {
            get { return course1; }
            set { course1 = value; }
        }
        public string Course2
        {
            get { return course2; }
            set { course2 = value; }
        }
        public string Dep
        {
            get { return dep; }
            set { dep = value; }
        }

        //methods
        public override string ToString()
        {
            return ("(" + fname + ";" + lname + ";" + dob + ";" + course1 + ";" + course2 + ";" + dep + ")");
        }
        public void Display()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
