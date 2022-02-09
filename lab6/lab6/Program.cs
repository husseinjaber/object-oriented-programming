using System;

namespace tp5b
{
	class Program
	{
		public static void Main(string[] args)
		{  {
            Point P1, P2, P3;
             P1 = new TP6.Point(1, -1);
             P2 = new Point(2, 1);
             P3 = new TP6.Point(5,0);
             Triangle tri = new Triangle(P1, P2, P3);
             Triangle tri2 = new Triangle(P1, P2, P3); 
             tri.display();
             Console.WriteLine(tri.ToString());
             tri.translate(4,1);
             tri.display();
             Console.WriteLine(tri == tri2); 
             Console.ReadKey();
            
        }
       
    }
}
}