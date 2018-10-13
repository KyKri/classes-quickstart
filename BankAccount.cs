using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes

/* Bank Account Class Outline:
It has a 10-digit number that uniquely identifies the bank account.
It has a string that stores the name or names of the owners.
The balance can be retrieved.
It accepts deposits.
It accepts withdrawals.
The initial balance must be positive.
Withdrawals cannot result in a negative balance.
 */
{
    class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
