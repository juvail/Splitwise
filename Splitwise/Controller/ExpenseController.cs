using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Splitwise.Splitwise.Contracts;
using Splitwise.Splitwise.Controller.Interfaces;
using Splitwise.Splitwise.Converter;
using Splitwise.Splitwise.Models;
using Splitwise.Splitwise.Service;

namespace Splitwise.Splitwise.Controller
{
    [ApiController]
    [Route("api/Expense")]
    public class ExpenseController : ControllerBase, IExpenseController
    {

        private readonly IExpenseService _expenseService;

        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpPost]
        public ExpenseInfo CreateExpense([FromBody] CreateExpense expense)
        {
            if (expense == null)
            {
                throw new ValidationException(nameof(expense));
            }

            ValidateExpense(expense);

            var newExpenses = new Expense
            {
                ExpenseId = Guid.NewGuid(),
                Amount = expense.Amount,
                Description = expense.Description,
                PaidBy = expense.PaidBy,
                Split = expense.Split,
                SplitType = expense.SplitType
            };
            _expenseService.AddNewExpense(newExpenses);
            return newExpenses.ToContract();
        }


        private void ValidateExpense(CreateExpense expense)
        {

            if (expense.Amount < 0)
            {
                throw new ValidationException("Amount cannot be a negative value");
            }

            if (expense.PaidBy == null)
            {
                throw new ValidationException("PaidBy user cannot be a null value");
            }

            if (expense.Split == null)
            {
                throw new ValidationException("Split should not be an empty value");
            }

            if (Enum.IsDefined(typeof(SplitType), expense.SplitType))
            {
                throw new ValidationException("should specify the split type");
            }
        }
    }
}