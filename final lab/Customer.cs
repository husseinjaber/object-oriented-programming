
using System;

namespace final15_16
{
	
	public class Customer
	{
		private string lastname;
		private string firstname;
		private CD[] CDTab;
		public Customer(string lastname,string firstname)
		{this.lastname=lastname;
			this.firstname=firstname;
			CDTab=new CD[0];
		}
		public void AddCD(CD c)
		{
			if(CDTab.Length >2)
				Console.WriteLine ("Not valid");
			else {
				Array.Resize(ref CDTab,CDTab.Length+1);
					CDTab[CDTab.Length-1]=new CD (c);
			}
		}
		
		public void DisplayDVD()
		{
			for(int i=0;i<CDTab.Length ;i++)
				if(CDTab[i].Typecd==CD.type.DVD)
					CDTab[i].Display();
				
		}
		
	}
}
