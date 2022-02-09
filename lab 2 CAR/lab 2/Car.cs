using System;

namespace lab_2
{
	
	public class Car
	{ private string mark,color;
	  private float traveledKM;
      private int number;	  
      private static int nb=0;
		
		
		
			public Car(string mark,string color,int number, float traveledKM)
			{  
			 this.mark=mark;
			 this.color=color;
			 this.traveledKM=traveledKM;
			 this.number=number;
			 nb++;
			 Console.WriteLine("car nb " + nb);}
		public string Mark
		{ get{return mark;}
			set{mark=value;}}
		
		public string Color
		{ get{return color;}
			set{color=value;}}
		
		public int Number
		{ get{return number;}
			set{if (number>0)
				number=value;}}
			
		public float TraveledKM
		{ get{return traveledKM;}
			set{if (traveledKM>0)
				traveledKM=value;}}
		
		
		public override string ToString()
		{
			return string.Format("[Car Mark={0}, Color={1}, TraveledKM={2}, Number={3}]", mark, color, traveledKM, number);
		}

		
		public void consumed	(float fuel)
		{    
		
			traveledKM +=fuel*11;
		}
			
			
			
			
		}
	}


