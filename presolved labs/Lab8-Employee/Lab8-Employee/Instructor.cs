using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8_Employee
{
    class Instructor:Employee
    {
        private int _course1;
        private int _course2;
        private string _Dep;

        public Instructor(string f, string l, DateTime d, int c1, int c2, string dep)
            : base(f, l, d)
        {
            this._course1 = c1;
            this._course2 = c2;
            this._Dep = dep;
        }
        public int Course1
        {
            get { return _course1; }
            set { _course1 = value; }
        }
        public int Course2
        {
            get { return _course2; }
            set { _course2 = value; }
        }
        public string dep
        {
            get { return _Dep; }
            set { _Dep = value; }
        }
        public override string ToString()
        {
            return base.ToString() + " Course1:" + _course1 + " Course2:" + _course2 + " Department:" + _Dep;
        }
        public new void Display()
        {
            Console.WriteLine(this.ToString());
        }







    }
}
