
using System;

namespace tp5b
{
	
	public class point
{
		private int x;
		private int y;
		
		public point(int x, int y)		{
			this.x=x;
			this.y=y;
		}
		
	
		
		public int X{
			get{return x;}
			set{x=value;}}
		public int Y{
			get{return y;}
			set{y=value;}}
		public void input ()
		{
			Console.WriteLine("enter x");
			 x=int.Parse(Console.ReadLine());
			 Console.WriteLine("enter y");
			 y=int.Parse(Console.ReadLine());
	}
		
		public void display()
		{Console.WriteLine("X:" +x +"y : " + y);} 
		
		public void translate (int a, int b)
		{   x+=a;
			y+=b;}
		
		public int distance (point p)
		{ return ( (x-p.x)*(x-p.x) + (y-p.y)*(y-p.y) ) ;}
		
		
		
}
}
