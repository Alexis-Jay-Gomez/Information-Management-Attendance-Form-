using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace batibot_attendanceForm
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            LiveAttendanceForm liveAttendance = new LiveAttendanceForm();
            this.Hide();
            liveAttendance.ShowDialog();
            this.Show();
        }

        private void btnManageTeacher_Click(object sender, EventArgs e)
        {
            TeacherRegistrationForm teacherReg = new TeacherRegistrationForm();
            this.Hide();
            teacherReg.ShowDialog();
            this.Show();
        }

        private void btnAttendanceMonitor_Click(object sender, EventArgs e)
        {
            HistoryMonitorForm historyMonitor = new HistoryMonitorForm();
            this.Hide();
            historyMonitor.ShowDialog();
            this.Show();
        }
    }
}
