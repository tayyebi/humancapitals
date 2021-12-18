using Microsoft.Win32;
using System;
using System.IO;

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

        private void button3_Click(object sender, EventArgs e)
        {
            new Transactions().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "فایل پشتیبان (*.db.back)|*.db.back";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == true)
            {
                var oldFilePath = Directory.GetCurrentDirectory() + "\\Resources\\local.db";
                File.Copy(oldFilePath, saveFileDialog1.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Voluntarilies().ShowDialog();
        }
    }
}
