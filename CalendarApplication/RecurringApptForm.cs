using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class RecurringApptForm : Form
    {
        public RecurringApptForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void newRecurringApptForm_Load(object sender, EventArgs e)
        {

        }

        private TextBox textBox1;
        private TextBox subjectRecAppt;
        private TextBox textbox2;
        private TextBox locationRecAppt;
        private TextBox textBox3;
        private TextBox dateRecAppt;
        private TextBox textBox4;
        private ComboBox startTimeRecAppt;
        private ComboBox lengthRecAppt;
        private ComboBox frequencyRecAppt;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox howManyRecAppt;

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.subjectRecAppt = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.locationRecAppt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateRecAppt = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.startTimeRecAppt = new System.Windows.Forms.ComboBox();
            this.lengthRecAppt = new System.Windows.Forms.ComboBox();
            this.frequencyRecAppt = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.howManyRecAppt = new System.Windows.Forms.TextBox();
            this.cancelRecAppt = new System.Windows.Forms.Button();
            this.saveRecAppt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Subject:";
            // 
            // subjectRecAppt
            // 
            this.subjectRecAppt.Location = new System.Drawing.Point(87, 13);
            this.subjectRecAppt.Name = "subjectRecAppt";
            this.subjectRecAppt.Size = new System.Drawing.Size(393, 20);
            this.subjectRecAppt.TabIndex = 1;
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(13, 40);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(68, 20);
            this.textbox2.TabIndex = 2;
            this.textbox2.Text = "Location:";
            // 
            // locationRecAppt
            // 
            this.locationRecAppt.Location = new System.Drawing.Point(87, 40);
            this.locationRecAppt.Name = "locationRecAppt";
            this.locationRecAppt.Size = new System.Drawing.Size(393, 20);
            this.locationRecAppt.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Date:";
            // 
            // dateRecAppt
            // 
            this.dateRecAppt.Location = new System.Drawing.Point(87, 92);
            this.dateRecAppt.Name = "dateRecAppt";
            this.dateRecAppt.Size = new System.Drawing.Size(68, 20);
            this.dateRecAppt.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(175, 92);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Start Time:";
            // 
            // startTimeRecAppt
            // 
            this.startTimeRecAppt.FormattingEnabled = true;
            this.startTimeRecAppt.Location = new System.Drawing.Point(249, 92);
            this.startTimeRecAppt.Name = "startTimeRecAppt";
            this.startTimeRecAppt.Size = new System.Drawing.Size(68, 21);
            this.startTimeRecAppt.TabIndex = 7;
            // 
            // lengthRecAppt
            // 
            this.lengthRecAppt.FormattingEnabled = true;
            this.lengthRecAppt.Location = new System.Drawing.Point(412, 93);
            this.lengthRecAppt.Name = "lengthRecAppt";
            this.lengthRecAppt.Size = new System.Drawing.Size(68, 21);
            this.lengthRecAppt.TabIndex = 8;
            // 
            // frequencyRecAppt
            // 
            this.frequencyRecAppt.FormattingEnabled = true;
            this.frequencyRecAppt.Location = new System.Drawing.Point(87, 148);
            this.frequencyRecAppt.Name = "frequencyRecAppt";
            this.frequencyRecAppt.Size = new System.Drawing.Size(68, 21);
            this.frequencyRecAppt.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(338, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "Length:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(13, 148);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(68, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "Frequency:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(175, 149);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(96, 20);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "How Many Times?";
            // 
            // howManyRecAppt
            // 
            this.howManyRecAppt.Location = new System.Drawing.Point(277, 149);
            this.howManyRecAppt.Name = "howManyRecAppt";
            this.howManyRecAppt.Size = new System.Drawing.Size(39, 20);
            this.howManyRecAppt.TabIndex = 13;
            // 
            // cancelRecAppt
            // 
            this.cancelRecAppt.Location = new System.Drawing.Point(404, 212);
            this.cancelRecAppt.Name = "cancelRecAppt";
            this.cancelRecAppt.Size = new System.Drawing.Size(75, 23);
            this.cancelRecAppt.TabIndex = 14;
            this.cancelRecAppt.Text = "Cancel";
            this.cancelRecAppt.UseVisualStyleBackColor = true;
            // 
            // saveRecAppt
            // 
            this.saveRecAppt.Location = new System.Drawing.Point(323, 212);
            this.saveRecAppt.Name = "saveRecAppt";
            this.saveRecAppt.Size = new System.Drawing.Size(75, 23);
            this.saveRecAppt.TabIndex = 15;
            this.saveRecAppt.Text = "Save";
            this.saveRecAppt.UseVisualStyleBackColor = true;
            // 
            // RecurringApptForm
            // 
            this.ClientSize = new System.Drawing.Size(539, 275);
            this.Controls.Add(this.saveRecAppt);
            this.Controls.Add(this.cancelRecAppt);
            this.Controls.Add(this.howManyRecAppt);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.frequencyRecAppt);
            this.Controls.Add(this.lengthRecAppt);
            this.Controls.Add(this.startTimeRecAppt);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dateRecAppt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.locationRecAppt);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.subjectRecAppt);
            this.Controls.Add(this.textBox1);
            this.Name = "RecurringApptForm";
            this.Load += new System.EventHandler(this.RecurringApptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button cancelRecAppt;
        private Button saveRecAppt;

        private void RecurringApptForm_Load(object sender, EventArgs e)
        {

        }
    }
}
