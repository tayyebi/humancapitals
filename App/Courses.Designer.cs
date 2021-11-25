namespace App
{
    partial class Courses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTo = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.person1 = new App.Person();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbPlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCalendar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFee = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbFrom);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbFee);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.tbCalendar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbPlan);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbNotes);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.person1);
            this.panel3.Controls.Add(this.tbTo);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.tbTitle);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(482, 42);
            this.panel3.Size = new System.Drawing.Size(488, 418);
            this.panel3.Controls.SetChildIndex(this.label7, 0);
            this.panel3.Controls.SetChildIndex(this.tbTitle, 0);
            this.panel3.Controls.SetChildIndex(this.label18, 0);
            this.panel3.Controls.SetChildIndex(this.tbTo, 0);
            this.panel3.Controls.SetChildIndex(this.person1, 0);
            this.panel3.Controls.SetChildIndex(this.label17, 0);
            this.panel3.Controls.SetChildIndex(this.tbNotes, 0);
            this.panel3.Controls.SetChildIndex(this.label1, 0);
            this.panel3.Controls.SetChildIndex(this.tbPlan, 0);
            this.panel3.Controls.SetChildIndex(this.label2, 0);
            this.panel3.Controls.SetChildIndex(this.tbCalendar, 0);
            this.panel3.Controls.SetChildIndex(this.label12, 0);
            this.panel3.Controls.SetChildIndex(this.tbFee, 0);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.tbFrom, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dataGridView1.Columns;
            this.comboBox1.DisplayMember = "HeaderText";
            this.comboBox1.Location = new System.Drawing.Point(223, 0);
            this.comboBox1.ValueMember = "DataPropertyName";
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(970, 42);
            // 
            // tbTo
            // 
            this.tbTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTo.Location = new System.Drawing.Point(253, 126);
            this.tbTo.Mask = "0000-00-00";
            this.tbTo.Name = "tbTo";
            this.tbTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTo.Size = new System.Drawing.Size(224, 20);
            this.tbTo.TabIndex = 49;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label18.Location = new System.Drawing.Point(354, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 23);
            this.label18.TabIndex = 48;
            this.label18.Text = "پایان دوره:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(253, 28);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(224, 20);
            this.tbTitle.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(357, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "عنوان";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // person1
            // 
            this.person1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.person1.Location = new System.Drawing.Point(0, 294);
            this.person1.Name = "person1";
            this.person1.Size = new System.Drawing.Size(488, 96);
            this.person1.TabIndex = 50;
            // 
            // tbNotes
            // 
            this.tbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNotes.Location = new System.Drawing.Point(253, 174);
            this.tbNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(224, 78);
            this.tbNotes.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label17.Location = new System.Drawing.Point(357, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 23);
            this.label17.TabIndex = 52;
            this.label17.Text = "توضیحات:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPlan
            // 
            this.tbPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlan.Location = new System.Drawing.Point(5, 28);
            this.tbPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPlan.Multiline = true;
            this.tbPlan.Name = "tbPlan";
            this.tbPlan.Size = new System.Drawing.Size(224, 78);
            this.tbPlan.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(109, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "طرح درس:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCalendar
            // 
            this.tbCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCalendar.Location = new System.Drawing.Point(5, 133);
            this.tbCalendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCalendar.Multiline = true;
            this.tbCalendar.Name = "tbCalendar";
            this.tbCalendar.Size = new System.Drawing.Size(224, 78);
            this.tbCalendar.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(109, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "تقویم:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFee
            // 
            this.tbFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFee.Location = new System.Drawing.Point(5, 238);
            this.tbFee.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.tbFee.Name = "tbFee";
            this.tbFee.Size = new System.Drawing.Size(218, 20);
            this.tbFee.TabIndex = 58;
            this.tbFee.ThousandsSeparator = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(109, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 23);
            this.label12.TabIndex = 57;
            this.label12.Text = "شهریه:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFrom
            // 
            this.tbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFrom.Location = new System.Drawing.Point(256, 76);
            this.tbFrom.Mask = "0000-00-00";
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbFrom.Size = new System.Drawing.Size(224, 20);
            this.tbFrom.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(357, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 59;
            this.label4.Text = "شروع دوره:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 460);
            this.Name = "Courses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Courses_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbTo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label7;
        private Person person1;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tbFee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox tbFrom;
        private System.Windows.Forms.Label label4;
    }
}