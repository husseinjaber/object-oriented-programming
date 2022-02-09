
using System;

namespace final15_16
{
	
	public class CD:Article
	{    private  int storageSpace ;
		public  enum type {DVD,MP3,blueray};
		private type typecd;
		public CD()
		{
		}
		public CD(int code,string description,int storageSpace, type typecd):base(code,description )
		{
			this.storageSpace =storageSpace ;
			this.typecd=typecd;
		}
		public CD (CD c):base(c.C,c.D)
		{
			storageSpace=c.storageSpace;
			typecd=c.typecd;
			
		}
		public int S
		{
			get {return storageSpace ;}
		
			set{storageSpace =value;}
		}
		public  type Typecd 
		{
			get {return typecd ;}
			set {typecd =value;}
		}
		
		public override string ToString()
		{
			return string.Format("[CD StorageSpace={0}, Typecd={1}]", storageSpace, typecd)+base.ToString();
		}

		public new void Display ()
		{
			Console .WriteLine ("StorageSpace ="+storageSpace +"Typecd "+ typecd +"Code is "+C +"Description is "+D);
		}
		public void Input ()
		{
		    string  t;
			Console.WriteLine ("code is =");
			C=int.Parse (Console.ReadLine ());
			Console.WriteLine ("description is ");
			D=Console.ReadLine ();
			Console.WriteLine ("Type:DVD,MP3,Blueray");
			t=Console.ReadLine();
			
			if(t=="DVD")
				typecd=CD.type.DVD;
			if(t=="MP3")
				typecd=CD.type.MP3;
			if(t=="Blueray")
				typecd=CD.type.blueray;
	
			Console.WriteLine ("StorageSpace is ");
			storageSpace=int.Parse (Console.ReadLine());
				
		}
		
	}
}
