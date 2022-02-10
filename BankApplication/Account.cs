/// <summary>
/// This program implements an inheritance hierarchy that a bank might use to represent customers' bank accounts
/// </summary>
/// <Student> Shahriar Sagor </Student>
/// <Class>CIS297</Class>
/// <Semester> Winter 2022 </Semester>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Account
    {
        //One private instance variable of type decimal to represent the account balance
        private decimal balance;

        //constructor that receives and initial balance and uses it to initialize the instance variable with public property
        public Account(decimal balance)
        {
            Balance = balance;
        }

        //The property should validate the initial balance
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    throw new Exception("Balance cannot be negative");
                }
            }
        }
        // Method credit should add an amount to the current balance.
        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                throw new Exception("Credited amount must be greater than zero");
            }
        }

        public virtual bool Debit(decimal amount)
        {
            bool OK = true;
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                OK = true;
            }
            else
            {
                Console.Write("debit amount exceeded account balance.");
                OK = false;

            }
            return OK;
        }
    }
}
