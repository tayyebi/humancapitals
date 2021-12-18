using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace App.Model
{
    class Voluntarily
    {
        [DisplayName("شناسه")]
        public int Id { get; set; }
        [DisplayName("عنوان")]
        public string Title { get; set; }
        [DisplayName("از تاریخ")]
        public string From { get; set; }
        [DisplayName("تا تاریخ")]
        public string To { get; set; }
        [DisplayName("فعالیت ها")]
        public string Activities { get; set; }
        [DisplayName("کد داوطلب")]
        public string VolunteerCode { get; set; }
        [DisplayName("نام داوطلب")]
        public string VolunteerName { get; set; }
    }
}
