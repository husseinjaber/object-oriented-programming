using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Square
    {
        //attributes
        private int length;
        private char character;

        //constructor
        public Square(int length, char character)
        {
            this.length = length;
            this.character = character;
        }

        //properties
        public int Length
        {
            get { return length; }
            set
            {
                if (value == 0 || value == null)
                {
                    throw new Exception("Invalid Length!");
                }
                else
                {
                    length = value;
                }
            }
        }

        public char Character
        {
            get { return character; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Invalid character!");
                }
                else
                {
                    character = value;
                }
            }
        }

        //Methods
        public int Area()
        {
            return length * length;
        }

        public int Perimeter()
        {
            return length * 4;
        }

        public void Display()
        {
            Console.WriteLine("This is the square :\n");
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }

        public void Extend(int n)
        {
            length = length * n;
        }
    }
}