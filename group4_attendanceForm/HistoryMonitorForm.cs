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

                    //Event Drop Down
                    SqlCommand cmdEvent = new SqlCommand("SELECT EventName FROM EVENTS", conn);
                    SqlDataReader readerEvent = cmdEvent.ExecuteReader();
                    cmbSelectEvent.Items.Clear();
                    cmbSelectEvent.Items.Add("All");
                    while (readerEvent.Read())
                    {
                        cmbSelectEvent.Items.Add(readerEvent["EventName"].ToString());
                    }
                    readerEvent.Close();
                    cmbSelectEvent.SelectedIndex = 0;// naka all

                    //Section Drop
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

            StyleAllGrids();
            
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

                        lblParticipated.Text = $"Participated: {presentCount:D2}";

                  
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

        private void StyleAllGrids()
        {
            foreach (Control c in this.Controls)
            {
                if (c is DataGridView dgv)
                {
                    // 1. Structural Polish
                    dgv.BackgroundColor = Color.White;       // Gets rid of the heavy gray base space
                    dgv.RowHeadersVisible = false;           // Removes the empty margin column on the far left
                    dgv.AllowUserToAddRows = false;          // Hides the blank manual entry row at the bottom
                    dgv.BorderStyle = BorderStyle.None;

                    // 2. Proportional Scaling
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Perfect edge-to-edge layout

                    // 3. Grid Lines & Focus Configurations
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgv.GridColor = Color.FromArgb(240, 240, 240); // Soft clean row split lines
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Highlighting focuses the whole row at once
                    dgv.MultiSelect = false;

                    // 4. Custom Header Theme — Midnight Blue Configuration
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 112); // Midnight Blue
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;                 // Clean white readable text
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                    dgv.ColumnHeadersHeight = 35; // Adds professional spacing padding around headers

                    // 5. Data Cell Font Configurations
                    dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
                    dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 230, 245); // Light navy highlight tint on item click
                    dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(25, 25, 112);   // Dark text contrast matching the header

                    // 6. Target Primary Key Hider 
                    // Automatically locates the database identifier and drops it from the user layout view
                    if (dgv.Columns.Contains("Log ID"))
                    {
                        dgv.Columns["Log ID"].Visible = false;
                    }
                }
            }
        }
    }
}
