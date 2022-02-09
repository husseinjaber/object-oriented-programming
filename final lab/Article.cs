
using System;

namespace final15_16
{
	
	public  abstract class  Article
	{  private int code;
		private string description;
		public Article( int code,string description)
		{
			this.code=code;
			this.description =description;
		}
		public int C
		{
			get {return code;}
			set {code =value;}
		}
		public string D
		{
			get {return description ;}
			set{description =value;}
		}
		public override string ToString()
		{
			return string.Format("[Article Code={0}, Description={1}]", code, description);
		}
		public void Display ()
		{
			Console.WriteLine ("Code is "+code +"Description is "+description );
		}
		public Article ()
		{
			
		}
		
		
	}
}
