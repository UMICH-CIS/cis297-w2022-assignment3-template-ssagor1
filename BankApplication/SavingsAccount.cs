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
    public class SavingsAccount : Account
    {
        private decimal interestRate;

        public SavingsAccount(decimal balance, decimal interestRate) : base(balance)
        {
            InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value > 0)
                    interestRate = value;
                else
                    throw new Exception("Interest rate must be greater than zero");
            }
        }

        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }

    }
}
