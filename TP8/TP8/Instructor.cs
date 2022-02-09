using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class Instructor:Employee
    {
        string department;
        string code_course_1;
        string code_course_2;

        public Instructor(string Lname,string Fname,int DDN,string department,string code_course_1,string code_course_2):base(Lname,Fname,DDN)
        {
            this.department = department;
            this.code_course_1 = code_course_1;
            this.code_course_2 = code_course_2;
        }
        public override void Display()
        {
            Console.Write("{0}\n{1}\n{2}", lname, fname, ddn);
            Console.WriteLine("\n{0}\n{1}\n{2}", department, code_course_1, code_course_2);
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", lname, fname, ddn,department,code_course_1,code_course_2);
        }
        #region Properties
        public string Department
        {
            get
            {
                return department;
            }

            set
            {
                department = value;
            }
        }

        public string Code_course_1
        {
            get
            {
                return code_course_1;
            }

            set
            {
                code_course_1 = value;
            }
        }

        public string Code_course_2
        {
            get
            {
                return code_course_2;
            }

            set
            {
                code_course_2 = value;
            }
        }
        #endregion

    }
}
