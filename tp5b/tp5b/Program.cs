/*
 * Created by SharpDevelop.
 * User: doc
 * Date: 06/11/2017
 * Time: 02:46 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tp5b
{
	class Program
	{
		public static void Main(string[] args)
		{    int d,a,b;
			point p=new point();
			point q=new point();
			p.input();
			p.display();
			q.input();
			q.display();
			d=p.distance();
			Console.WriteLine("distance is " + d);
			Console.WriteLine("enter a ");
			a=int.Parse(Console.ReadLine());
			Console.WriteLine("enter b ");
			b=int.Parse(Console.ReadLine());
			p.translate(a,b);
			p.display();
			Console.ReadKey();
		
			
			
			
			
			
		}
	}
}