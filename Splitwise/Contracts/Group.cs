using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Splitwise.Contracts
{
    public class Group
    {
        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public List<User> Members { get; set; }
        public List<Expense> Expenses { get; set; }
        //expense controller as per requirement
    }
}