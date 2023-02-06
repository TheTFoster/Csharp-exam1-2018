using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public abstract class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public double MakeDeposit { get; set; }
        public double MakeWithdrawal { get; set; }

        public abstract double makeDep();
        public abstract double makeWith();



    }
}
