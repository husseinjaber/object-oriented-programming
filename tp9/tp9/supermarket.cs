using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace lab9_10
{
    class supermarket:ArrayList
    {
        public void AddArticle(article a1 )
        {
            this.Add(a1);
        }
        public new article this[int i]
        {
            get { return (article) base[i]; }
           
        }
         public void displayArticleBrand(string b)
        {
             for(int i=0;i<this.Count;i++)
             {
                 if(this[i].Brand==b)
                 {
                     Console.WriteLine(this[i]);

                 }
             }
         }
         public void displayFood(Typefood b)
        {
             for(int i=0;i<this.Count;i++)
             {
                 if(this[i].Type==b)
                 {
                     Console.WriteLine(this[i]);

                 }
             }
            
        }
         public static int operator +(supermarket a1, food a2)
         {
             return a1.Add(a2);
         }
    }
}
