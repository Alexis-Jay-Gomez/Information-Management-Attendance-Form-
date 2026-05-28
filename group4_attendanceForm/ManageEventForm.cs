using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace group4_attendanceForm
{
    public partial class ManageEventForm : Form
    {
        public ManageEventForm()
        {
            InitializeComponent();
        }

        private void btnBackMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageEventForm_Load(object sender, EventArgs e)
        {
            RefreshAllGrids();
        }

        private void StyleAllGrids()
        {
            foreach (Control c in this.Controls)
            {
                if (c is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.White;
                    dgv.RowHeadersVisible = false;
                    dgv.AllowUserToAddRows = false;
                    dgv.BorderStyle = BorderStyle.None;

                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgv.GridColor = Color.FromArgb(240, 240, 240);
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv.MultiSelect = false;

                    dgv.EnableHeadersVisualStyles = false;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 112);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                    dgv.ColumnHeadersHeight = 35;

                    dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
                    dgv.DefaultCellStyle.SelectionBackColor = Color.White;
                    dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

                    if (dgv.Columns.Contains("ID"))
                    {
                        dgv.Columns["ID"].Visible = false;
                    }

                    if (dgv.Columns.Contains("Adviser ID"))
                    {
                        dgv.Columns["Adviser ID"].Visible = false;
                    }

                    dgv.ClearSelection();
                }
            }
        }

        private void RefreshAllGrids()
        {
            try
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter daEvent = new SqlDataAdapter("SELECT EventID AS [ID], EventName AS [Event Name] FROM EVENTS", conn);
                    DataTable dtEvent = new DataTable();
                    daEvent.Fill(dtEvent);
                    dgvAssignedEvent.DataSource = dtEvent;

                    SqlDataAdapter daProg = new SqlDataAdapter("SELECT ProgramID AS [ID], ProgramName AS [Program] FROM PROGRAMS", conn);
                    DataTable dtProg = new DataTable();
                    daProg.Fill(dtProg);
                    dgvAssignedPrograms.DataSource = dtProg;

                    SqlDataAdapter daSec = new SqlDataAdapter("SELECT SectionID AS [ID], SectionName AS [Section Name] FROM SECTIONS", conn);
                    DataTable dtSec = new DataTable();
                    daSec.Fill(dtSec);
                    dgvAssignedSections.DataSource = dtSec;

                    SqlDataAdapter daAdv = new SqlDataAdapter("SELECT AdviserID AS [Adviser ID], AdviserName AS [Adviser Name] FROM ADVISERS", conn);
                    DataTable dtAdv = new DataTable();
                    daAdv.Fill(dtAdv);
                    dgvAssignedAdvisers.DataSource = dtAdv;
                }

                StyleAllGrids();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Grids initialization: " + ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(txtAssignEvent.Text) ||
                string.IsNullOrWhiteSpace(txtAssignProgram.Text) ||
                string.IsNullOrWhiteSpace(txtAssignSection.Text) ||
                string.IsNullOrWhiteSpace(txtAssignAdviser.Text) ||
                string.IsNullOrWhiteSpace(txtAdviserId.Text)
               )
            {
                MessageBox.Show("Please fill out all configurations before submitting.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string queryBatch = @"
                DECLARE @TargetEventID INT;
                IF NOT EXISTS (SELECT 1 FROM EVENTS WHERE EventName = @EventName)
                INSERT INTO EVENTS (EventName) VALUES (@EventName);
                SELECT @TargetEventID = EventID FROM EVENTS WHERE EventName = @EventName;

                DECLARE @TargetProgramID INT;
                IF NOT EXISTS (SELECT 1 FROM PROGRAMS WHERE ProgramName = @ProgName)
                INSERT INTO PROGRAMS (ProgramName) VALUES (@ProgName);
                SELECT @TargetProgramID = ProgramID FROM PROGRAMS WHERE ProgramName = @ProgName;

                DECLARE @TargetSectionID INT;
                IF NOT EXISTS (SELECT 1 FROM SECTIONS WHERE SectionName = @SecName AND ProgramID = @TargetProgramID)
                INSERT INTO SECTIONS (SectionName, ProgramID) VALUES (@SecName, @TargetProgramID);
                SELECT @TargetSectionID = SectionID FROM SECTIONS WHERE SectionName = @SecName AND ProgramID = @TargetProgramID;

                IF NOT EXISTS (SELECT 1 FROM ADVISERS WHERE AdviserID = @AdvID)
                INSERT INTO ADVISERS (AdviserID, AdviserName) VALUES (@AdvID, @AdvName);

                IF NOT EXISTS (SELECT 1 FROM EVENT_PROGRAMS WHERE EventID = @TargetEventID AND ProgramID = @TargetProgramID)
                INSERT INTO EVENT_PROGRAMS (EventID, ProgramID) VALUES (@TargetEventID, @TargetProgramID);

                IF NOT EXISTS (SELECT 1 FROM EVENT_SECTIONS WHERE EventID = @TargetEventID AND SectionID = @TargetSectionID)
                INSERT INTO EVENT_SECTIONS (EventID, SectionID) VALUES (@TargetEventID, @TargetSectionID);

                IF NOT EXISTS (SELECT 1 FROM EVENT_ADVISERS WHERE EventID = @TargetEventID AND AdviserID = @AdvID)
                INSERT INTO EVENT_ADVISERS (EventID, AdviserID) VALUES (@TargetEventID, @AdvID);
                ";

            try
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(queryBatch, conn))
                    {
                        cmd.Parameters.AddWithValue("@EventName", txtAssignEvent.Text.Trim());
                        cmd.Parameters.AddWithValue("@ProgName", txtAssignProgram.Text.Trim());
                        cmd.Parameters.AddWithValue("@SecName", txtAssignSection.Text.Trim());
                        cmd.Parameters.AddWithValue("@AdvName", txtAssignAdviser.Text.Trim());
                        cmd.Parameters.AddWithValue("@AdvID", txtAdviserId.Text.Trim());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Configuration successfully saved to the database pools!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshAllGrids();

                txtAssignEvent.Clear();
                txtAssignProgram.Clear();
                txtAssignSection.Clear();
                txtAssignAdviser.Clear();
                txtAdviserId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Execution Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAssignedCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        #region Accidentally na click
        private void label3_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
        #endregion
    }
}