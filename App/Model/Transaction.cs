using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace App.Model
{
    class Transaction
    {
        [DisplayName("شناسه")]
        public int Id { get; set; }
        [DisplayName("تاریخ")]
        public string Date { get; set; }
        [DisplayName("مبلغ")]
        public string Amount { get; set; }
        [DisplayName("شناسه ی پرداخت بانکی")]
        public string BankRefferalCode { get; set; }
        [DisplayName("نام بانک مبدا")]
        public string BankName { get; set; }
        [DisplayName("حساب بانکی")]
        public string BankAccount { get; set; }
        [DisplayName("کد عضو واریز کننده")]
        public string OwnerCode { get; set; }
        [DisplayName("نام عضو واریز کننده")]
        public string OwnerName { get; set; }
        [DisplayName("توضیحات")]
        public string Notes { get; set; }
    }
}
