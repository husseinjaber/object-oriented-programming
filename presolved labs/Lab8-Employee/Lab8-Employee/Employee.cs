using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8_Employee
{
    abstract class Employee
    {
        protected string _Fname;
        protected string _Lname;
        protected DateTime _Dob;

        public Employee(string f, string l, DateTime d)
        {
            this._Fname = f;
            this._Lname = l;
            this._Dob = d;
        }

        public string Fname
        {
            get { return _Fname; }
            set { _Fname = value; }
        }
        public string Lname
        {
            get { return _Fname; }
            set { _Lname = value; }
        }
        public DateTime Dob
        {
            get { return _Dob; }
            set { _Dob = value; }
        }


        public override string ToString()
        {
            return "FirstName:" + _Fname + " LastName:" + _Lname + " Date of Birth:" + _Dob;
        }
        public void Display()
        {
            Console.WriteLine(this.ToString());
        }





    }
}
