/*
 * Created by SharpDevelop.
 * User: doc
 * Date: 16/10/2017
 * Time: 02:03 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace lab_2
{
	class Program
	{
		public static void Main(string[] args)
		{   Car C= new Car("bmw","black",12,1300);
			
			Console.WriteLine("enter mark");
			C.Mark=Console.ReadLine();
			Console.WriteLine("enter color");
			C.Color=Console.ReadLine();
			Console.WriteLine("enter number");
			C.Number=int.Parse(Console.ReadLine());
			Console.WriteLine("enter km");
			C.TraveledKM=int.Parse(Console.ReadLine());
			Console.WriteLine(C);
			Console.ReadKey();
			
			
			
			
			
			
			
		}
	}
}