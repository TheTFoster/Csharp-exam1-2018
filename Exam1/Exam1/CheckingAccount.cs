using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class CheckingAccount : Account
    {
        public double minimumBalance { get; set; }

        public override double makeDep()
        {
            throw new NotImplementedException();
        }
        public override double makeWith()
        {
            throw new NotImplementedException();
        }
    }
}
