
using System;

namespace lab9_10
{
	
	public class Food:Article 
	{    private int weight ;
		public Food()
		{
		}
		public int g
		{
			get {return weight ;}
			set {weight =value;}
		}
		public Food (string brand ,float code,DateTime expirationDate ,foodtype f,int weight):base (brand ,code ,expirationDate,f )
		{try{
				if(weight <0)
				{
					throw new Exception("weight negative");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine (e);
				weight=-weight ;
			}
			this.weight =weight ;
			}
			
		public override string ToString()
	{
		return "brand is "+Brand+"Code is "+Code+"ExpirationDate "+Expirationdate+"FoodType"+F +"weight"+weight;
	
	}
		public new void Display(){
		Console.WriteLine(this);
	}
	}
}