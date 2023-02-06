using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class SavingsAccount : Account
    {
        public double interestRate { get; set; }
        public int savingPeriod { get; set; }
        public double calculateInterest()
        {
            return 1 * (interestRate + savingPeriod);
        }

        public override double makeDep()
        {
            throw new NotImplementedException();
        }

        //public override double makeWithdrawal()
        //{
        //    throw new NotImplementedException();
        //}

        public double DepositInput()
        {
            return Balance += MakeDeposit;
        }

        public override double makeWith()
        {
            return Balance -= MakeWithdrawal;
        }
        public override string ToString()
        {
            return "The account number is =" + AccountNumber + "The Balance is = " + Balance + "the saving period is = " + savingPeriod + "the deposit amount is = " + MakeDeposit + "The withdrawal amount is =" + MakeWithdrawal;
        }

        
    }
    
}
