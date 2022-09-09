using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo4
{
    internal class Account
    {
        private int id;
        private double balance, annualInterestRate;
        private DateTime dateCreated;

        public Account()
        {
            id = 0;
            balance = 0;
            annualInterestRate = 0;
            dateCreated = DateTime.Now;
        }

        public Account(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
            annualInterestRate= 0;
            dateCreated = DateTime.Now;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance { get { return balance; } set { balance = value; } }
        public double AnnualInterestRate { get { return annualInterestRate; } set { annualInterestRate = value; } }

        public DateTime DateCreated
        {
            get { return dateCreated; }
        }

        public double getMonthlyInterestRate()
        {
            return AnnualInterestRate / 12;
        }

        public void deposit(double money)
        {
            Balance = Balance - money;
        }

        public void withdraw(double money)
        {
            Balance = Balance + money;
        }

    }
}
