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
    public partial class ManageStudentAttendanceForm : Form
    {
        public ManageStudentAttendanceForm()
        {
            InitializeComponent();
        }

        private void ManageStudentAttendanceForm_Load(object sender, EventArgs e)
        {
            PopulateDropdowns();
            RefreshAttendanceGrid();
            StyleAllGrids();

            this.BeginInvoke(new Action(() => {
                dgvRecentSubmits.ClearSelection();
            }));
        }

        private void PopulateDropdowns()
        {
            try
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmdProg = new SqlCommand("SELECT ProgramName FROM PROGRAMS", conn);
                    using (SqlDataReader drProg = cmdProg.ExecuteReader())
                    {
                        cmbCourse.Items.Clear();
                        while (drProg.Read()) cmbCourse.Items.Add(drProg["ProgramName"].ToString());
                    }

                    SqlCommand cmdSec = new SqlCommand("SELECT SectionName FROM SECTIONS", conn);
                    using (SqlDataReader drSec = cmdSec.ExecuteReader())
                    {
                        cmbSection.Items.Clear();
                        while (drSec.Read()) cmbSection.Items.Add(drSec["SectionName"].ToString());
                    }

                    SqlCommand cmdEvent = new SqlCommand("SELECT EventName FROM EVENTS", conn);
                    using (SqlDataReader drEvent = cmdEvent.ExecuteReader())
                    {
                        cmbEvent.Items.Clear();
                        while (drEvent.Read()) cmbEvent.Items.Add(drEvent["EventName"].ToString());
                    }

                    SqlCommand cmdAdv = new SqlCommand("SELECT AdviserName FROM ADVISERS", conn);
                    using (SqlDataReader drAdv = cmdAdv.ExecuteReader())
                    {
                        cmbTeacher.Items.Clear();
                        while (drAdv.Read()) cmbTeacher.Items.Add(drAdv["AdviserName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dropdown failed to load: " + ex.Message);
            }
        }

        private void RefreshAttendanceGrid()
        {
            try
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            al.LogID AS [Log ID], 
                            al.StudentID AS [Student ID], 
                            s.LastName AS [Last Name], 
                            s.FirstName AS [First Name], 
                            p.ProgramName AS [Program], 
                            sec.SectionName AS [Section], 
                            e.EventName AS [Event], 
                            al.AttendanceStatus AS [Status], 
                            al.LogTimestamp AS [Timestamp]
                        FROM ATTENDANCE_LOGS al
                        JOIN STUDENTS s ON al.StudentID = s.StudentID
                        JOIN PROGRAMS p ON al.ProgramID = p.ProgramID
                        JOIN SECTIONS sec ON al.SectionID = sec.SectionID
                        JOIN EVENTS e ON al.EventID = e.EventID
                        ORDER BY al.LogTimestamp DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRecentSubmits.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Logs table view initialization: " + ex.Message);
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmitAttendance_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(txtStudentId.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                cmbCourse.SelectedIndex == -1 ||
                cmbEvent.SelectedIndex == -1 ||
                cmbSection.SelectedIndex == -1 ||
                cmbTeacher.SelectedIndex == -1
                )
            {
                MessageBox.Show("Please Complete all student info", "Validating Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string attendanceStatus = rdoAttended.Checked ? "Present" : "Absent";

            string query = @"
                DECLARE @ProgID INT = (SELECT TOP 1 ProgramID FROM PROGRAMS WHERE LTRIM(RTRIM(ProgramName)) = @Program);
                DECLARE @SecID INT = (SELECT TOP 1 SectionID FROM SECTIONS WHERE LTRIM(RTRIM(SectionName)) = @Section);
                DECLARE @EvtID INT = (SELECT TOP 1 EventID FROM EVENTS WHERE LTRIM(RTRIM(EventName)) = @Event);
                DECLARE @AdvID VARCHAR(50) = (SELECT TOP 1 AdviserID FROM ADVISERS WHERE LTRIM(RTRIM(AdviserName)) = @Adviser);

                IF NOT EXISTS (SELECT 1 FROM STUDENTS WHERE StudentID = @StudentID)
                BEGIN
                INSERT INTO STUDENTS (StudentID, FirstName, LastName, SectionID)
                VALUES (@StudentID, @FirstName, @LastName, @SecID);
                END
                ELSE
                BEGIN
                UPDATE STUDENTS SET FirstName = @FirstName, LastName = @LastName, SectionID = @SecID WHERE StudentID = @StudentID;
                END

                INSERT INTO ATTENDANCE_LOGS (StudentID, EventID, ProgramID, SectionID, AdviserID, AttendanceStatus, LogTimestamp)
                VALUES (@StudentID, @EvtID, @ProgID, @SecID, @AdvID, @Status, GETDATE());";

            try
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", txtStudentId.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Program", cmbCourse.Text.Trim());
                        cmd.Parameters.AddWithValue("@Section", cmbSection.Text.Trim());
                        cmd.Parameters.AddWithValue("@Event", cmbEvent.Text.Trim());
                        cmd.Parameters.AddWithValue("@Adviser", cmbTeacher.Text.Trim());
                        cmd.Parameters.AddWithValue("@Status", attendanceStatus);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Attendance Successfully logged!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshAttendanceGrid();

                txtStudentId.Clear();
                txtLastName.Clear();
                txtFirstName.Clear();

                dgvRecentSubmits.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save attendance record" + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleAllGrids()
        {
            DataGridView dgv = dgvRecentSubmits;

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

            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            if (dgv.Columns.Contains("Log ID"))
            {
                dgv.Columns["Log ID"].Visible = false;
            }

            dgv.ClearSelection();
        }

        private void ManageStudentAttendanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}