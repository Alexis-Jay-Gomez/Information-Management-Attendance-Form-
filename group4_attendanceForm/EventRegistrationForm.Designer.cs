namespace group4_attendanceForm
{
    partial class ManageEventForm
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
            this.btnBackMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAssignProgram = new System.Windows.Forms.TextBox();
            this.txtAssignSection = new System.Windows.Forms.TextBox();
            this.txtAssignEvent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAssignAdviser = new System.Windows.Forms.TextBox();
            this.txtAdviserId = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvAssignedEvent = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAssignedPrograms = new System.Windows.Forms.DataGridView();
            this.dgvAssignedSections = new System.Windows.Forms.DataGridView();
            this.dgvAssignedAdvisers = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedAdvisers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackMainMenu
            // 
            this.btnBackMainMenu.Location = new System.Drawing.Point(12, 624);
            this.btnBackMainMenu.Name = "btnBackMainMenu";
            this.btnBackMainMenu.Size = new System.Drawing.Size(156, 37);
            this.btnBackMainMenu.TabIndex = 19;
            this.btnBackMainMenu.Text = "Main Menu";
            this.btnBackMainMenu.UseVisualStyleBackColor = true;
            this.btnBackMainMenu.Click += new System.EventHandler(this.btnBackMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Assign Program ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Assign Section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Assign Event";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Assign Adviser";
            // 
            // txtAssignProgram
            // 
            this.txtAssignProgram.Location = new System.Drawing.Point(30, 234);
            this.txtAssignProgram.Name = "txtAssignProgram";
            this.txtAssignProgram.Size = new System.Drawing.Size(179, 22);
            this.txtAssignProgram.TabIndex = 24;
            // 
            // txtAssignSection
            // 
            this.txtAssignSection.Location = new System.Drawing.Point(30, 287);
            this.txtAssignSection.Name = "txtAssignSection";
            this.txtAssignSection.Size = new System.Drawing.Size(179, 22);
            this.txtAssignSection.TabIndex = 25;
            // 
            // txtAssignEvent
            // 
            this.txtAssignEvent.Location = new System.Drawing.Point(30, 353);
            this.txtAssignEvent.Name = "txtAssignEvent";
            this.txtAssignEvent.Size = new System.Drawing.Size(179, 22);
            this.txtAssignEvent.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Adviser ID";
            // 
            // txtAssignAdviser
            // 
            this.txtAssignAdviser.Location = new System.Drawing.Point(238, 234);
            this.txtAssignAdviser.Name = "txtAssignAdviser";
            this.txtAssignAdviser.Size = new System.Drawing.Size(179, 22);
            this.txtAssignAdviser.TabIndex = 28;
            // 
            // txtAdviserId
            // 
            this.txtAdviserId.Location = new System.Drawing.Point(238, 291);
            this.txtAdviserId.Name = "txtAdviserId";
            this.txtAdviserId.Size = new System.Drawing.Size(179, 22);
            this.txtAdviserId.TabIndex = 29;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(238, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(179, 37);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvAssignedEvent
            // 
            this.dgvAssignedEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedEvent.Location = new System.Drawing.Point(460, 43);
            this.dgvAssignedEvent.Name = "dgvAssignedEvent";
            this.dgvAssignedEvent.RowHeadersWidth = 51;
            this.dgvAssignedEvent.RowTemplate.Height = 24;
            this.dgvAssignedEvent.Size = new System.Drawing.Size(762, 149);
            this.dgvAssignedEvent.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Assigned Event";
            // 
            // dgvAssignedPrograms
            // 
            this.dgvAssignedPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedPrograms.Location = new System.Drawing.Point(1004, 239);
            this.dgvAssignedPrograms.Name = "dgvAssignedPrograms";
            this.dgvAssignedPrograms.RowHeadersWidth = 51;
            this.dgvAssignedPrograms.RowTemplate.Height = 24;
            this.dgvAssignedPrograms.Size = new System.Drawing.Size(218, 393);
            this.dgvAssignedPrograms.TabIndex = 35;
            // 
            // dgvAssignedSections
            // 
            this.dgvAssignedSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedSections.Location = new System.Drawing.Point(732, 239);
            this.dgvAssignedSections.Name = "dgvAssignedSections";
            this.dgvAssignedSections.RowHeadersWidth = 51;
            this.dgvAssignedSections.RowTemplate.Height = 24;
            this.dgvAssignedSections.Size = new System.Drawing.Size(266, 393);
            this.dgvAssignedSections.TabIndex = 36;
            // 
            // dgvAssignedAdvisers
            // 
            this.dgvAssignedAdvisers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedAdvisers.Location = new System.Drawing.Point(460, 239);
            this.dgvAssignedAdvisers.Name = "dgvAssignedAdvisers";
            this.dgvAssignedAdvisers.RowHeadersWidth = 51;
            this.dgvAssignedAdvisers.RowTemplate.Height = 24;
            this.dgvAssignedAdvisers.Size = new System.Drawing.Size(266, 393);
            this.dgvAssignedAdvisers.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(729, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Assigned Section";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1001, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Assigned Program ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Assigned Adviser";
            // 
            // ManageEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvAssignedAdvisers);
            this.Controls.Add(this.dgvAssignedSections);
            this.Controls.Add(this.dgvAssignedPrograms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvAssignedEvent);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAdviserId);
            this.Controls.Add(this.txtAssignAdviser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAssignEvent);
            this.Controls.Add(this.txtAssignSection);
            this.Controls.Add(this.txtAssignProgram);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventRegistrationForm";
            this.Load += new System.EventHandler(this.ManageEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedAdvisers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBackMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAssignProgram;
        private System.Windows.Forms.TextBox txtAssignSection;
        private System.Windows.Forms.TextBox txtAssignEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAssignAdviser;
        private System.Windows.Forms.TextBox txtAdviserId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvAssignedEvent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAssignedPrograms;
        private System.Windows.Forms.DataGridView dgvAssignedSections;
        private System.Windows.Forms.DataGridView dgvAssignedAdvisers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}