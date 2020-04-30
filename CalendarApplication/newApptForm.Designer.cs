namespace Calendar
{
    partial class newApptForm
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
            this.saveNewAppt = new System.Windows.Forms.Button();
            this.cancelNewAppt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.subjectNewAppt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.locationNewAppt = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateNewAppt = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.startTimeNewAppt = new System.Windows.Forms.ComboBox();
            this.lengthNewAppt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // saveNewAppt
            // 
            this.saveNewAppt.Location = new System.Drawing.Point(327, 203);
            this.saveNewAppt.Name = "saveNewAppt";
            this.saveNewAppt.Size = new System.Drawing.Size(75, 23);
            this.saveNewAppt.TabIndex = 0;
            this.saveNewAppt.Text = "Save";
            this.saveNewAppt.UseVisualStyleBackColor = true;
            // 
            // cancelNewAppt
            // 
            this.cancelNewAppt.Location = new System.Drawing.Point(408, 203);
            this.cancelNewAppt.Name = "cancelNewAppt";
            this.cancelNewAppt.Size = new System.Drawing.Size(75, 23);
            this.cancelNewAppt.TabIndex = 1;
            this.cancelNewAppt.Text = "Cancel";
            this.cancelNewAppt.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Subject:";
            // 
            // subjectNewAppt
            // 
            this.subjectNewAppt.Location = new System.Drawing.Point(102, 25);
            this.subjectNewAppt.Name = "subjectNewAppt";
            this.subjectNewAppt.Size = new System.Drawing.Size(381, 20);
            this.subjectNewAppt.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Location:";
            // 
            // locationNewAppt
            // 
            this.locationNewAppt.Location = new System.Drawing.Point(102, 60);
            this.locationNewAppt.Name = "locationNewAppt";
            this.locationNewAppt.Size = new System.Drawing.Size(381, 20);
            this.locationNewAppt.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 116);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 20);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Date:";
            // 
            // dateNewAppt
            // 
            this.dateNewAppt.Location = new System.Drawing.Point(86, 116);
            this.dateNewAppt.Name = "dateNewAppt";
            this.dateNewAppt.Size = new System.Drawing.Size(68, 20);
            this.dateNewAppt.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(177, 116);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(68, 20);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "Start Time:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(341, 117);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(68, 20);
            this.textBox8.TabIndex = 9;
            this.textBox8.Text = "Length:";
            // 
            // startTimeNewAppt
            // 
            this.startTimeNewAppt.FormattingEnabled = true;
            this.startTimeNewAppt.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.startTimeNewAppt.Location = new System.Drawing.Point(251, 116);
            this.startTimeNewAppt.Name = "startTimeNewAppt";
            this.startTimeNewAppt.Size = new System.Drawing.Size(68, 21);
            this.startTimeNewAppt.TabIndex = 10;
            // 
            // lengthNewAppt
            // 
            this.lengthNewAppt.FormattingEnabled = true;
            this.lengthNewAppt.Items.AddRange(new object[] {
            "30 minutes",
            "1 hour ",
            "1 hour 30 minutes",
            "2 hours",
            "2 hour 30 minutes",
            "3 hours",
            "3 hours 30 minutes",
            "4 hours",
            "4 hours 30 minutes",
            "5 hours",
            "5 hours 30 minutes",
            "6 hours",
            "6 hours 30 minutes",
            "7 hours",
            "7 hours 30 minutes",
            "8 hours",
            "8 hours 30 minutes",
            "9 hours",
            "9 hours 30 minutes",
            "10 hours",
            "10 hours 30 minutes",
            "11 hours",
            "11 hours 30 minutes",
            "12 hours"});
            this.lengthNewAppt.Location = new System.Drawing.Point(415, 117);
            this.lengthNewAppt.Name = "lengthNewAppt";
            this.lengthNewAppt.Size = new System.Drawing.Size(68, 21);
            this.lengthNewAppt.TabIndex = 11;
            // 
            // newApptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 245);
            this.Controls.Add(this.lengthNewAppt);
            this.Controls.Add(this.startTimeNewAppt);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.dateNewAppt);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.locationNewAppt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.subjectNewAppt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancelNewAppt);
            this.Controls.Add(this.saveNewAppt);
            this.Name = "newApptForm";
            this.Text = "newApptForm";
            this.Load += new System.EventHandler(this.newApptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveNewAppt;
        private System.Windows.Forms.Button cancelNewAppt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox subjectNewAppt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox locationNewAppt;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox dateNewAppt;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox startTimeNewAppt;
        private System.Windows.Forms.ComboBox lengthNewAppt;
    }
}