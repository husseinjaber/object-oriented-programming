using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Lab8_Employee
{
    class ListEmployee:ArrayList
    {
        public void AddEmployee(Employee E)
        {
            this.Add(E);
        }
        public void DisplayEmployee()
        {
            for (int i = 0; i < this.Count - 1; i++)
                Console.WriteLine(this[i]);
        }
        public void DisplayInstructor()
        {
            for (int i = 0; i < this.Count - 1; i++)
                if (this[i] is Instructor)
                    Console.WriteLine(this[i]);

        }



    }
}
