namespace group4_attendanceForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnEventRegistration = new System.Windows.Forms.Button();
            this.btnAttendanceMonitor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(341, 61);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(538, 31);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "STUDENT ATTENDANCE MANAGEMENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 2;
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Location = new System.Drawing.Point(321, 155);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(600, 85);
            this.btnManageStudents.TabIndex = 3;
            this.btnManageStudents.Text = "Manage Student Attendance";
            this.btnManageStudents.UseVisualStyleBackColor = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnEventRegistration
            // 
            this.btnEventRegistration.Location = new System.Drawing.Point(321, 275);
            this.btnEventRegistration.Name = "btnEventRegistration";
            this.btnEventRegistration.Size = new System.Drawing.Size(600, 85);
            this.btnEventRegistration.TabIndex = 4;
            this.btnEventRegistration.Text = "Manage Event";
            this.btnEventRegistration.UseVisualStyleBackColor = true;
            this.btnEventRegistration.Click += new System.EventHandler(this.btnEventRegistration_Click);
            // 
            // btnAttendanceMonitor
            // 
            this.btnAttendanceMonitor.Location = new System.Drawing.Point(321, 402);
            this.btnAttendanceMonitor.Name = "btnAttendanceMonitor";
            this.btnAttendanceMonitor.Size = new System.Drawing.Size(600, 85);
            this.btnAttendanceMonitor.TabIndex = 5;
            this.btnAttendanceMonitor.Text = "History Monitor";
            this.btnAttendanceMonitor.UseVisualStyleBackColor = true;
            this.btnAttendanceMonitor.Click += new System.EventHandler(this.btnAttendanceMonitor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1141, 620);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT APP";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 682);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAttendanceMonitor);
            this.Controls.Add(this.btnEventRegistration);
            this.Controls.Add(this.btnManageStudents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance And Management System v1.0";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.Resize += new System.EventHandler(this.MainMenuForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnEventRegistration;
        private System.Windows.Forms.Button btnAttendanceMonitor;
        private System.Windows.Forms.Button btnExit;
    }
}