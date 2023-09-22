using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Form
{
    public partial class Home : Form
    {
        String userType;
        int empId;
        public Home()
        {
            InitializeComponent();
        }

        public Home(String userType, int empId)
        {
            InitializeComponent();
            this.userType = userType;
            this.empId = empId;   
            if(this.userType!= "Admin")
            {
                btnUserDetails.Visible=false;
                btnSettings.Visible = false;                
                btnSalaryComponets.Visible = false;
            }
            
        }
       
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }
       
        private void btnLeaveTypes_Click(object sender, EventArgs e)
        {
            HideAllForms();
            leavetypes leavetypes = new leavetypes();
            leavetypes.TopLevel = false;
            panelHomeWindow.Controls.Add(leavetypes);

            leavetypes.Show();
        }


        private void btnLeaveManagement_Click(object sender, EventArgs e)
        {
            HideAllForms();
            LeaveManagement leaveManagement = new LeaveManagement();
            leaveManagement.TopLevel = false;
            panelHomeWindow.Controls.Add(leaveManagement);
            leaveManagement.Show();
        }

        private void btnUserDetails_Click(object sender, EventArgs e)
        {
            HideAllForms();
            user_LogIn user_LogIn = new user_LogIn();
            user_LogIn.TopLevel = false;
            panelHomeWindow.Controls.Add(user_LogIn);
            user_LogIn.Show();
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            HideAllForms();
            Settings settings = new Settings();
            settings.TopLevel = false;
            panelHomeWindow.Controls.Add(settings);
            settings.Show();
        }

        private void btnSalaryComponets_Click(object sender, EventArgs e)
        {
            HideAllForms();

            Salary_Calculation salary_Calculation = new Salary_Calculation();
            salary_Calculation.Show();
        }

        private void btnEmployeesComponent_Click(object sender, EventArgs e)
        {
            HideAllForms();
            EmployeeComponetsNew employeeComponetsNew = new EmployeeComponetsNew(userType);
            employeeComponetsNew.TopLevel = false;
            panelHomeWindow.Controls.Add(employeeComponetsNew);
            employeeComponetsNew.Show();
        }

        private void HideAllForms()
        {
            foreach(Form form in panelHomeWindow.Controls)
            {
                form.Hide();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            HideAllForms();
            Attendance attendance = new Attendance();          
            attendance.TopLevel = false;
            panelHomeWindow.Controls.Add(attendance);
            attendance.Show();
        }
    }
}
