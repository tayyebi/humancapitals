namespace App
{
    partial class Voluntarilies
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
            this.tbFrom = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.person1 = new App.Person();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.person1);
            this.panel3.Controls.Add(this.tbFrom);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbNotes);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.tbTitle);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.tbTo);
            this.panel3.Location = new System.Drawing.Point(551, 42);
            this.panel3.Size = new System.Drawing.Size(329, 405);
            this.panel3.Controls.SetChildIndex(this.tbTo, 0);
            this.panel3.Controls.SetChildIndex(this.label18, 0);
            this.panel3.Controls.SetChildIndex(this.tbTitle, 0);
            this.panel3.Controls.SetChildIndex(this.label17, 0);
            this.panel3.Controls.SetChildIndex(this.label7, 0);
            this.panel3.Controls.SetChildIndex(this.tbNotes, 0);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.tbFrom, 0);
            this.panel3.Controls.SetChildIndex(this.person1, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dataGridView1.Columns;
            this.comboBox1.DisplayMember = "HeaderText";
            this.comboBox1.Location = new System.Drawing.Point(292, 0);
            this.comboBox1.ValueMember = "DataPropertyName";
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(880, 42);
            // 
            // tbFrom
            // 
            this.tbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFrom.Location = new System.Drawing.Point(97, 76);
            this.tbFrom.Mask = "0000-00-00";
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbFrom.Size = new System.Drawing.Size(224, 20);
            this.tbFrom.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(198, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 68;
            this.label4.Text = "شروع دوره:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNotes
            // 
            this.tbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNotes.Location = new System.Drawing.Point(94, 174);
            this.tbNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(224, 78);
            this.tbNotes.TabIndex = 66;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label17.Location = new System.Drawing.Point(198, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 23);
            this.label17.TabIndex = 67;
            this.label17.Text = "توضیحات:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTo
            // 
            this.tbTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTo.Location = new System.Drawing.Point(94, 126);
            this.tbTo.Mask = "0000-00-00";
            this.tbTo.Name = "tbTo";
            this.tbTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTo.Size = new System.Drawing.Size(224, 20);
            this.tbTo.TabIndex = 64;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label18.Location = new System.Drawing.Point(195, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 23);
            this.label18.TabIndex = 63;
            this.label18.Text = "پایان دوره:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(94, 28);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(224, 20);
            this.tbTitle.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(198, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 62;
            this.label7.Text = "عنوان:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // person1
            // 
            this.person1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.person1.Location = new System.Drawing.Point(0, 281);
            this.person1.Name = "person1";
            this.person1.Size = new System.Drawing.Size(329, 96);
            this.person1.TabIndex = 70;
            // 
            // Voluntarilies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 447);
            this.Name = "Voluntarilies";
            this.Text = "Voluntarilies";
            this.Load += new System.EventHandler(this.Voluntarilies_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Person person1;
        private System.Windows.Forms.MaskedTextBox tbFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox tbTo;
    }
}