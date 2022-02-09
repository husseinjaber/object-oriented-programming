/*
 * Created by SharpDevelop.
 * User: doc
 * Date: 06/11/2017
 * Time: 02:01 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tp5
{
	/// <summary>
	/// Description of square.
	/// </summary>
	public class square
	{
		 private int length;
		 private string character;
		
		 	
		 public square ( int length, string character)
			{
			this.length=length;
			this.character=character;}
		
			public int Lenght{
				get{return length;}
				set{length=value;}
			}
			public string Character{
				get{return character;}
				set{character=value;}
			}
			
			
			public int area()
			{ return (length*length);}
			
			public int perimeter()
			{ return (length*4);}
			
			public void display()
			{ for(int i=0;i<length;i++)
				{for(int j=0;j<length;j++)
						Console.Write(character);
				        Console.WriteLine();
				}}
			public void extend (int e)
			{length*=e;}
		}}
