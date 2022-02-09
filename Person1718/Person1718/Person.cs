using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person1718
{
    class Person
    {
        /* fields */
        private string name;
        private int age;
        // add a static filed nb of persons
        private static int nbP = 0;
        /* basic methods */
        /* constructors */
        // 1st constructor
        public Person(string name, int age)
        {
            this.name = name; this.age = age; nbP++;
            Console.WriteLine("1st constructor");
        }
        // 2nd constructor
        public Person(string name)
        {
            this.name = name; age = 0; nbP++;
            Console.WriteLine("2nd constructor");
        }
        // 3rd constructor
        public Person(int age)
        {
            this.age = age; nbP++;
            Console.WriteLine("3rd constructor");
        }
        /* getters and setters */
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            if (age > 0 && age < 120)
                this.age = age;
        }
        // add method get of nbP
        public static int getNbP()
        {
            //age++; //error because a static method cannot acces a non static field
            return nbP;
        }
        /* properties */
        // property for the field name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // property for the field age
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 120) age = value;
                else Console.WriteLine("invalide operation");
            }
        }
        // property nbP
        public static int NbP
        {
            get { return nbP; }
        }
        /* ToString */
       public override String ToString()
        {
            return "Name: " + name + " Age: " + age;
        }
        // additional method
        public void identity()
        {
            Console.WriteLine("I am a person");
        }
    }
}
