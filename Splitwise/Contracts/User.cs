using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Splitwise.Contracts
{
    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public UserExpensebalanceSheet UserExpensebalanceSheet { get; set; }
    }
}