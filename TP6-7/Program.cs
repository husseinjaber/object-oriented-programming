using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using TP5; //class point is defined in this namespace
namespace TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point P1, P2, P3;
             P1 = new TP5.Point(4, -1);
             P2 = new Point(5, 6);
             P3 = new TP5.Point(1,3);
             Triangle mytriangle = new Triangle(P1, P2, P3);
             Triangle mytriangle2 = new Triangle(P1, P2, P3); //triangle with same coordinates for comparison
             mytriangle.display();
             Console.WriteLine(mytriangle.ToString());
             mytriangle.translate(4,8);
             mytriangle.display();
             Console.WriteLine(mytriangle == mytriangle2); //comparing the two triangles
             Console.ReadKey();
            
        }
       
    }
}
