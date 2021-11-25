using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class Crud : Root
    {

        public enum Mode
        {
            Select,
            Update,
            Delete
        }

        private Mode currentMode;

        public Mode CurrentMode
        {
            get
            {
                return currentMode;
            }
            set
            {
                switch (value)
                {

                    case Mode.Select:
                        label3.Text = "حالت جدید";
                        SelectedId = null;
                        MyBind();
                        break;
                    case Mode.Update:
                        label3.Text = "حالت ویرایش";
                        break;
                    case Mode.Delete:
                        label3.Text = "هشدار!!! حذف";
                        break;
                }

                currentMode = value;

            }
        }


        public Crud()
        {
            InitializeComponent();
        }

        private void Crud_Load(object sender, EventArgs e)
        {
            CurrentMode = Mode.Select;
        }


        /// <summary>
        /// شناسه ی انتخاب شده توسط کاربر روی گرید
        /// </summary>
        protected int ? SelectedId { get; set; }

        /// <summary>
        /// اعمال تغییرات
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void Done_Click(object sender, EventArgs e)
        {
            switch (CurrentMode)
            {

                case Mode.Select:
                    MyInsert();
                    break;
                case Mode.Update:
                    MyUpdate();
                    break;
                case Mode.Delete:
                    MyDelete();
                    break;

            }

            MyBind();
            MySelect();
        }

        /// <summary>
        /// انتخاب توسط کاربر
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Rows.Count < 1)
                return;

            SelectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

            switch (e.ColumnIndex)
            {

                case 0:
                    CurrentMode = Mode.Update;
                    break;
                case 1:
                    CurrentMode = Mode.Delete;
                    break;

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySelect();
        }

        public virtual void MyBind()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = dataGridView1.Columns;
            comboBox1.DisplayMember = "HeaderText";
            comboBox1.ValueMember = "DataPropertyName";
            comboBox1.Refresh();

            // comboBox1.SelectedIndex = 4;

            //var the_source = ((IEnumerable<object>)dataGridView1.DataSource);
            //label1.Text = the_source.Count().ToString();
        }

        /// <summary>
        /// When on insert
        /// </summary>
        public virtual void MyInsert()
        {
            CurrentMode = Mode.Select;
            MessageBox.Show("رکورد با موفقیت اضافه شد");
        }

        /// <summary>
        /// When on new form or cancel
        /// </summary>
        public virtual void MySelect()
        {
            CurrentMode = Mode.Select;
        }
        /// <summary>
        /// When update done
        /// </summary>
        public virtual void MyUpdate()
        {
            CurrentMode = Mode.Select;
            MessageBox.Show("رکورد با موفقیت به روز رسانی شد");
        }
        /// <summary>
        /// When delete done
        /// </summary>
        public virtual void MyDelete()
        {
            CurrentMode = Mode.Select;
            MessageBox.Show("رکورد با موفقیت حذف شد");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                var columnName = comboBox1.SelectedValue.ToString();
                if (columnName == string.Empty)
                    return;
                if ((r.Cells[columnName].Value).ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                {
                    dataGridView1.Rows[r.Index].Visible = true;
                    dataGridView1.Rows[r.Index].Selected = true;
                }
                else
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[r.Index].Visible = false;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value.ToString().Replace(",","-") + "\"").ToArray()));
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "comma seperated value files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 1;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, sb.ToString());
                }
            }
        }
    }
}
