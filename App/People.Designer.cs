namespace App
{
    partial class People
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
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOrganization = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEducation = new System.Windows.Forms.ComboBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbJoined = new System.Windows.Forms.NumericUpDown();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbReferMethod = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.person1 = new App.Person();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbJoined)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.person1);
            this.panel3.Controls.Add(this.tbBirthDate);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.tbNotes);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.cbReferMethod);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.tbTitle);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tbJoined);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.cbGroup);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbEducation);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbOrganization);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbPhone);
            this.panel3.Controls.Add(this.tbEmail);
            this.panel3.Controls.Add(this.tbAddress);
            this.panel3.Controls.Add(this.tbLastname);
            this.panel3.Controls.Add(this.tbFirstname);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(395, 42);
            this.panel3.Size = new System.Drawing.Size(492, 495);
            this.panel3.Controls.SetChildIndex(this.label6, 0);
            this.panel3.Controls.SetChildIndex(this.label8, 0);
            this.panel3.Controls.SetChildIndex(this.label9, 0);
            this.panel3.Controls.SetChildIndex(this.label10, 0);
            this.panel3.Controls.SetChildIndex(this.tbFirstname, 0);
            this.panel3.Controls.SetChildIndex(this.tbLastname, 0);
            this.panel3.Controls.SetChildIndex(this.tbAddress, 0);
            this.panel3.Controls.SetChildIndex(this.tbEmail, 0);
            this.panel3.Controls.SetChildIndex(this.tbPhone, 0);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.tbOrganization, 0);
            this.panel3.Controls.SetChildIndex(this.label5, 0);
            this.panel3.Controls.SetChildIndex(this.cbEducation, 0);
            this.panel3.Controls.SetChildIndex(this.label11, 0);
            this.panel3.Controls.SetChildIndex(this.cbGroup, 0);
            this.panel3.Controls.SetChildIndex(this.label12, 0);
            this.panel3.Controls.SetChildIndex(this.tbJoined, 0);
            this.panel3.Controls.SetChildIndex(this.label7, 0);
            this.panel3.Controls.SetChildIndex(this.tbTitle, 0);
            this.panel3.Controls.SetChildIndex(this.label16, 0);
            this.panel3.Controls.SetChildIndex(this.cbReferMethod, 0);
            this.panel3.Controls.SetChildIndex(this.label17, 0);
            this.panel3.Controls.SetChildIndex(this.tbNotes, 0);
            this.panel3.Controls.SetChildIndex(this.label18, 0);
            this.panel3.Controls.SetChildIndex(this.tbBirthDate, 0);
            this.panel3.Controls.SetChildIndex(this.person1, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dataGridView1.Columns;
            this.comboBox1.DisplayMember = "HeaderText";
            this.comboBox1.Location = new System.Drawing.Point(136, 0);
            this.comboBox1.ValueMember = "DataPropertyName";
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(887, 42);
            // 
            // tbPhone
            // 
            this.tbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhone.Location = new System.Drawing.Point(259, 183);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(224, 20);
            this.tbPhone.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(259, 135);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(224, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(259, 76);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(224, 32);
            this.tbAddress.TabIndex = 2;
            // 
            // tbLastname
            // 
            this.tbLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastname.Location = new System.Drawing.Point(258, 28);
            this.tbLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(111, 20);
            this.tbLastname.TabIndex = 1;
            // 
            // tbFirstname
            // 
            this.tbFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstname.Location = new System.Drawing.Point(375, 29);
            this.tbFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(108, 20);
            this.tbFirstname.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(363, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "همراه:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(363, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "ایمیل:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(360, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "آدرس:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(361, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "نام و نام خانوادگی:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbOrganization
            // 
            this.tbOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrganization.Location = new System.Drawing.Point(14, 223);
            this.tbOrganization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOrganization.Name = "tbOrganization";
            this.tbOrganization.Size = new System.Drawing.Size(224, 20);
            this.tbOrganization.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(118, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "سازمان:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(118, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "تحصیلات:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbEducation
            // 
            this.cbEducation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEducation.FormattingEnabled = true;
            this.cbEducation.Items.AddRange(new object[] {
            "متوسطه اول",
            "متوسطه دوم",
            "پیش دانشگاهی",
            "کارشناسی",
            "کارشناسی ارشد",
            "کارشناسی ارشد (مربی)",
            "دکترا",
            "پژوهشگر فوق دکترا",
            "دکترا (استادیار)",
            "دکترا (دانشیار)",
            "دکترا (استاد)",
            "دکترا (استاد ممتاز)"});
            this.cbEducation.Location = new System.Drawing.Point(14, 271);
            this.cbEducation.Name = "cbEducation";
            this.cbEducation.Size = new System.Drawing.Size(224, 21);
            this.cbEducation.TabIndex = 6;
            // 
            // cbGroup
            // 
            this.cbGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Items.AddRange(new object[] {
            "منجم بعد از این",
            "منجم آماتور",
            "پژوهشگر",
            "مربی",
            "معلم",
            "پیشکسوت"});
            this.cbGroup.Location = new System.Drawing.Point(13, 29);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(222, 21);
            this.cbGroup.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(118, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "گروه:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(121, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "تاریخ عضویت:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbJoined
            // 
            this.tbJoined.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJoined.Location = new System.Drawing.Point(13, 78);
            this.tbJoined.Maximum = new decimal(new int[] {
            1400,
            0,
            0,
            0});
            this.tbJoined.Minimum = new decimal(new int[] {
            1381,
            0,
            0,
            0});
            this.tbJoined.Name = "tbJoined";
            this.tbJoined.Size = new System.Drawing.Size(222, 20);
            this.tbJoined.TabIndex = 22;
            this.tbJoined.Value = new decimal(new int[] {
            1385,
            0,
            0,
            0});
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(13, 126);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(224, 20);
            this.tbTitle.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(121, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "عنوان";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbReferMethod
            // 
            this.cbReferMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbReferMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbReferMethod.FormattingEnabled = true;
            this.cbReferMethod.Items.AddRange(new object[] {
            "اینترنت",
            "اعضا",
            "تبلیغات میدانی",
            "مدرسه",
            "سازمان دولتی",
            "سازمان خصوصی",
            "روزنامه و رسانه‌های رسمی",
            "سایر"});
            this.cbReferMethod.Location = new System.Drawing.Point(13, 174);
            this.cbReferMethod.Name = "cbReferMethod";
            this.cbReferMethod.Size = new System.Drawing.Size(222, 21);
            this.cbReferMethod.TabIndex = 29;
            this.cbReferMethod.Text = "اعضا";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.Location = new System.Drawing.Point(121, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 23);
            this.label16.TabIndex = 30;
            this.label16.Text = "شیوه‌ی معرفی:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNotes
            // 
            this.tbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNotes.Location = new System.Drawing.Point(259, 279);
            this.tbNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(224, 78);
            this.tbNotes.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label17.Location = new System.Drawing.Point(363, 254);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 23);
            this.label17.TabIndex = 32;
            this.label17.Text = "توضیحات:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label18.Location = new System.Drawing.Point(363, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 23);
            this.label18.TabIndex = 34;
            this.label18.Text = "تاریخ تولد:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbBirthDate
            // 
            this.tbBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBirthDate.Location = new System.Drawing.Point(258, 231);
            this.tbBirthDate.Mask = "0000-00-00";
            this.tbBirthDate.Name = "tbBirthDate";
            this.tbBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbBirthDate.Size = new System.Drawing.Size(224, 20);
            this.tbBirthDate.TabIndex = 35;
            // 
            // person1
            // 
            this.person1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.person1.Location = new System.Drawing.Point(0, 371);
            this.person1.Name = "person1";
            this.person1.Size = new System.Drawing.Size(492, 96);
            this.person1.TabIndex = 36;
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 537);
            this.Name = "People";
            this.Text = "People";
            this.Load += new System.EventHandler(this.People_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbJoined)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOrganization;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEducation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown tbJoined;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbReferMethod;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox tbBirthDate;
        private System.Windows.Forms.Label label18;
        private Person person1;
    }
}