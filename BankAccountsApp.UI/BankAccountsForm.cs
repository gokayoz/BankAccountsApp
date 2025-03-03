using BankAccountsApp.UI.Models;
using System.Numerics;
using System.Text.RegularExpressions;

namespace BankAccountsApp.UI
{
    public partial class BankAccountsForm : Form
    {
        List<BankAccount> bankAccounts = new();
        public BankAccountsForm()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOwner.Text) || !Regex.IsMatch(txtOwner.Text, @"^[a-zA-ZçÇðÐýÝöÖþÞüÜ]+$"))
            {
                MessageBox.Show("Please enter a valid value!");
                return;
            }
            if (nudInterestRate.Value > 0)
            {
                bankAccounts.Add(new SavingsAccount(txtOwner.Text, nudInterestRate.Value));
            }
            else
            {
                bankAccounts.Add(new BankAccount(txtOwner.Text));
            }
            RefreshGrid(); ;
        }
        private void RefreshGrid()
        {
            dgvBankAccounts.DataSource = null;
            dgvBankAccounts.DataSource = bankAccounts;
            txtOwner.Text = string.Empty;
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (dgvBankAccounts.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = dgvBankAccounts.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Deposit(nudAmount.Value);
                RefreshGrid();
                nudAmount.Value = 0;
                MessageBox.Show(message);
            }
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (dgvBankAccounts.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = dgvBankAccounts.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Withdraw(nudAmount.Value);
                RefreshGrid();
                nudAmount.Value = 0;
                MessageBox.Show(message);
            }
        }
    }
}
