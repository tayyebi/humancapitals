using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace App.Model
{
    public class Course
    {
        [DisplayName("شناسه درس")]
        public int Id { get; set; }
        [DisplayName("عنوان")]
        public string Title { get; set; }
        [DisplayName("طرح درس")]
        public string Plan { get; set; }
        [DisplayName("از تاریخ")]
        public string From { get; set; }
        [DisplayName("تا تاریخ")]
        public string To { get; set; }
        [DisplayName("توضیحات")]
        public string Notes { get; set; }
        [DisplayName("کد مدرس")]
        public string TeacherCode { get; set; }
        [DisplayName("نام مدرس")]
        public string TeacherName { get; set; }
        [DisplayName("شهریه")]
        public string Fee { get; set; }
        [DisplayName("تقویم")]
        public string Calendar { get; set; }
    }
}
