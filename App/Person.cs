using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class Person : UserControl
    {
        public Person()
        {
            InitializeComponent();
        }

        private void tbCode_ValueChanged(object sender, EventArgs e)
        {
            try {
                var person = Program.dependencies.person.Find((int)tbCode.Value);
                tbName.Text = $"{person.Firstname} {person.Lastname} - {person.Title}";
            }
            catch
            {

            }
        }
    }
}
