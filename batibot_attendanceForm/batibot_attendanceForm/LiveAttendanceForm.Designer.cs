namespace batibot_attendanceForm
{
    partial class LiveAttendanceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdoAttend = new System.Windows.Forms.RadioButton();
            this.rdoSkipped = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.labels = new System.Windows.Forms.Label();
            this.cmbReason = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "[DATA ENTRY PANEL]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(602, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "[LIVE ATTENDANCE MONITOR]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Active Event";
            // 
            // cmbEvent
            // 
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(18, 85);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(165, 24);
            this.cmbEvent.TabIndex = 3;
            this.cmbEvent.Text = "//cmbEvent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Assigned Adviser";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(185, 85);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(172, 24);
            this.cmbTeacher.TabIndex = 5;
            this.cmbTeacher.Text = "//cmbTeacher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Student ID";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(18, 141);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(248, 22);
            this.txtStudentId.TabIndex = 7;
            // 
            // txtStudentName
            // 
            this.txtStudentName.AutoSize = true;
            this.txtStudentName.Location = new System.Drawing.Point(21, 171);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(92, 16);
            this.txtStudentName.TabIndex = 8;
            this.txtStudentName.Text = "Student Name";
            this.txtStudentName.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(18, 190);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 22);
            this.txtName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Course";
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(18, 239);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(141, 24);
            this.cmbCourse.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "//txtStudentId";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "//txtName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "//cmbCourse";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Attendance Status:";
            // 
            // rdoAttend
            // 
            this.rdoAttend.AutoSize = true;
            this.rdoAttend.Location = new System.Drawing.Point(20, 312);
            this.rdoAttend.Name = "rdoAttend";
            this.rdoAttend.Size = new System.Drawing.Size(139, 20);
            this.rdoAttend.TabIndex = 16;
            this.rdoAttend.TabStop = true;
            this.rdoAttend.Text = "Attended [Present]";
            this.rdoAttend.UseVisualStyleBackColor = true;
            // 
            // rdoSkipped
            // 
            this.rdoSkipped.AutoSize = true;
            this.rdoSkipped.Location = new System.Drawing.Point(166, 312);
            this.rdoSkipped.Name = "rdoSkipped";
            this.rdoSkipped.Size = new System.Drawing.Size(132, 20);
            this.rdoSkipped.TabIndex = 17;
            this.rdoSkipped.TabStop = true;
            this.rdoSkipped.Text = "Skipped [Absent]";
            this.rdoSkipped.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "If Absent, Reason:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 384);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(336, 67);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(362, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "//richTextBox1";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(52, 461);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(273, 64);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "RECORD ATTENDANCE";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "//cmbSection";
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(165, 239);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(141, 24);
            this.cmbSection.TabIndex = 24;
            // 
            // labels
            // 
            this.labels.AutoSize = true;
            this.labels.Location = new System.Drawing.Point(171, 219);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(52, 16);
            this.labels.TabIndex = 23;
            this.labels.Text = "Section";
            // 
            // cmbReason
            // 
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new System.Drawing.Point(145, 351);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(210, 24);
            this.cmbReason.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(362, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "//cmbReason";
            // 
            // LiveAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbReason);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.labels);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rdoSkipped);
            this.Controls.Add(this.rdoAttend);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEvent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "LiveAttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Attendance Tracking Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label txtStudentName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdoAttend;
        private System.Windows.Forms.RadioButton rdoSkipped;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label labels;
        private System.Windows.Forms.ComboBox cmbReason;
        private System.Windows.Forms.Label label14;
    }
}