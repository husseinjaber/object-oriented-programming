using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Lab_9_10
{
    class Supermarket:ArrayList
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
        public Article this[int i]
        {
            get { return this[i]; }
        }
        public override void operator +(Supermarket s, Article a)
        {
            s.ADDArticle(a);
        }
    }
}
