namespace group4_attendanceForm
{
    partial class EventRegistrationForm
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
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEventDate = new System.Windows.Forms.ComboBox();
            this.txtAssignTeacher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAssignSection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAssignCourse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvAssignedEvent = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvAssignedTeacher = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvAssignedSection = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvAssignedCourse = new System.Windows.Forms.DataGridView();
            this.btnBackMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE EVENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Name:";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(209, 72);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(237, 22);
            this.txtEventName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Event Date:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbEventDate
            // 
            this.cmbEventDate.FormattingEnabled = true;
            this.cmbEventDate.Location = new System.Drawing.Point(209, 184);
            this.cmbEventDate.Name = "cmbEventDate";
            this.cmbEventDate.Size = new System.Drawing.Size(237, 24);
            this.cmbEventDate.TabIndex = 4;
            // 
            // txtAssignTeacher
            // 
            this.txtAssignTeacher.Location = new System.Drawing.Point(209, 100);
            this.txtAssignTeacher.Name = "txtAssignTeacher";
            this.txtAssignTeacher.Size = new System.Drawing.Size(237, 22);
            this.txtAssignTeacher.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Assign Teacher:";
            // 
            // txtAssignSection
            // 
            this.txtAssignSection.Location = new System.Drawing.Point(209, 128);
            this.txtAssignSection.Name = "txtAssignSection";
            this.txtAssignSection.Size = new System.Drawing.Size(237, 22);
            this.txtAssignSection.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Assign Section:";
            // 
            // txtAssignCourse
            // 
            this.txtAssignCourse.Location = new System.Drawing.Point(209, 156);
            this.txtAssignCourse.Name = "txtAssignCourse";
            this.txtAssignCourse.Size = new System.Drawing.Size(237, 22);
            this.txtAssignCourse.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Assign Course:";
            // 
            // dgvAssignedEvent
            // 
            this.dgvAssignedEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedEvent.Location = new System.Drawing.Point(171, 263);
            this.dgvAssignedEvent.Name = "dgvAssignedEvent";
            this.dgvAssignedEvent.RowHeadersWidth = 51;
            this.dgvAssignedEvent.RowTemplate.Height = 24;
            this.dgvAssignedEvent.Size = new System.Drawing.Size(382, 353);
            this.dgvAssignedEvent.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Event";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(610, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Assigned Teacher";
            // 
            // dgvAssignedTeacher
            // 
            this.dgvAssignedTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedTeacher.Location = new System.Drawing.Point(559, 263);
            this.dgvAssignedTeacher.Name = "dgvAssignedTeacher";
            this.dgvAssignedTeacher.RowHeadersWidth = 51;
            this.dgvAssignedTeacher.RowTemplate.Height = 24;
            this.dgvAssignedTeacher.Size = new System.Drawing.Size(240, 353);
            this.dgvAssignedTeacher.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(875, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Assigned Section";
            // 
            // dgvAssignedSection
            // 
            this.dgvAssignedSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedSection.Location = new System.Drawing.Point(805, 263);
            this.dgvAssignedSection.Name = "dgvAssignedSection";
            this.dgvAssignedSection.RowHeadersWidth = 51;
            this.dgvAssignedSection.RowTemplate.Height = 24;
            this.dgvAssignedSection.Size = new System.Drawing.Size(240, 353);
            this.dgvAssignedSection.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(470, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Assigned Course";
            // 
            // dgvAssignedCourse
            // 
            this.dgvAssignedCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedCourse.Location = new System.Drawing.Point(473, 62);
            this.dgvAssignedCourse.Name = "dgvAssignedCourse";
            this.dgvAssignedCourse.RowHeadersWidth = 51;
            this.dgvAssignedCourse.RowTemplate.Height = 24;
            this.dgvAssignedCourse.Size = new System.Drawing.Size(572, 160);
            this.dgvAssignedCourse.TabIndex = 18;
            // 
            // btnBackMainMenu
            // 
            this.btnBackMainMenu.Location = new System.Drawing.Point(12, 627);
            this.btnBackMainMenu.Name = "btnBackMainMenu";
            this.btnBackMainMenu.Size = new System.Drawing.Size(137, 34);
            this.btnBackMainMenu.TabIndex = 19;
            this.btnBackMainMenu.Text = "Back to Main Menu";
            this.btnBackMainMenu.UseVisualStyleBackColor = true;
            this.btnBackMainMenu.Click += new System.EventHandler(this.btnBackMainMenu_Click);
            // 
            // EventRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnBackMainMenu);
            this.Controls.Add(this.dgvAssignedCourse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvAssignedSection);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvAssignedTeacher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvAssignedEvent);
            this.Controls.Add(this.txtAssignCourse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAssignSection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAssignTeacher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEventDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EventRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventRegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEventDate;
        private System.Windows.Forms.TextBox txtAssignTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAssignSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAssignCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvAssignedEvent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvAssignedTeacher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvAssignedSection;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvAssignedCourse;
        private System.Windows.Forms.Button btnBackMainMenu;
    }
}