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
        public decimal Balance { get; private set; }

        public string Deposit(decimal amount)
        {
            Balance += amount;

            return "Deposit complated successfully.";
        }
        public string Withdraw(decimal amount)
        {
            Balance -= amount;

            return "Withdraw complated successfully.";
        }
    }
}
