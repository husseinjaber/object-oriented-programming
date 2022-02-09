using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Partial1617ClientAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Fouad", "Saida");
            Account account1 = new Account(367, client1);
            account1.credit(500);
            account1.debit(200);
            account1.display();
            Console.WriteLine(Account.nbOfAccounts);
            //some additional actions
            // change the name of the owner of account1
            account1.Owner.Name = "Sami";
            //try to withdraw 400
            try
            {
                account1.debit(400);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Execution continues...");
            // add new account
            Account A = new Account(389, new Client("Jad", "Beirut"));
            A.display();
            
            // meaning of ==
            Client C, D, E;
            C = new Client("Fadi", "Saida");
            D = new Client("Fadi", "Saida");
            E = C;
            if (C == D)
                Console.WriteLine("OK");
            else
                Console.WriteLine("not OK");// not OK

            if (C == E)
                Console.WriteLine("OK");//OK
            else
                Console.WriteLine("not OK");

            Console.ReadKey();
        }
    }
}
