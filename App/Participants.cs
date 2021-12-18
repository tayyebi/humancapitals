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
    public partial class Participants : Crud
    {
        public Model.Course Course { get; set; }

        public Participants()
        {
            InitializeComponent();
        }

        private void Participants_Load(object sender, EventArgs e)
        {
            label1.Text = Course.Title;
            person1.label14.Text = "کد شرکت کننده";
            person1.label15.Text = "نام شرکت کننده";
        }
        bool loaded = false;
        public override void MyBind()
        {
            if (!loaded)
            {
                dataGridView1.Columns.Add(new DataGridViewButtonColumn { DisplayIndex = 2, Name = "Certificate", Text = "گواهی", UseColumnTextForButtonValue = true });
                loaded = true;
            }
            dataGridView1.DataSource = Program.dependencies.attending.Select();
            dataGridView1.Refresh();
            base.MyBind();
        }

        public override void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            base.CellContentClick(sender, e);
            var attending = Program.dependencies.attending.Find(SelectedId);

            switch (dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "Certificate":
                    //var card = new Cute.Card();
                    //card.lblName.Content = $"{person.Firstname} {person.Lastname}";
                    //card.lblTitle.Content = $"{person.Title}";
                    //card.lblCode.Content = $"{person.Id}";
                    //// card.img34.Source = new MyBitmap().Bitmap2BitmapImage(person.Pic);
                    //card.img34.Source = new BitmapImage(new Uri(File.Exists($"{Directory.GetCurrentDirectory()}\\People\\{person.Id}.png")
                    //    ? $"{Directory.GetCurrentDirectory()}\\People\\{person.Id}.png"
                    //    : Directory.GetCurrentDirectory() + "\\Resources\\human.png"));
                    //card.imgRocket.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Resources\\rocket.png"));
                    //card.Print();
                    //MessageBox.Show("خاتمه ی فرایند چاپ");
                    break;
                case "Select":
                case "Delete":
                    int o = 0;
                    tbFinalMark.Value = o;
                    cbFinalStatus.Text = attending.FinalStatus;
                    tbSubmit.Text = attending.Submit;
                    person1.tbName.Text = attending.ParticipantName;
                    Int32.TryParse(attending.ParticipantCode, out o);
                    person1.tbCode.Value = o;
                    break;
            }
        }

        public override void MySelect()
        {
            tbSubmit.Text = string.Empty;
            cbFinalStatus.Text = "در حال شرکت در دوره";
            tbFinalMark.Value = 0;
            base.MySelect();
        }

        public override void MyDelete()
        {
            Program.dependencies.attending.Delete(SelectedId);
            base.MyDelete();
        }

        public override void MyUpdate()
        {
            Program.dependencies.attending.Update(
                new Model.Attending
                {
                    Id = SelectedId ?? -1,
                    FinalMark = (int)tbFinalMark.Value,
                    FinalStatus = cbFinalStatus.Text,
                    ParticipantCode = person1.tbCode.Value.ToString(),
                    ParticipantName = person1.tbName.Text
                });
            base.MyUpdate();
        }

        public override void MyInsert()
        {
            Program.dependencies.attending.Insert(new Model.Attending
            {
                FinalMark = (int)tbFinalMark.Value,
                FinalStatus = cbFinalStatus.Text,
                ParticipantCode = person1.tbCode.Value.ToString(),
                ParticipantName = person1.tbName.Text
            });
            base.MyInsert();
        }
    }
}
