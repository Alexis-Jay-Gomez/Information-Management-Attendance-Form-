namespace group4_attendanceForm
{
    partial class HistoryMonitorForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchByStudent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilterByEvent = new System.Windows.Forms.ComboBox();
            this.cmbFilterByCourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.dgvHistoryRecords = new System.Windows.Forms.DataGridView();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.cmbFilterBySection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Student:";
            // 
            // txtSearchByStudent
            // 
            this.txtSearchByStudent.Location = new System.Drawing.Point(48, 90);
            this.txtSearchByStudent.Name = "txtSearchByStudent";
            this.txtSearchByStudent.Size = new System.Drawing.Size(214, 22);
            this.txtSearchByStudent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter by Event:";
            // 
            // cmbFilterByEvent
            // 
            this.cmbFilterByEvent.FormattingEnabled = true;
            this.cmbFilterByEvent.Location = new System.Drawing.Point(329, 90);
            this.cmbFilterByEvent.Name = "cmbFilterByEvent";
            this.cmbFilterByEvent.Size = new System.Drawing.Size(214, 24);
            this.cmbFilterByEvent.TabIndex = 4;
            // 
            // cmbFilterByCourse
            // 
            this.cmbFilterByCourse.FormattingEnabled = true;
            this.cmbFilterByCourse.Location = new System.Drawing.Point(604, 90);
            this.cmbFilterByCourse.Name = "cmbFilterByCourse";
            this.cmbFilterByCourse.Size = new System.Drawing.Size(214, 24);
            this.cmbFilterByCourse.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Filter by Course:";
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(1109, 86);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(92, 31);
            this.btnResetFilter.TabIndex = 7;
            this.btnResetFilter.Text = "Reset";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            // 
            // dgvHistoryRecords
            // 
            this.dgvHistoryRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryRecords.Location = new System.Drawing.Point(48, 141);
            this.dgvHistoryRecords.Name = "dgvHistoryRecords";
            this.dgvHistoryRecords.RowHeadersWidth = 51;
            this.dgvHistoryRecords.RowTemplate.Height = 24;
            this.dgvHistoryRecords.Size = new System.Drawing.Size(1153, 336);
            this.dgvHistoryRecords.TabIndex = 8;
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.Location = new System.Drawing.Point(13, 620);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(135, 41);
            this.btnReturnToMenu.TabIndex = 9;
            this.btnReturnToMenu.Text = "Back to Main Menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // cmbFilterBySection
            // 
            this.cmbFilterBySection.FormattingEnabled = true;
            this.cmbFilterBySection.Location = new System.Drawing.Point(864, 90);
            this.cmbFilterBySection.Name = "cmbFilterBySection";
            this.cmbFilterBySection.Size = new System.Drawing.Size(214, 24);
            this.cmbFilterBySection.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(861, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter by Section:";
            // 
            // HistoryMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.cmbFilterBySection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.dgvHistoryRecords);
            this.Controls.Add(this.btnResetFilter);
            this.Controls.Add(this.cmbFilterByCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFilterByEvent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchByStudent);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HistoryMonitorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryMonitorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchByStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilterByEvent;
        private System.Windows.Forms.ComboBox cmbFilterByCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.DataGridView dgvHistoryRecords;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.ComboBox cmbFilterBySection;
        private System.Windows.Forms.Label label1;
    }
}