using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class SuperMarket:ArrayList
    {
        public void ADDArticle(Article a)
        {
            this.Add(a);
        }

        //indexer
        public Article this[int i]
        {
            get { return (Article)base[i]; }
            set { base[i] = value; }
        }

        public void DiplayArticleBrand(string b)
        {
            for(int i=0;i<=this.Count-1;i++)
            {
                if (this[i]._brand == b) Console.WriteLine(this[i].ToString());
            }
        }
        public static SuperMarket operator +(SuperMarket s, Article f1)
        {
            s.ADDArticle(f1);
            return s;
        }

        public int CountArticleBrand(string b)
        {
            int sum=0;
            for (int i = 0; i <= this.Count - 1; i++)
            {
                if (this[i]._brand == b) sum++;
            }
            return sum;
        }

        public void DisplayArticleT(string s)
        {
            if (s == "healthy")
            {
                for (int i=0;i<=Count-1;i++)
                {
                    if (this[i]._Type == Article.Foodtype.healthy) Console.WriteLine(this[i].ToString());
                }
            }
            if (s == "unhealthy")
            {
                for (int i = 0; i <= Count - 1; i++)
                {
                    if (this[i]._Type == Article.Foodtype.unhealthy) Console.WriteLine(this[i].ToString());
                }
            }
            if (s == "normal")
            {
                for (int i = 0; i <= Count - 1; i++)
                {
                    if (this[i]._Type == Article.Foodtype.normal) Console.WriteLine(this[i].ToString());
                }
            }

        }
    }
}
