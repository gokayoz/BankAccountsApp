using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp.UI.Models
{
    public class BankAccount
    {
        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "You can not deposit $" + amount;
            }
            if (amount > 220000)
            {
                return "AML Deposit Limited Reached."; // Anti-Money Laundering
            }

            Balance += amount;
            return "Deposit completed successfully.";
        }
        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return "You can not withdraw $" + amount;
            }
            if (amount > Balance)
            {
                return "You don't have enough money.";
            }

            Balance -= amount;
            return "Withdraw completed successfully.";
        }
    }
}
