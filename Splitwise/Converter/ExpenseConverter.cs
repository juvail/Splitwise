using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Splitwise.Splitwise.Contracts;
using Splitwise.Splitwise.Models;

namespace Splitwise.Splitwise.Converter
{
    public static class ExpenseConverter
    {
        public static ExpenseInfo ToContract(this Expense expense){
            var expenseInfo = new ExpenseInfo
            {
                ExpenseId = expense.ExpenseId,
                Amount = expense.Amount,
                Description = expense.Description,
                PaidBy = expense.PaidBy,
                Split = expense.Split,
                SplitType = expense.SplitType
            };
            return expenseInfo;
        } 
    }
}