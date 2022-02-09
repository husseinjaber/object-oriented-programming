
using System;

namespace class_tp4
{
	class Program
	{
		public static void Main(string[] args)
		{
student P; //
student P1 = new student("name","Fname",19, 12,"GC"); // creation of an object
P=P1;
P.Displaystudent();
P1.Displaystudent();
try { // detection of exception
P. Fname="";
} catch (Exception ex) {
Console.WriteLine(ex.Message);
}
P1. Displaystudent ();
Console.WriteLine(P1.Fname);
Console.WriteLine("enter n");
int n=int.Parse(Console.ReadLine());
student [] s=new student[n];
string ln,fn,d;
int a,g;

for(int i=0;i<n;i++)
{   Console.WriteLine("enter first name");
	fn=Console.ReadLine();
	Console.WriteLine("enter last name");
	ln=Console.ReadLine();
	Console.WriteLine("enter department");
	d=Console.ReadLine();
	Console.WriteLine("enter age");
	a=int.Parse(Console.ReadLine());
	Console.WriteLine("enter grade");
	g=int.Parse(Console.ReadLine());
	s[i]=new student(fn,ln,a,g,d);
	
	
	
}
int sum=0;
for(int i=0;i<n;i++)
{  sum=sum+s[i].Grade;


}

 Console.WriteLine(" sum= " +sum+" ---->average="+ sum/s.Length);








Console.ReadKey();

			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
		}
	}
}