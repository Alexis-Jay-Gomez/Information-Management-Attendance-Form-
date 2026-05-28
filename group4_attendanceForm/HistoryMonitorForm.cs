using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group4_attendanceForm
{
    public partial class HistoryMonitorForm : Form
    {
        public HistoryMonitorForm()
        {
            InitializeComponent();
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoryMonitorForm_Load(object sender, EventArgs e)
        {
            PopulateFilterDropDowns();
            LoadHistoryData("All", "All");
        }

        private void PopulateFilterDropDowns()
        {
            try
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmdEvent = new SqlCommand("SELECT EventName FROM EVENTS", conn);
                    SqlDataReader readerEvent = cmdEvent.ExecuteReader();
                    cmbSelectEvent.Items.Clear();
                    cmbSelectEvent.Items.Add("All");
                    while (readerEvent.Read())
                    {
                        cmbSelectEvent.Items.Add(readerEvent["EventName"].ToString());
                    }
                    readerEvent.Close();
                    cmbSelectEvent.SelectedIndex = 0;

                    SqlCommand cmdSection = new SqlCommand("SELECT SectionName FROM SECTIONS", conn);
                    SqlDataReader readerSection = cmdSection.ExecuteReader();
                    cmbSelectSection.Items.Clear();
                    cmbSelectSection.Items.Add("All");
                    while (readerSection.Read())
                    {
                        cmbSelectSection.Items.Add(readerSection["SectionName"].ToString());
                    }
                    readerSection.Close();
                    cmbSelectSection.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Filters: " + ex.Message);
            }
        }

        private void LoadHistoryData(string selectedEvent, string selectedSection)
        {
            string query = @"
            SELECT 
                l.LogID AS [Log ID],
                l.StudentID AS [Student ID],
                s.LastName AS [Last Name],
                s.FirstName AS [First Name],
                p.ProgramName AS [Program],
                sec.SectionName AS [Section],
                e.EventName AS [Event Name],
                adv.AdviserName AS [Assigned Adviser],
                l.AttendanceStatus AS [Status],
                l.LogTimestamp AS [Log Time]
            FROM ATTENDANCE_LOGS l
            INNER JOIN STUDENTS s ON l.StudentID = s.StudentID
            INNER JOIN PROGRAMS p ON l.ProgramID = p.ProgramID
            INNER JOIN SECTIONS sec ON l.SectionID = sec.SectionID
            INNER JOIN EVENTS e ON l.EventID = e.EventID
            INNER JOIN ADVISERS adv ON l.AdviserID = adv.AdviserID
            WHERE 1=1";

            if (selectedEvent != "All" && !string.IsNullOrEmpty(selectedEvent))
            {
                query += " AND e.EventName = @EventName";
            }

            if (selectedSection != "All" && !string.IsNullOrEmpty(selectedSection))
            {
                query += " AND sec.SectionName = @SectionName";
            }

            query += " ORDER BY s.LastName ASC, s.FirstName ASC";

            try
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (selectedEvent != "All" && !string.IsNullOrEmpty(selectedEvent))
                            cmd.Parameters.AddWithValue("@EventName", selectedEvent);

                        if (selectedSection != "All" && !string.IsNullOrEmpty(selectedSection))
                            cmd.Parameters.AddWithValue("@SectionName", selectedSection);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvHistoryRecords.DataSource = dt;

                        int presentCount = dt.AsEnumerable().Count(row => row.Field<string>("Status") == "Present");

                        if (presentCount == 0)
                        {
                            lblParticipated.Visible = false;
                        }
                        else
                        {
                            lblParticipated.Text = $"Participated: {presentCount:D2}";
                            lblParticipated.Visible = true;
                        }

                        StyleHistoryGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pulling logs: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadHistoryData(cmbSelectEvent.SelectedItem.ToString(), cmbSelectSection.SelectedItem.ToString());
        }

        private void StyleHistoryGrid()
        {
            DataGridView dgv = dgvHistoryRecords;

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
    }
}