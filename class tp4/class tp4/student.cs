
using System;

namespace class_tp4
{
	
	public class student
	{
	
   private static long nbStudents;
   private string _Fname;
   private string _Lname;
   private int _age;
   private int _grade;
  private string _dep;

public student(string _fname, string _lname, int age, int grade, string dep){
this._Fname= _Fname;
this._Lname= _Lname;
this._age= age;
this._grade= grade;
this._dep=dep;
nbStudents++;
}

public void Displaystudent() {
Console.WriteLine("[{0} \t {1} \t {2} \t {3} \t {4}]", _Fname, _Lname, _age, _grade, _dep);
}

public string Fname {
get { return _Fname; }
set {
if (value == null || value.Trim().Length == 0)
{
throw new Exception("First name (" + value + ") is not correct");
}
else
{
_Fname = value;
}
}		
  }
		

public string Lname {
get { return _Lname; }
set {
if (value == null || value.Trim().Length == 0)
{
throw new Exception("last  name (" + value + ") is not correct");
}
		
else
{
_Lname = value;
}
}		
  }  
  
  public int Age{
  	
			get{return _age;}
			set{
				if(value<0)
					{throw new Exception("age(" + value + ") is not correct");}
				else{ _age=value;}
  	
  }
  }
  
  public int Grade{
  	
			get{return _grade;}
			set{
				if(value<0)
					{throw new Exception("grade (" + value + ") is not correct");}
				else{ _grade=value;}
  	
  }
  }
  public string Dep{
  	get{return _dep;}
  	set{_dep=value;   }
  	
  }
  }
  
  
  
  
  
  
  
  
	}
  
  
  
