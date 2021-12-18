namespace App
{
    partial class Participants
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
            this.tbSubmit = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFinalMark = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.person1 = new App.Person();
            this.cbFinalStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFinalMark)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbFinalStatus);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.tbSubmit);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbFinalMark);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.person1);
            this.panel3.Location = new System.Drawing.Point(503, 42);
            this.panel3.Size = new System.Drawing.Size(464, 349);
            this.panel3.Controls.SetChildIndex(this.person1, 0);
            this.panel3.Controls.SetChildIndex(this.label12, 0);
            this.panel3.Controls.SetChildIndex(this.tbFinalMark, 0);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.tbSubmit, 0);
            this.panel3.Controls.SetChildIndex(this.label16, 0);
            this.panel3.Controls.SetChildIndex(this.cbFinalStatus, 0);
            this.panel3.Controls.SetChildIndex(this.label1, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dataGridView1.Columns;
            this.comboBox1.DisplayMember = "HeaderText";
            this.comboBox1.Location = new System.Drawing.Point(244, 0);
            this.comboBox1.ValueMember = "DataPropertyName";
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(967, 42);
            // 
            // tbSubmit
            // 
            this.tbSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubmit.Location = new System.Drawing.Point(223, 61);
            this.tbSubmit.Mask = "0000-00-00";
            this.tbSubmit.Name = "tbSubmit";
            this.tbSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSubmit.Size = new System.Drawing.Size(224, 20);
            this.tbSubmit.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(327, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 64;
            this.label4.Text = "تاریخ ثبت نام:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFinalMark
            // 
            this.tbFinalMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFinalMark.Location = new System.Drawing.Point(225, 110);
            this.tbFinalMark.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.tbFinalMark.Name = "tbFinalMark";
            this.tbFinalMark.Size = new System.Drawing.Size(222, 20);
            this.tbFinalMark.TabIndex = 63;
            this.tbFinalMark.ThousandsSeparator = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(333, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 23);
            this.label12.TabIndex = 62;
            this.label12.Text = "نمره پایانی:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // person1
            // 
            this.person1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.person1.Location = new System.Drawing.Point(0, 225);
            this.person1.Name = "person1";
            this.person1.Size = new System.Drawing.Size(464, 96);
            this.person1.TabIndex = 61;
            // 
            // cbFinalStatus
            // 
            this.cbFinalStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFinalStatus.FormattingEnabled = true;
            this.cbFinalStatus.Items.AddRange(new object[] {
            "در حال شرکت در دوره",
            "قبول",
            "نمونه",
            "مردود",
            "حذف غیبت"});
            this.cbFinalStatus.Location = new System.Drawing.Point(225, 159);
            this.cbFinalStatus.Name = "cbFinalStatus";
            this.cbFinalStatus.Size = new System.Drawing.Size(222, 21);
            this.cbFinalStatus.TabIndex = 66;
            this.cbFinalStatus.Text = "در حال شرکت در دوره";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.Location = new System.Drawing.Point(333, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 23);
            this.label16.TabIndex = 67;
            this.label16.Text = "وضعیت شرکت کننده:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Participants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 391);
            this.Name = "Participants";
            this.Text = "Participants";
            this.Load += new System.EventHandler(this.Participants_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFinalMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tbFinalMark;
        private System.Windows.Forms.Label label12;
        private Person person1;
        private System.Windows.Forms.ComboBox cbFinalStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
    }
}