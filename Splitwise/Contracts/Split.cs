using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Splitwise.Contracts
{
    public class Split
    {

        public User User { get; set; }
        public double Amount { get; set; }
        public int Percentage { get; set; }
    }
}