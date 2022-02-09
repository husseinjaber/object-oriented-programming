/*
 * Created by SharpDevelop.
 * User: doc
 * Date: 06/11/2017
 * Time: 02:00 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tp5
{
	class Program
	{
		public static void Main(string[] args)
		{  int l,p,a,ee;
		   string c	;
		   	
			Console.WriteLine("enter length");
			l=int.Parse(Console.ReadLine());
			Console.WriteLine("enter character");
			c=Console.ReadLine();
			square s=new square(l,c);
			s.display();
			p=s.perimeter();
			Console.WriteLine(p);
			a=s.area();
			Console.WriteLine(a);
			Console.WriteLine("enter extend ");
			ee=int.Parse(Console.ReadLine());
			s.extend(ee);
			s.display();
			Console.ReadKey();
			
			
			
			
			
		}
	}
}