using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace App
{
    public partial class People : Crud
    {
        private bool loaded = false;
        public People()
        {
            InitializeComponent();
        }

        private void People_Load(object sender, EventArgs e)
        {
            tbJoined.Maximum = PersianDateTime.Now.Year;
        }
        public override void MyBind()
        {
            dataGridView1.DataSource = Program.dependencies.person.Select();
            dataGridView1.Refresh();
            if (!loaded)
            {
                dataGridView1.Columns.Add(new DataGridViewButtonColumn { DisplayIndex = 2, Name = "Card", Text = "کارت عضویت", UseColumnTextForButtonValue = true });
                loaded = true;
            }
            base.MyBind();
        }

        public override void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            base.CellContentClick(sender, e);
            var person = Program.dependencies.person.Find(SelectedId);

            if (e.ColumnIndex > 1)
            {
                var card = new Cute.Card();
                card.lblName.Content = $"{person.Firstname} {person.Lastname}";
                card.lblTitle.Content = $"{person.Title}";
                card.img34.Source = new BitmapImage(new Uri(File.Exists($"{Directory.GetCurrentDirectory()}\\People\\{person.Id}.png")
                    ? $"{Directory.GetCurrentDirectory()}\\People\\{person.Id}.png"
                    : Directory.GetCurrentDirectory() + "\\Resources\\human.png"));
                card.imgBack.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Resources\\back.jpg"));
                card.imgRocket.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Resources\\rocket.png"));
                card.Print();
                MessageBox.Show("خاتمه ی فرایند چاپ");
            }
            else
            {
                cbGroup.Text = person.Group;
                decimal o = 0;
                Decimal.TryParse(person.Joined, out o);
                tbJoined.Value = o;
                tbFirstname.Text = person.Firstname;
                tbLastname.Text = person.Lastname;
                tbOrganization.Text = person.Organization;
                tbAddress.Text = person.Address;
                tbEmail.Text = person.Email;
                tbPhone.Text = person.Phone;
                tbTitle.Text = person.Title;
                cbEducation.Text = person.Education;
                tbNotes.Text = person.Notes;
                Decimal.TryParse(person.ReferralCode, out o);
                person1.tbCode.Value = o;
                person1.tbName.Text = person.ReferralName;
                cbReferMethod.Text = person.ReferralMethod;
                tbBirthDate.Text = person.BirthDate;
            }
        }

        public override void MySelect()
        {
            tbFirstname.Text =
            tbLastname.Text =
            tbOrganization.Text =
            tbAddress.Text =
            tbEmail.Text =
            cbEducation.Text =
            tbNotes.Text =
            person1.tbName.Text =
            cbReferMethod.Text = string.Empty;
            base.MySelect();
        }

        public override void MyDelete()
        {
            Program.dependencies.person.Delete(SelectedId);
            base.MyDelete();
        }

        public override void MyUpdate()
        {
            Program.dependencies.person.Update(new Model.Person
            {
                Id = SelectedId ?? -1,
                Firstname = tbFirstname.Text,
                Lastname = tbLastname.Text,
                Joined = tbJoined.Value.ToString(),
                Phone = tbPhone.Text,
                Organization = tbOrganization.Text,
                Address = tbAddress.Text,
                Education = cbEducation.Text,
                Email = tbEmail.Text,
                Group = cbGroup.Text,
                ReferralMethod = cbReferMethod.Text,
                BirthDate = tbBirthDate.Text,
                Title = tbTitle.Text,
                Notes = tbNotes.Text,
                ReferralCode = person1.tbCode.Value.ToString(),
                ReferralName = person1.tbName.Text
            });
            base.MyUpdate();
        }

        public override void MyInsert()
        {
            Program.dependencies.person.Insert(new Model.Person
            {
                Firstname = tbFirstname.Text,
                Lastname = tbLastname.Text,
                Joined = tbJoined.Value.ToString(),
                Phone = tbPhone.Text,
                Organization = tbOrganization.Text,
                Address = tbAddress.Text,
                Education = cbEducation.Text,
                Email = tbEmail.Text,
                Group = cbGroup.Text,
                ReferralMethod = cbReferMethod.Text,
                BirthDate = tbBirthDate.Text,
                Title = tbTitle.Text,
                Notes = tbNotes.Text,
                ReferralCode = person1.tbCode.Value.ToString(),
                ReferralName = person1.tbName.Text
            });
            base.MyInsert();
        }
    }
}