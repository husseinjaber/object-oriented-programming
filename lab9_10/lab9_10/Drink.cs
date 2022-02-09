
using System;

namespace lab9_10
{
	
	public class Drink:Article 
	{   private int volume;
		
		public Drink(string brand ,float code,DateTime expirationDate , foodtype f,int L):base(brand,code,expirationDate ,f )
		{ 
			L=volume;
		}
		public int Volume 
		{
			get {return volume;}
			set {volume =value;}
		}
		public override string ToString()
	{
		return "brand is "+Brand+"Code is "+Code+"ExpirationDate "+Expirationdate +"FoodType"+F +"volume "+volume ;
	}
		public new void Display(){
		Console.WriteLine(this);
	}
		public Drink ()
		{
		}
	}
}
