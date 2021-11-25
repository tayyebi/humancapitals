using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Person
    {
        [DisplayName("شناسه کاربری")]
        public int Id { get; set; }
        [DisplayName("نام")]
        public string Firstname { get; set; }
        [DisplayName("نام خانوادگی")]
        public string Lastname { get; set; }
        [DisplayName("تاریخ تولد")]
        public string BirthDate { get; set; }
        [DisplayName("تحصیلات")]
        public string Education { get; set; }
        [DisplayName("پست الکترونیک")]
        public string Email { get; set; }
        [DisplayName("تلفن")]
        public string Phone { get; set; }
        [DisplayName("سازمان")]
        public string Organization { get; set; }
        [DisplayName("آدرس")]
        public string Address { get; set; }
        [DisplayName("گروه")]
        public string Group { get; set; }
        [DisplayName("تاریخ عضویت")]
        public string Joined { get; set; }
        [DisplayName("عنوان")]
        public string Title { get; set; }
        [DisplayName("شیوه معرفی")]
        public string ReferralMethod { get; set; }
        [DisplayName("شناسه معرف")]
        public string ReferralCode { get; set; }
        [DisplayName("نام معرف")]
        public string ReferralName { get; set; }
        [DisplayName("توضیحات")]
        public string Notes { get; set; }
    }
}
