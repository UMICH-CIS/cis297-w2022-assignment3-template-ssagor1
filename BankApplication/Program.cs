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
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalCredit = 0.0M;
            SavingsAccount sa = new SavingsAccount(2000.25M, 0.1M);
            Console.WriteLine("Beginning balance is{0:C}", sa.Balance);
            totalCredit = sa.CalculateInterest();
            Console.WriteLine("Total interest: {0:C}", totalCredit);
            sa.Credit(totalCredit); //add credit to the balance
            Console.WriteLine("Ending balance is: {0:C}", sa.Balance);
            Console.WriteLine();

            //checking account has a fee for every transaction
            CheckingAccount ca = new CheckingAccount(2000.25M, 3.50M);
            Console.WriteLine("Beginning balance is {0:C}", ca.Balance);
            ca.Credit(55.25M); //this adds to the account (-fee)
            ca.Debit(1000.55M); //taken from the account (-fee)
            Console.WriteLine("Ending balance is {0:C}", ca.Balance);
            Console.ReadLine();
        }
    }
}

