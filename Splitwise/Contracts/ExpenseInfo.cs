using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Splitwise.Contracts
{
    public class ExpenseInfo
    {
         public Guid ExpenseId { set; get; }
        public string Description { set; get; }
        public double Amount { set; get; }
        public User PaidBy { get; set; }
        public SplitType SplitType { set; get; }
        public List<Split> Split { get; set; }
    }
}