using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class Transactions : Crud
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            person1.label14.Text = "کد پرداخت کننده";
            person1.label15.Text = "نام پرداخت کننده";
        }
        public override void MyBind()
        {
            dataGridView1.DataSource = Program.dependencies.transaction.Select();
            dataGridView1.Refresh();
            base.MyBind();
        }
        public override void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            base.CellContentClick(sender, e);
            var transaction = Program.dependencies.transaction.Find(SelectedId);
            decimal o = 0;
            Decimal.TryParse(transaction.Amount, out o);
            tbAmount.Value = o;
            tbReferral.Text = transaction.BankRefferalCode;
            tbNotes.Text = transaction.Notes;
            tbDate.Text = transaction.Date;
            tbBankAccount.Text = transaction.BankAccount;
            tbBank.Text = transaction.BankName;
            int c = 0;
            Int32.TryParse(transaction.OwnerCode, out c);
            person1.tbCode.Value = c;
            person1.tbName.Text = transaction.OwnerName;
        }
        public override void MySelect()
        {
            person1.tbCode.Value =
            tbAmount.Value = 0;

            person1.tbName.Text =
            tbReferral.Text =
            tbNotes.Text =
            tbDate.Text =
            tbBankAccount.Text =
            tbBank.Text = string.Empty;
            base.MySelect();
        }
        public override void MyDelete()
        {
            Program.dependencies.transaction.Delete(SelectedId);
            base.MyDelete();
        }
        public override void MyUpdate()
        {
            Program.dependencies.transaction.Update(new Model.Transaction
            {
                Id = SelectedId ?? -1,
                Amount = tbAmount.Value.ToString(),
                BankAccount = tbBankAccount.Text,
                BankName = tbBank.Text,
                BankRefferalCode = tbReferral.Text,
                OwnerCode = person1.tbCode.Value.ToString(),
                OwnerName = person1.tbName.Text,
                Date = tbDate.Text,
                Notes = tbNotes.Text
            });
            base.MyUpdate();
        }

        public override void MyInsert()
        {
            Program.dependencies.transaction.Insert(new Model.Transaction
            {
                Amount = tbAmount.Value.ToString(),
                BankAccount = tbBankAccount.Text,
                BankName = tbBank.Text,
                BankRefferalCode = tbReferral.Text,
                OwnerCode = person1.tbCode.Value.ToString(),
                OwnerName = person1.tbName.Text,
                Date = tbDate.Text,
                Notes = tbNotes.Text
            });
            base.MyInsert();
        }
    }
}
