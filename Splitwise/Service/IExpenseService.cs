using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Splitwise.Splitwise.Models;

namespace Splitwise.Splitwise.Service
{
    public interface IExpenseService
    {
        void AddNewExpense(Expense expense);
    }
}