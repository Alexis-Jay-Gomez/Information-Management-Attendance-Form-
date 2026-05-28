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


    }
}
