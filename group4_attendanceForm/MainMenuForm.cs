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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Resize(object sender, EventArgs e)
        {

        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            ManageStudentAttendanceForm liveAttendance = new ManageStudentAttendanceForm();
            this.Hide();
            liveAttendance.ShowDialog();
            this.Show();
        }

        private void btnEventRegistration_Click(object sender, EventArgs e)
        {
            ManageEventForm eventReg = new ManageEventForm();
            this.Hide();
            eventReg.ShowDialog();
            this.Show();
        }

        private void btnAttendanceMonitor_Click(object sender, EventArgs e)
        {
            HistoryMonitorForm historyMonitor = new HistoryMonitorForm();
            this.Hide();
            historyMonitor.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            

            try
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    conn.Open(); 

                    // If it succeeds
                    MessageBox.Show("Database connection established successfully!",
                                    "System Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Database Connection Failed!\n\n" +
                                "Please verify your SQL Server instance is running.\n\n" +
                                "Error Details: " + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadDemoData_Click(object sender, EventArgs e)
        {
            string query = @"
        -- ==========================================================
        -- PHASE 1: SEED BASE LOOKUP TABLES
        -- ==========================================================
        -- 1. Insert Programs
        IF NOT EXISTS (SELECT 1 FROM PROGRAMS WHERE ProgramName = 'BSIT') INSERT INTO PROGRAMS (ProgramName) VALUES ('BSIT');
        IF NOT EXISTS (SELECT 1 FROM PROGRAMS WHERE ProgramName = 'BSTM') INSERT INTO PROGRAMS (ProgramName) VALUES ('BSTM');
        IF NOT EXISTS (SELECT 1 FROM PROGRAMS WHERE ProgramName = 'BSCPE') INSERT INTO PROGRAMS (ProgramName) VALUES ('BSCPE');

        -- Grab Program IDs for Section Mapping
        DECLARE @it INT = (SELECT ProgramID FROM PROGRAMS WHERE ProgramName = 'BSIT');
        DECLARE @tm INT = (SELECT ProgramID FROM PROGRAMS WHERE ProgramName = 'BSTM');
        DECLARE @cpe INT = (SELECT ProgramID FROM PROGRAMS WHERE ProgramName = 'BSCPE');

        -- 2. Insert Sections
        IF NOT EXISTS (SELECT 1 FROM SECTIONS WHERE SectionName = 'BSIT 202 A') INSERT INTO SECTIONS (SectionName, ProgramID) VALUES ('BSIT 202 A', @it);
        IF NOT EXISTS (SELECT 1 FROM SECTIONS WHERE SectionName = 'BSIT 303 A') INSERT INTO SECTIONS (SectionName, ProgramID) VALUES ('BSIT 303 A', @it);
        IF NOT EXISTS (SELECT 1 FROM SECTIONS WHERE SectionName = 'BSTM 202 A') INSERT INTO SECTIONS (SectionName, ProgramID) VALUES ('BSTM 202 A', @tm);
        IF NOT EXISTS (SELECT 1 FROM SECTIONS WHERE SectionName = 'BSTM 303 A') INSERT INTO SECTIONS (SectionName, ProgramID) VALUES ('BSTM 303 A', @tm);
        IF NOT EXISTS (SELECT 1 FROM SECTIONS WHERE SectionName = 'BSCPE 202 A') INSERT INTO SECTIONS (SectionName, ProgramID) VALUES ('BSCPE 202 A', @cpe);
        IF NOT EXISTS (SELECT 1 FROM SECTIONS WHERE SectionName = 'BSCPE 303 A') INSERT INTO SECTIONS (SectionName, ProgramID) VALUES ('BSCPE 303 A', @cpe);

        -- 3. Insert Events
        IF NOT EXISTS (SELECT 1 FROM EVENTS WHERE EventName = 'SportsFest Day 1') INSERT INTO EVENTS (EventName) VALUES ('SportsFest Day 1');
        IF NOT EXISTS (SELECT 1 FROM EVENTS WHERE EventName = 'SportsFest Day 2') INSERT INTO EVENTS (EventName) VALUES ('SportsFest Day 2');
        IF NOT EXISTS (SELECT 1 FROM EVENTS WHERE EventName = 'SportsFest Day 3') INSERT INTO EVENTS (EventName) VALUES ('SportsFest Day 3');

        -- 4. Insert Advisers
        IF NOT EXISTS (SELECT 1 FROM ADVISERS WHERE AdviserID = 'ADV01') INSERT INTO ADVISERS (AdviserID, AdviserName) VALUES ('ADV01', 'Prof. Alexander Wright');
        IF NOT EXISTS (SELECT 1 FROM ADVISERS WHERE AdviserID = 'ADV02') INSERT INTO ADVISERS (AdviserID, AdviserName) VALUES ('ADV02', 'Dr. Maria Santos');
        IF NOT EXISTS (SELECT 1 FROM ADVISERS WHERE AdviserID = 'ADV03') INSERT INTO ADVISERS (AdviserID, AdviserName) VALUES ('ADV03', 'Engr. Juan Dela Cruz');

        -- ==========================================================
        -- PHASE 2: SEED MOCK STUDENTS & TRANSACTION LOGS
        -- ==========================================================
        -- Fetch newly created section IDs
        DECLARE @secIT202 INT = (SELECT SectionID FROM SECTIONS WHERE SectionName = 'BSIT 202 A');
        DECLARE @secIT303 INT = (SELECT SectionID FROM SECTIONS WHERE SectionName = 'BSIT 303 A');
        DECLARE @secTM202 INT = (SELECT SectionID FROM SECTIONS WHERE SectionName = 'BSTM 202 A');
        DECLARE @secTM303 INT = (SELECT SectionID FROM SECTIONS WHERE SectionName = 'BSTM 303 A');
        DECLARE @secCPE202 INT = (SELECT SectionID FROM SECTIONS WHERE SectionName = 'BSCPE 202 A');
        DECLARE @secCPE303 INT = (SELECT SectionID FROM SECTIONS WHERE SectionName = 'BSCPE 303 A');

        DECLARE @ev1 INT = (SELECT EventID FROM EVENTS WHERE EventName = 'SportsFest Day 1');
        DECLARE @ev2 INT = (SELECT EventID FROM EVENTS WHERE EventName = 'SportsFest Day 2');
        DECLARE @ev3 INT = (SELECT EventID FROM EVENTS WHERE EventName = 'SportsFest Day 3');

        -- Insert Sample Students
        IF NOT EXISTS (SELECT 1 FROM STUDENTS WHERE StudentID = 'STU-101') INSERT INTO STUDENTS VALUES ('STU-101', 'John', 'Doe', @secIT202);
        IF NOT EXISTS (SELECT 1 FROM STUDENTS WHERE StudentID = 'STU-102') INSERT INTO STUDENTS VALUES ('STU-102', 'Jane', 'Smith', @secIT202);
        IF NOT EXISTS (SELECT 1 FROM STUDENTS WHERE StudentID = 'STU-103') INSERT INTO STUDENTS VALUES ('STU-103', 'Mark', 'Alonzo', @secIT303);
        IF NOT EXISTS (SELECT 1 FROM STUDENTS WHERE StudentID = 'STU-104') INSERT INTO STUDENTS VALUES ('STU-104', 'Alice', 'Guizon', @secIT303);

        IF NOT EXISTS (SELECT 1 FROM STUDENTS WHERE StudentID = 'STU-201') INSERT INTO STUDENTS VALUES ('STU-201', 'Carlos', 'Reyes', @secTM202);
        IF NOT EXISTS (SELECT 1 FROM STUDENTS WHERE StudentID = 'STU-202') INSERT INTO STUDENTS VALUES ('STU-202', 'Princess', 'Cruz', @secTM202);
        IF NOT EXISTS (SELECT 1 FROM STUDENTS WHERE StudentID = 'STU-203') INSERT INTO STUDENTS VALUES ('STU-203', 'David', 'Aquino', @secTM303);

        IF NOT EXISTS (SELECT 1 FROM STUDENTS WHERE StudentID = 'STU-301') INSERT INTO STUDENTS VALUES ('STU-301', 'Ethan', 'Villanueva', @secCPE202);
        IF NOT EXISTS (SELECT 1 FROM STUDENTS WHERE StudentID = 'STU-302') INSERT INTO STUDENTS VALUES ('STU-302', 'Fiona', 'Mendoza', @secCPE303);

        -- Clear out old demo logs to prevent duplicates if clicked multiple times
        DELETE FROM ATTENDANCE_LOGS WHERE StudentID LIKE 'STU-%';

        -- Day 1 Attendance Logs
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-101', @ev1, @it, @secIT202, 'ADV01', 'Present', DATEADD(day, -2, GETDATE()));
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-102', @ev1, @it, @secIT202, 'ADV01', 'Present', DATEADD(day, -2, GETDATE()));
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-103', @ev1, @it, @secIT303, 'ADV01', 'Absent', DATEADD(day, -2, GETDATE()));
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-201', @ev1, @tm, @secTM202, 'ADV02', 'Present', DATEADD(day, -2, GETDATE()));
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-202', @ev1, @tm, @secTM202, 'ADV02', 'Present', DATEADD(day, -2, GETDATE()));
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-301', @ev1, @cpe, @secCPE202, 'ADV03', 'Absent', DATEADD(day, -2, GETDATE()));

        -- Day 2 Attendance Logs
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-101', @ev2, @it, @secIT202, 'ADV01', 'Present', DATEADD(day, -1, GETDATE()));
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-102', @ev2, @it, @secIT202, 'ADV01', 'Absent', DATEADD(day, -1, GETDATE()));
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-104', @ev2, @it, @secIT303, 'ADV01', 'Present', DATEADD(day, -1, GETDATE()));
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-202', @ev2, @tm, @secTM202, 'ADV02', 'Present', DATEADD(day, -1, GETDATE()));
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-203', @ev2, @tm, @secTM303, 'ADV02', 'Present', DATEADD(day, -1, GETDATE()));
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-301', @ev2, @cpe, @secCPE202, 'ADV03', 'Present', DATEADD(day, -1, GETDATE()));
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-302', @ev2, @cpe, @secCPE303, 'ADV03', 'Present', DATEADD(day, -1, GETDATE()));

        -- Day 3 Attendance Logs
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-101', @ev3, @it, @secIT202, 'ADV01', 'Present', GETDATE());
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-103', @ev3, @it, @secIT303, 'ADV01', 'Present', GETDATE());
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-104', @ev3, @it, @secIT303, 'ADV01', 'Present', GETDATE());
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-201', @ev3, @tm, @secTM202, 'ADV02', 'Absent', GETDATE());
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-203', @ev3, @tm, @secTM303, 'ADV02', 'Present', GETDATE());
        INSERT INTO ATTENDANCE_LOGS VALUES ('STU-302', @ev3, @cpe, @secCPE303, 'ADV03', 'Absent', GETDATE());
    ";

            try
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Demo system successfully initialized! Events, sections, and historical student logs are now fully loaded.", "Demo System Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Initialization Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearEventLogs_Click(object sender, EventArgs e)
        {
           
            string query = "TRUNCATE TABLE ATTENDANCE_LOGS;";

            try
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("All attendance logs have been cleanly wiped out. The system is back to a fresh state", "System Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to clear logs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            string query = @"
        -- 1. Wipe out transaction logs first
        TRUNCATE TABLE ATTENDANCE_LOGS;

        -- 2. Wipe out many-to-many junction tables
        DELETE FROM EVENT_SECTIONS;
        DELETE FROM EVENT_PROGRAMS;
        DELETE FROM EVENT_ADVISERS;

        -- 3. Wipe out student registry
        DELETE FROM STUDENTS;

        -- 4 Wipe out base lookup categories
        DELETE FROM SECTIONS;
        DELETE FROM ADVISERS;
        DELETE FROM EVENTS;
        DELETE FROM PROGRAMS;

        -- Reset the database auto-counters back to 1
        DBCC CHECKIDENT ('PROGRAMS', RESEED, 0);
        DBCC CHECKIDENT ('EVENTS', RESEED, 0);
        DBCC CHECKIDENT ('SECTIONS', RESEED, 0);
    ";

            try
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

               

                MessageBox.Show("System completely nuked! Database is now 100% empty.", "Factory Reset", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reset Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
    
}
