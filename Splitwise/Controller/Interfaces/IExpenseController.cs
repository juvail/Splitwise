using Microsoft.AspNetCore.Mvc;
using Splitwise.Splitwise.Contracts;

namespace Splitwise.Splitwise.Controller.Interfaces
{
    public interface IExpenseController
    {
        IActionResult CreateExpense([FromBody] CreateExpense expense);
    };
}