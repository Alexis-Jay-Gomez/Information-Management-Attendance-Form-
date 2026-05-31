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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSelectSection = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvHistoryRecords = new System.Windows.Forms.DataGridView();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.cmbSelectEvent = new System.Windows.Forms.ComboBox();
            this.A = new System.Windows.Forms.Label();
            this.lblParticipated = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Section";
            // 
            // cmbSelectSection
            // 
            this.cmbSelectSection.FormattingEnabled = true;
            this.cmbSelectSection.Location = new System.Drawing.Point(282, 54);
            this.cmbSelectSection.Name = "cmbSelectSection";
            this.cmbSelectSection.Size = new System.Drawing.Size(214, 24);
            this.cmbSelectSection.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(502, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 31);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvHistoryRecords
            // 
            this.dgvHistoryRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryRecords.Location = new System.Drawing.Point(49, 84);
            this.dgvHistoryRecords.Name = "dgvHistoryRecords";
            this.dgvHistoryRecords.RowHeadersWidth = 51;
            this.dgvHistoryRecords.RowTemplate.Height = 24;
            this.dgvHistoryRecords.Size = new System.Drawing.Size(1435, 648);
            this.dgvHistoryRecords.TabIndex = 8;
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.Location = new System.Drawing.Point(49, 736);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(135, 41);
            this.btnReturnToMenu.TabIndex = 9;
            this.btnReturnToMenu.Text = "Main Menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // cmbSelectEvent
            // 
            this.cmbSelectEvent.FormattingEnabled = true;
            this.cmbSelectEvent.Location = new System.Drawing.Point(49, 54);
            this.cmbSelectEvent.Name = "cmbSelectEvent";
            this.cmbSelectEvent.Size = new System.Drawing.Size(214, 24);
            this.cmbSelectEvent.TabIndex = 11;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(46, 35);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(82, 16);
            this.A.TabIndex = 10;
            this.A.Text = "Select Event";
            // 
            // lblParticipated
            // 
            this.lblParticipated.AutoSize = true;
            this.lblParticipated.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipated.Location = new System.Drawing.Point(1275, 736);
            this.lblParticipated.Name = "lblParticipated";
            this.lblParticipated.Size = new System.Drawing.Size(166, 31);
            this.lblParticipated.TabIndex = 13;
            this.lblParticipated.Text = "Participated:";
            // 
            // HistoryMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 862);
            this.Controls.Add(this.lblParticipated);
            this.Controls.Add(this.cmbSelectEvent);
            this.Controls.Add(this.A);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.dgvHistoryRecords);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSelectSection);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "HistoryMonitorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryMonitorForm";
            this.Load += new System.EventHandler(this.HistoryMonitorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSelectSection;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvHistoryRecords;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.ComboBox cmbSelectEvent;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label lblParticipated;
    }
}