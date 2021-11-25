using System;

namespace App
{
    public partial class Intro : Root
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new People().ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new Courses().ShowDialog();

        }
    }
}
