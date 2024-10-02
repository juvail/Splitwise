using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Splitwise.Contracts
{
    public class UserExpenseBalanceSheet
    {
        public Dictionary<User, Balance> UserVsBalance { get; set; }
        public double TotalExpense { get; set; }
        public double TotalAmountPaid { get; set; }
        public double TotalOwn { get; set; }
        public double TotalGetBack { get; set; }

        //when user create an expense we need to update the balance sheet.
    }
}