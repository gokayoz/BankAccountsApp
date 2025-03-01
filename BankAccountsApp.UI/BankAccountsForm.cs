using BankAccountsApp.UI.Models;

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
            BankAccount bankAccount = new(txtOwner.Text);
            bankAccounts.Add(bankAccount);

            RefreshGrid();
        }
        private void RefreshGrid()
        {
            dgvBankAccounts.DataSource = null;
            dgvBankAccounts.DataSource = bankAccounts;
            txtOwner.Text = string.Empty;
        }
    }
}
