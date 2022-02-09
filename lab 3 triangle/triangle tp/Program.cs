
using System;

namespace tp0101
{
	class Program
	{
		public static void input(int []A)
		{
			for(int i=0;i<A.Length;i++)
			{
			Console.WriteLine("enter A["+i+"]");
			A[i]=int.Parse(Console.ReadLine());
			}
		}
		public static int distance1(int []a,int[]b)
		{
			
			
			int d=(a[0]-b[0])*(a[0]-b[0]) + (a[1]-b[1])*(a[1]-b[1]);
			if(d==0)
					throw new Exception("they should not be equale ");
			
			return d*d;
		}
		public static int triangle(int []A,int []B,int []C)
		{
			int ab,bc,ac;
			ab=distance1(A,B);
			bc=distance1(B,C);
			ac=distance1(A,C);
			if(ab==ac && bc==ac)
				return 1;
			if(ab==ac || ab==bc || bc==ac)
				return 2;
			if((ab==bc+ac) ||( bc==ab+ac) || (ac==ab+bc))
				return 3;
			if ( (ab==bc+ac) ||( bc==ab+ac) || (ac==ab+bc) && (ab==ac || ab==bc || bc==ac) )
				return 4;
			else
			return 5;
			
		}
		public static void Main(string[] args)
		{
			int tri;
			int []A=new int[2];
	
			int []B=new int[2];
	
			int []C=new int[2];
		
			
			input(A);
			input(B);
			input(C);
			tri=5;
			try{
			tri=triangle(A,B,C);
				}catch(Exception)
			{Console.WriteLine("exception");}
			
			if(tri==1)
				Console.WriteLine("equilateral ");
			
			if(tri==2)
				Console.WriteLine("isos");
			if(tri==3)
				Console.WriteLine("right tri ");
			if(tri==4)
				Console.WriteLine("right isos ");
			if(tri==5)
				Console.WriteLine("any triangle");

			Console.ReadKey(true);
		}
	}
}