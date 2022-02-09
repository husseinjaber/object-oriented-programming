using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonTeacherApplication
{
    class Teacher
    {
        private Person p;
        private int salary;
        public Teacher(Person p, int salary)
        {
            this.p = p; this.salary = salary;
        }
        public Person P
        {
            get { return p; }
            set { p = value; }
        }
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
            }
        }
        public string identity()
        {
            return p.Name + "(" + p.Address + ")-(" + salary + ").";
        }
    }
}
