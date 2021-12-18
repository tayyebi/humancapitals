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
    public partial class Courses : Crud
    {
        public Courses()
        {
            InitializeComponent();
        }

        bool loaded = false;

        private void Courses_Load(object sender, EventArgs e)
        {
            tbTo.Text = PersianDateTime.Now.AddDays(90).ToString("yyyy-MM-dd");
            tbFrom.Text = PersianDateTime.Now.AddDays(0).ToString("yyyy-MM-dd");
            person1.label14.Text = "کد مدرس";
            person1.label15.Text = "نام مدرس";
        }

        public override void MyBind()
        {
            if (!loaded)
            {
                dataGridView1.Columns.Add(new DataGridViewButtonColumn { DisplayIndex = 2, Name = "Participants", Text = "شرکت کنندگان", UseColumnTextForButtonValue = true });
                loaded = true;
            }
            dataGridView1.DataSource = Program.dependencies.course.Select();
            dataGridView1.Refresh();
            base.MyBind();
        }

        public override void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            base.CellContentClick(sender, e);

            var course = Program.dependencies.course.Find(SelectedId);

            switch (dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "Participants":
                    new Participants { Course = course }.ShowDialog();
                    break;
                case "Select":
                case "Delete":
                    decimal o = 0;
                    Decimal.TryParse(course.Fee, out o);
                    tbFee.Value = o;
                    tbCalendar.Text = course.Calendar;
                    tbFrom.Text = course.From;
                    tbNotes.Text = course.Notes;
                    tbPlan.Text = course.Plan;
                    tbTitle.Text = course.Title;
                    tbTo.Text = course.To;
                    person1.tbName.Text = course.TeacherName;
                    Decimal.TryParse(course.TeacherCode, out o);
                    person1.tbCode.Value = o;
                    break;
            }
        }

        public override void MySelect()
        {
            tbFee.Value = 0;
            tbCalendar.Text =
            tbFrom.Text =
            tbNotes.Text =
            tbPlan.Text =
            tbTitle.Text =
            tbTo.Text = string.Empty;
            base.MySelect();
        }

        public override void MyDelete()
        {
            Program.dependencies.course.Delete(SelectedId);
            base.MyDelete();
        }

        public override void MyUpdate()
        {
            Program.dependencies.course.Update(new Model.Course
            {
                Id = SelectedId ?? -1,
                Calendar = tbCalendar.Text,
                To = tbTo.Text,
                From = tbFrom.Text,
                Fee = tbFee.Value.ToString(),
                Notes = tbNotes.Text,
                Plan = tbPlan.Text,
                Title = tbTitle.Text,
                TeacherCode = person1.tbCode.Value.ToString(),
                TeacherName = person1.tbName.Text
            });
            base.MyUpdate();
        }

        public override void MyInsert()
        {
            Program.dependencies.course.Insert(new Model.Course
            {
                Calendar = tbCalendar.Text,
                To = tbTo.Text,
                From = tbFrom.Text,
                Fee = tbFee.Value.ToString(),
                Notes = tbNotes.Text,
                Plan = tbPlan.Text,
                Title = tbTitle.Text,
                TeacherCode = person1.tbCode.Value.ToString(),
                TeacherName = person1.tbName.Text
            });
            base.MyInsert();
        }
    }
}