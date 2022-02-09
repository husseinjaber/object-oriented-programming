using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class listEmployee:ArrayList
    {
        public void AddEmployee(Employee e)
        {
            this.Add(e);
        }
        
        public void DisplayEmployee()
        {
            for(int i=0;i<this.Count-1;i++)
            {
                Console.WriteLine(this[i].ToString());
            }
        }

        public void DisplayInstructor()
        {
            for (int i = 0; i < this.Count - 1; i++)
            {
                if (this[i] is Instructor) Console.WriteLine(this[i].ToString());
            }
        }
    }
}
