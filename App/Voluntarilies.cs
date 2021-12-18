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
    public partial class Voluntarilies : Crud
    {
        public Voluntarilies()
        {
            InitializeComponent();
        }

        private void Voluntarilies_Load(object sender, EventArgs e)
        {
            person1.label14.Text = "کد داوطلب";
            person1.label15.Text = "نام داوطلب";
            tbTo.Text = PersianDateTime.Now.AddDays(90).ToString("yyyy-MM-dd");
            tbFrom.Text = PersianDateTime.Now.AddDays(0).ToString("yyyy-MM-dd");
        }

        bool loaded = false;
        public override void MyBind()
        {
            if (!loaded)
            {
                // dataGridView1.Columns.Add(new DataGridViewButtonColumn { DisplayIndex = 2, Name = "Participants", Text = "شرکت کنندگان", UseColumnTextForButtonValue = true });
                loaded = true;
            }
            dataGridView1.DataSource = Program.dependencies.voluntarily.Select();
            dataGridView1.Refresh();
            base.MyBind();
        }

        public override void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            base.CellContentClick(sender, e);

            var voluntarily = Program.dependencies.voluntarily.Find(SelectedId);

            switch (dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "Participants":
                    // new Participants { Course = course }.ShowDialog();
                    break;
                case "Select":
                case "Delete":
                    decimal o = 0;
                    Decimal.TryParse(voluntarily.VolunteerCode, out o);
                    person1.tbCode.Value = o;
                    person1.tbName.Text = voluntarily.VolunteerName;
                    tbFrom.Text = voluntarily.From;
                    tbNotes.Text = voluntarily.Activities;
                    tbTitle.Text = voluntarily.Title;
                    tbTo.Text = voluntarily.To;
                    break;
            }
        }

        public override void MySelect()
        {
            tbFrom.Text =
            tbNotes.Text =
            tbTitle.Text =
            tbTo.Text = string.Empty;
            base.MySelect();
        }

        public override void MyDelete()
        {
            Program.dependencies.voluntarily.Delete(SelectedId);
            base.MyDelete();
        }

        public override void MyUpdate()
        {
            Program.dependencies.voluntarily.Update(new Model.Voluntarily
            {
                Id = SelectedId ?? -1,
                To = tbTo.Text,
                From = tbFrom.Text,
                Activities = tbNotes.Text,
                Title = tbTitle.Text,
                VolunteerCode = person1.tbCode.Value.ToString(),
                VolunteerName = person1.tbName.Text
            });
            base.MyUpdate();
        }

        public override void MyInsert()
        {
            Program.dependencies.voluntarily.Insert(new Model.Voluntarily
            {
                To = tbTo.Text,
                From = tbFrom.Text,
                Activities = tbNotes.Text,
                Title = tbTitle.Text,
                VolunteerCode = person1.tbCode.Value.ToString(),
                VolunteerName = person1.tbName.Text
            });
            base.MyInsert();
        }
    }
}
