using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Partial1617ClientAccount
{
    class Account
    {
        private int number;
        private double balance;
        private Client owner;
        public static int nbOfAccounts = 0;
        // properties
        public int Number
        {
            get { return number; }
        }
        public double Balance
        {
            get { return balance; }
        }
        public Client Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        //constructor
        public Account(int number, Client owner)
        {
            this.number = number;
            this.owner = owner;
            balance = 0;
            nbOfAccounts++;
        }
        // credit and debit
        public void credit(double amount)
        {
            balance += amount;
        }
        public void debit(double amount)
        {
            if (balance >= amount)
                balance -= amount;
            else
                throw new Exception("Operation not allowed");
        }
        //display
        public void display()
        {
            Console.WriteLine("Account#: {0}\nBalance: {1},\nOwner: {2}", number, balance, owner);
        }
    }
}
