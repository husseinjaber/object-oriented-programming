/*
 * Created by SharpDevelop.
 * User: doc
 * Date: 22/11/2017
 * Time: 11:19 ص
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace insert_into_array
{
	

   class Program
{   
static int [] T={2,11,4,5,21,6,17,1};
static int sum(int i)
{
if (i==0)
return T[0];
else
return T[i] + sum(i-1);
}
public static void Main()
{
	Console.WriteLine(sum(4)); Console.ReadKey();
}}
}
