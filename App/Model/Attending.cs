using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace App.Model
{
    public class Attending
    {
        [DisplayName("شناسه مشارکت در دوره")]
        public int Id { get; set; }
        [DisplayName("شناسه دوره")]
        public int CourseId { get; set; }
        [DisplayName("تصویر شرکت کننده")]
        public Bitmap ParticipantImage
        {
            get
            {
                var _id = -1;
                Int32.TryParse(ParticipantCode, out _id);
                return new Model.Person
                {
                    Id = _id
                }.Pic;
            }
        }
        [DisplayName("تاریخ ثبت نام")]
        public string Submit { get; set; }
        [DisplayName("نمره پایان ترم")]
        public int? FinalMark { get; set; }
        [DisplayName("وضعیت پایان ترم")]
        public string FinalStatus { get; set; }
        [DisplayName("کد شرکت کننده")]
        public string ParticipantCode { get; set; }
        [DisplayName("نام شرکت کننده")]
        public string ParticipantName { get; set; }

    }
}
