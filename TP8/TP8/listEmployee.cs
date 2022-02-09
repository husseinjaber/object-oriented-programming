using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class listEmployee:ArrayList
    {

        public void AddEmployee(Employee E)
        {
            Add(E);
        }
        
        public void DisplayEmployee()
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i] is Employee)
                    Console.WriteLine(this[i].ToString());
            }
        }

        public static listEmployee operator* (listEmployee L , Employee E)
        {
            L.AddEmployee(E);
            return L;
        }
        public void DisplayInstructor()
        {
            for (int i= 0;i<this.Count;i++)
            {
                if (this[i] is Instructor)
                   
                    Console.WriteLine(this[i].ToString());
            }
        }


    }
}
