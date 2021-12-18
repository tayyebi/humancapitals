namespace App
{
    partial class Transactions
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
            this.tbAmount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.person1 = new App.Person();
            this.tbReferral = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBank = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBankAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbBankAccount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbBank);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbAmount);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.tbNotes);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.person1);
            this.panel3.Controls.Add(this.tbReferral);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(726, 42);
            this.panel3.Size = new System.Drawing.Size(331, 481);
            this.panel3.Controls.SetChildIndex(this.label7, 0);
            this.panel3.Controls.SetChildIndex(this.tbReferral, 0);
            this.panel3.Controls.SetChildIndex(this.person1, 0);
            this.panel3.Controls.SetChildIndex(this.label17, 0);
            this.panel3.Controls.SetChildIndex(this.tbNotes, 0);
            this.panel3.Controls.SetChildIndex(this.label12, 0);
            this.panel3.Controls.SetChildIndex(this.tbAmount, 0);
            this.panel3.Controls.SetChildIndex(this.label1, 0);
            this.panel3.Controls.SetChildIndex(this.tbBank, 0);
            this.panel3.Controls.SetChildIndex(this.label2, 0);
            this.panel3.Controls.SetChildIndex(this.tbBankAccount, 0);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.tbDate, 0);
            this.panel3.Controls.SetChildIndex(this.label5, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dataGridView1.Columns;
            this.comboBox1.DisplayMember = "HeaderText";
            this.comboBox1.Location = new System.Drawing.Point(467, 0);
            this.comboBox1.ValueMember = "DataPropertyName";
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(417, 20);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1057, 42);
            // 
            // tbAmount
            // 
            this.tbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmount.Location = new System.Drawing.Point(101, 181);
            this.tbAmount.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(218, 20);
            this.tbAmount.TabIndex = 65;
            this.tbAmount.ThousandsSeparator = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(197, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 23);
            this.label12.TabIndex = 64;
            this.label12.Text = "مبلغ:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNotes
            // 
            this.tbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNotes.Location = new System.Drawing.Point(95, 75);
            this.tbNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(224, 78);
            this.tbNotes.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label17.Location = new System.Drawing.Point(194, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 23);
            this.label17.TabIndex = 63;
            this.label17.Text = "توضیحات:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // person1
            // 
            this.person1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.person1.Location = new System.Drawing.Point(0, 357);
            this.person1.Name = "person1";
            this.person1.Size = new System.Drawing.Size(331, 96);
            this.person1.TabIndex = 61;
            // 
            // tbReferral
            // 
            this.tbReferral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReferral.Location = new System.Drawing.Point(95, 28);
            this.tbReferral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReferral.Name = "tbReferral";
            this.tbReferral.Size = new System.Drawing.Size(224, 20);
            this.tbReferral.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(197, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 60;
            this.label7.Text = "کد پیگیری / شماره تراکنش:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbBank
            // 
            this.tbBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBank.Location = new System.Drawing.Point(98, 229);
            this.tbBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBank.Name = "tbBank";
            this.tbBank.Size = new System.Drawing.Size(224, 20);
            this.tbBank.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(200, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "بانک:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbBankAccount
            // 
            this.tbBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBankAccount.Location = new System.Drawing.Point(98, 276);
            this.tbBankAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBankAccount.Name = "tbBankAccount";
            this.tbBankAccount.Size = new System.Drawing.Size(224, 20);
            this.tbBankAccount.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(200, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "حساب:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(200, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 71;
            this.label4.Text = "تاریخ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDate
            // 
            this.tbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDate.Location = new System.Drawing.Point(98, 324);
            this.tbDate.Mask = "0000-00-00";
            this.tbDate.Name = "tbDate";
            this.tbDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDate.Size = new System.Drawing.Size(224, 20);
            this.tbDate.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "﷼";
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 523);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown tbAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label17;
        private Person person1;
        private System.Windows.Forms.TextBox tbReferral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBankAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tbDate;
        private System.Windows.Forms.Label label5;
    }
}