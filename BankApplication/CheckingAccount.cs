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
    public class CheckingAccount : Account
    {

        private decimal fee;

        //constructor should receive the initial balance. Also parameter indicating a fee amount.

        public CheckingAccount(decimal balance, decimal fee) : base(balance)
        {
            Fee = fee;
        }

        public decimal Fee
        {
            get { return fee; }
            set
            {
                if (value > 0)
                    fee = value;
                else
                    throw new Exception("Fee cannot be less than zero");

            }

        }

        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= Fee;
        }

        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                Balance -= Fee;
                return true;
            }
            return false;
        }

    }
}
