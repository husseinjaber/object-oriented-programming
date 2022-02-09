using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonTeacherApplication
{
    class Person
    {
        private string name, address;
        private int age;
        public Person(string name, int age, string address)
        {
            this.name = name; this.age = age; this.address = address;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 100)
                    age = value;
            }
        }
            public string Address
        {
            get { return address; }
            set { address = value; }
        }
        //Name (Age)-(Address).
            public string identity()
            {
                return name + "(" + age + ")-(" + address + ").";
            }
    }
}
