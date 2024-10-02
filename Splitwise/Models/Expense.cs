using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Splitwise.Splitwise.Contracts;

namespace Splitwise.Splitwise.Models
{
    public class Expense
    {
        public Guid ExpenseId { set; get; }
        public string Description { set; get; }
        public double Amount { set; get; }
        public User PaidBy { get; set; }
        public SplitType SplitType { set; get; }
        public List<Split> Split { get; set; }
    }
}