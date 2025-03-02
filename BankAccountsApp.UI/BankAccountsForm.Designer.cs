namespace BankAccountsApp.UI
{
    partial class BankAccountsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAccountsForm));
            btnCreate = new Button();
            dgvBankAccounts = new DataGridView();
            label1 = new Label();
            nudAmount = new NumericUpDown();
            label2 = new Label();
            txtOwner = new TextBox();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            label3 = new Label();
            nudInterestRate = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvBankAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInterestRate).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Gainsboro;
            btnCreate.Location = new Point(171, 164);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(218, 43);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Account";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvBankAccounts
            // 
            dgvBankAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBankAccounts.BackgroundColor = Color.White;
            dgvBankAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankAccounts.Location = new Point(409, 12);
            dgvBankAccounts.Name = "dgvBankAccounts";
            dgvBankAccounts.RowHeadersWidth = 51;
            dgvBankAccounts.Size = new Size(650, 350);
            dgvBankAccounts.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 27);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 2;
            label1.Text = "Owner:";
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(171, 243);
            nudAmount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(218, 34);
            nudAmount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 245);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 2;
            label2.Text = "Amount:";
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(171, 24);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(218, 34);
            txtOwner.TabIndex = 4;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.Gainsboro;
            btnDeposit.Location = new Point(19, 319);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(178, 43);
            btnDeposit.TabIndex = 0;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = Color.Gainsboro;
            btnWithdraw.Location = new Point(211, 319);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(178, 43);
            btnWithdraw.TabIndex = 0;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 102);
            label3.Name = "label3";
            label3.Size = new Size(142, 28);
            label3.TabIndex = 5;
            label3.Text = "Interest Rate %";
            // 
            // nudInterestRate
            // 
            nudInterestRate.Location = new Point(171, 100);
            nudInterestRate.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudInterestRate.Name = "nudInterestRate";
            nudInterestRate.Size = new Size(218, 34);
            nudInterestRate.TabIndex = 3;
            // 
            // BankAccountsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1072, 377);
            Controls.Add(label3);
            Controls.Add(txtOwner);
            Controls.Add(label2);
            Controls.Add(nudInterestRate);
            Controls.Add(nudAmount);
            Controls.Add(label1);
            Controls.Add(dgvBankAccounts);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(btnCreate);
            Font = new Font("Segoe UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "BankAccountsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bank Accounts";
            ((System.ComponentModel.ISupportInitialize)dgvBankAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInterestRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private DataGridView dgvBankAccounts;
        private Label label1;
        private NumericUpDown nudAmount;
        private Label label2;
        private TextBox txtOwner;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Label label3;
        private NumericUpDown nudInterestRate;
    }
}
