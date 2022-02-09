using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_5
{
    class Square
    {
        private int _L;
        private char _C;

        public int L{
            get{ return _L;}
            set
            {
                if (value >= 0 )
                    _L = value;
            }
        }

        public char C
        {
            get { return _C; }
            set
            {
             
                    _C = value;
            }
        }

        public Square(int l, char c)
        {
            this._L = l;
            this._C = c;
        }

        public int Area()
        {
            return _L * _L;
        }

        public int perimeter()
        {
            return _L * 4;
        }

        public void Display()
        {
           
            for (int i = 0; i < _L; i++)
            {
                for (int j = 0; j < _L; j++)
                {
                    Console.Write(_C);
                }
                Console.WriteLine();
            }
        }

        public void Extend(int n)
        {

            _L = n * _L;
            Display();

            
        }




          
    }
}
