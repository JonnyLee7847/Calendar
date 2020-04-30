namespace Calendar
{
    partial class RecurringApptForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.subjectRecAppt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.locationRecAppt = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateRecAppt = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.startTimeRecAppt = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lengthRecAppt = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.frequencyRecAppt = new System.Windows.Forms.ComboBox();
            this.howManyRecAppt = new System.Windows.Forms.TextBox();
            this.cancelNewRecAppt = new System.Windows.Forms.Button();
            this.saveNewRecAppt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Subject:";
            // 
            // subjectRecAppt
            // 
            this.subjectRecAppt.Location = new System.Drawing.Point(85, 12);
            this.subjectRecAppt.Name = "subjectRecAppt";
            this.subjectRecAppt.Size = new System.Drawing.Size(351, 20);
            this.subjectRecAppt.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Location:";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // locationRecAppt
            // 
            this.locationRecAppt.Location = new System.Drawing.Point(85, 38);
            this.locationRecAppt.Name = "locationRecAppt";
            this.locationRecAppt.Size = new System.Drawing.Size(351, 20);
            this.locationRecAppt.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 78);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Date:";
            // 
            // dateRecAppt
            // 
            this.dateRecAppt.Location = new System.Drawing.Point(85, 78);
            this.dateRecAppt.Name = "dateRecAppt";
            this.dateRecAppt.Size = new System.Drawing.Size(67, 20);
            this.dateRecAppt.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(194, 78);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(67, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Start Time:";
            // 
            // startTimeRecAppt
            // 
            this.startTimeRecAppt.FormattingEnabled = true;
            this.startTimeRecAppt.Items.AddRange(new object[] {
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
            this.startTimeRecAppt.Location = new System.Drawing.Point(267, 78);
            this.startTimeRecAppt.Name = "startTimeRecAppt";
            this.startTimeRecAppt.Size = new System.Drawing.Size(67, 21);
            this.startTimeRecAppt.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(368, 79);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(67, 20);
            this.textBox8.TabIndex = 8;
            this.textBox8.Text = "Length:";
            // 
            // lengthRecAppt
            // 
            this.lengthRecAppt.FormattingEnabled = true;
            this.lengthRecAppt.Items.AddRange(new object[] {
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
            this.lengthRecAppt.Location = new System.Drawing.Point(441, 79);
            this.lengthRecAppt.Name = "lengthRecAppt";
            this.lengthRecAppt.Size = new System.Drawing.Size(68, 21);
            this.lengthRecAppt.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(13, 131);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(66, 20);
            this.textBox9.TabIndex = 10;
            this.textBox9.Text = "Frequency:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(194, 131);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(95, 20);
            this.textBox10.TabIndex = 11;
            this.textBox10.Text = "How Many Times:";
            // 
            // frequencyRecAppt
            // 
            this.frequencyRecAppt.FormattingEnabled = true;
            this.frequencyRecAppt.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Yearly",
            "Monthly"});
            this.frequencyRecAppt.Location = new System.Drawing.Point(86, 131);
            this.frequencyRecAppt.Name = "frequencyRecAppt";
            this.frequencyRecAppt.Size = new System.Drawing.Size(66, 21);
            this.frequencyRecAppt.TabIndex = 12;
            // 
            // howManyRecAppt
            // 
            this.howManyRecAppt.Location = new System.Drawing.Point(295, 132);
            this.howManyRecAppt.Name = "howManyRecAppt";
            this.howManyRecAppt.Size = new System.Drawing.Size(39, 20);
            this.howManyRecAppt.TabIndex = 13;
            // 
            // cancelNewRecAppt
            // 
            this.cancelNewRecAppt.Location = new System.Drawing.Point(443, 207);
            this.cancelNewRecAppt.Name = "cancelNewRecAppt";
            this.cancelNewRecAppt.Size = new System.Drawing.Size(75, 23);
            this.cancelNewRecAppt.TabIndex = 14;
            this.cancelNewRecAppt.Text = "Cancel";
            this.cancelNewRecAppt.UseVisualStyleBackColor = true;
            // 
            // saveNewRecAppt
            // 
            this.saveNewRecAppt.Location = new System.Drawing.Point(359, 207);
            this.saveNewRecAppt.Name = "saveNewRecAppt";
            this.saveNewRecAppt.Size = new System.Drawing.Size(75, 23);
            this.saveNewRecAppt.TabIndex = 15;
            this.saveNewRecAppt.Text = "Save";
            this.saveNewRecAppt.UseVisualStyleBackColor = true;
            // 
            // newRecurringApptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 242);
            this.Controls.Add(this.saveNewRecAppt);
            this.Controls.Add(this.cancelNewRecAppt);
            this.Controls.Add(this.howManyRecAppt);
            this.Controls.Add(this.frequencyRecAppt);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.lengthRecAppt);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.startTimeRecAppt);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.dateRecAppt);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.locationRecAppt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.subjectRecAppt);
            this.Controls.Add(this.textBox1);
            this.Name = "newRecurringApptForm";
            this.Text = "newRecurringApptForm";
            this.Load += new System.EventHandler(this.newRecurringApptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox subjectRecurringAppt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox locationRecurringAppt;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox dateRecurringAppt;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox startTimeRecurringAppt;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox lengthRecurringAppt;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox frequencyRecurringAppt;
        private System.Windows.Forms.TextBox howManyRecurringAppt;
        private System.Windows.Forms.Button cancelRecurringAppt;
        private System.Windows.Forms.Button saveRecurringAppt;
    }
}