namespace batibot_attendanceForm
{
    partial class MainMenuForm
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
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnManageTeacher = new System.Windows.Forms.Button();
            this.btnAttendanceMonitor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT ATTENDANCE MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "What would you like to do?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudents.Location = new System.Drawing.Point(205, 173);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(450, 50);
            this.btnManageStudents.TabIndex = 2;
            this.btnManageStudents.Text = "Manage Student And Live Registration";
            this.btnManageStudents.UseVisualStyleBackColor = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnManageTeacher
            // 
            this.btnManageTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTeacher.Location = new System.Drawing.Point(205, 246);
            this.btnManageTeacher.Name = "btnManageTeacher";
            this.btnManageTeacher.Size = new System.Drawing.Size(450, 50);
            this.btnManageTeacher.TabIndex = 3;
            this.btnManageTeacher.Text = "Manage Teacher Registration";
            this.btnManageTeacher.UseVisualStyleBackColor = true;
            this.btnManageTeacher.Click += new System.EventHandler(this.btnManageTeacher_Click);
            // 
            // btnAttendanceMonitor
            // 
            this.btnAttendanceMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendanceMonitor.Location = new System.Drawing.Point(205, 330);
            this.btnAttendanceMonitor.Name = "btnAttendanceMonitor";
            this.btnAttendanceMonitor.Size = new System.Drawing.Size(450, 50);
            this.btnAttendanceMonitor.TabIndex = 4;
            this.btnAttendanceMonitor.Text = "Previous Attendance Monitor";
            this.btnAttendanceMonitor.UseVisualStyleBackColor = true;
            this.btnAttendanceMonitor.Click += new System.EventHandler(this.btnAttendanceMonitor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(724, 458);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit App";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAttendanceMonitor);
            this.Controls.Add(this.btnManageTeacher);
            this.Controls.Add(this.btnManageStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance And Management System v1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnManageTeacher;
        private System.Windows.Forms.Button btnAttendanceMonitor;
        private System.Windows.Forms.Button btnExit;
    }
}

