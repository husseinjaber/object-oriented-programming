
using System;

namespace lab9_10
{
	class Program
	{
		static public void Display (Article A)
			{
				Console.WriteLine (A.ToString() );
			}
		public static void Main(string[] args)
		{
			Food F1,F2;
			Drink D1,D2;
			string brand;
			F1=new Food("Sugs",12,new DateTime(2017,12,6),Article.foodtype.healthy,-88);
			F2=new Food ();
			D1=new Drink ("cce",12,new DateTime(2017,12,6),Article.foodtype.healthy,88);
			D2=new Drink ();
			
			Supermarket S=new Supermarket ();
				S.ADDArticle(F1);
			S.ADDArticle(F2);
			S.ADDArticle(D1);
			S.ADDArticle(D2);
			Console.WriteLine ("enter brand is = ");
			brand=Console.ReadLine();
			S.DisplayArticleBrand(brand);
			//S.DisplayFood(Article .foodtype .healthy );
			//Display(F1);
			//Display (D1);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}