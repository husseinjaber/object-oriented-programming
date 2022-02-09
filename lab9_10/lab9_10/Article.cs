
using System;

namespace lab9_10
{
	
	public class Article
	{ private string brand ;  
	   private float code ;
		private DateTime expirationDate;
		public enum foodtype{healthy,unhealthy,normal}
		foodtype f;
		public Article(string brand ,float code,DateTime expirationDate , foodtype f)
		{    
			this.brand=brand;
			this.code=code;
			this.expirationDate=expirationDate;
			this.f =f ;
		}
		public string Brand
		{
			get {return brand;}
			set {brand=value;}
		}
		public float Code
		{
			get {return code;}
			set {code=value;}
		}
		
	public DateTime Expirationdate
	{
		get { return expirationDate ;}
		set {expirationDate =value ;}
	}
	public foodtype F
	{
		get {return f ;}
		set {f=value ;}
	}
	public Article ()
	{
		
	}
	public override string ToString()
	{
		return "brand is "+brand+"Code is "+code+"ExpirationDate "+expirationDate +"FoodType"+f;
	}
	public void Display(){
		Console.WriteLine(this);
	}
	public static bool operator ==(Article A1,Article A2)
	{
		return (A1.Brand==A2.Brand)&&(A1.Code ==A2.Code);
            
	}
	public static bool operator !=(Article A1,Article A2)
	{
		return (A1.Brand!=A2.Brand)&&(A1.Code!=A2.Code);
        
	}
	
}
}
	
