
using System;

namespace lab6
{
	
	public class Triangle
	{
	    private Point A;
	   private Point B;
	   private Point C;
	    
        public Triangle(Point A,Point B,Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public Triangle(double x1,double y1,double x2,double y2,double x3,double y3)
        {
            A = new Point(x1, y1);
            B = new Point(x2, y2);
            C = new Point(x3, y3);
        }

        public Triangle (Triangle triangle)
        {
            A = triangle.A;
            B = triangle.B;
            C = triangle.C;
        }
      
        public void input()
        {
            double x, y;

            Console.WriteLine("abscissa: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ordinate: ");
            y = double.Parse(Console.ReadLine());
            A.Input(x, y);

            Console.WriteLine("abscissa: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ordinate: ");
            y = double.Parse(Console.ReadLine());
            B.Input(x, y);

            Console.WriteLine("abscissa: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ordinate: ");
            y = double.Parse(Console.ReadLine());
            C.Input(x, y);

        }


        public void display()
        {
            A.Display();
            B.Display();
            C.Display();
        }

        public void translate(double tx,double ty)
        {
          
            A.translate(tx, ty);
            B.translate(tx, ty);
            C.translate(tx, ty);
        }

       public int TriangleType()
        {
            double AB = A.distance(B);
            double BC = B.distance(C);
            double AC = A.distance(C);

            if (AB == AC && AB == BC) 
                return 1;
            if ((AB == AC + BC) || (AC == AB + BC) || (BC == AB + AC)) 
                if ((AB == AC) || (AC == BC) || (BC == AB))
                    return 4; 
                else return 3; 

            if ((AB == AC) || (AC == BC) || (BC == AB)) 
                return 2;

            return 5; 
        }

        public double perimeter()
        {
            double AB = A.Distance(B);
            double BC = B.Distance(C);
            double AC = A.Distance(C);
            return AB + BC + AC;
        }

        public override string ToString()
        {
            return string.Format("Point1: ({0},{1})\nPoint1: ({2},{3})\nPoint1: ({4},{5})",A.X,A.Y,B.X,B.Y,C.X,C.Y);
        }
       public static bool operator == (Triangle t1, Triangle t2)
        {
            if (t1.perimeter() == t2.perimeter())
                return true;
            else return false;
        }
        public static bool operator !=(Triangle t1, Triangle t2)
        {
            if (t1.perimeter() != t2.perimeter())
                return true;
            else return false;
        }

        public static bool operator >(Triangle t1, Triangle t2)
        {
            if (t1.perimeter() > t2.perimeter())
                return true;
            else return false;
        }
        public static bool operator <(Triangle t1, Triangle t2)
        {
            if (t1.perimeter() < t2.perimeter())
                return true;
            else return false;
        }

    }
}
    	
		
		
		
	


      