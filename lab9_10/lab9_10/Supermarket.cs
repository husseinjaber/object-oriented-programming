
using System;
using System.Collections;
namespace lab9_10
{

	public class Supermarket:ArrayList 
	{   
        public void ADDArticle(Article a)
        {
            this.Add(a);
        }
        public void DisplayArticleBrand(string b)
        {
            foreach (Article A in this)
                if (A.Brand == b)
                    A.Display();
        }
        public void DisplayFood (Article.foodtype kk)
        {
        	foreach(Article Fo in this)
        		if(Fo.F==kk&&Fo is Food)
        			Console.WriteLine(Fo);
        }
       /* public Article this[int i]
       {
        	get {return (Article)base[i];}
        	set {base[i]=value;}*/ /*hyde bst3mla eza 3mlt for loop }*/
	
         public static Supermarket operator +(Supermarket s, Article a)
        {
            s.ADDArticle(a);
            return s;
        }	
	
	}
}
