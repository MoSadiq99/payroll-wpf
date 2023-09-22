using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee_Form
{
    public partial class Attendance : Form
    {
        private DbConnection dbConnection = null;
        private SqlConnection con = null;
        private bool initDataLoaded = false;

        public Attendance()
        {
            InitializeComponent();

            con = new SqlConnection("Data Source=SADIQSE\\SQLEXPRESS;Initial Catalog=grifindo_payroll;Integrated Security=True;");
            dbConnection = new DbConnection();

            loadEmployessToComboBox();
            LoadTable();
            loadLeaveTypesToComboBox();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void loadEmployessToComboBox()
        {
            try
            {
                Dictionary<int, string> dictionary = new Dictionary<int, string>();

                con.Open();

                SqlDataReader dataReader = null;

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT employee_id,name FROM emp_details";
                cmd.ExecuteNonQuery();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        dictionary.Add(int.Parse(dataReader[0].ToString()), dataReader[1].ToString());
                    }
                    employeeComboBox.DataSource = new BindingSource(dictionary, null);
                    employeeComboBox.DisplayMember = "Value";
                    employeeComboBox.ValueMember = "Key";
                }
                employeeComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                employeeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems; employeeComboBox.SelectedIndex = 0;

                con.Close();
                this.initDataLoaded = true;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error" + ex);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(employeeComboBox.SelectedValue);
            KeyValuePair<int, String> drv = (KeyValuePair<int, String>)employeeComboBox.SelectedItem;

            int empId = int.Parse(drv.Key.ToString());
            if (empId != 0 && initDataLoaded)
            {
                loadSelectedEmployee(empId);
            }
        }

        private void loadSelectedEmployee(int empId)
        {
            try
            {
                Dictionary<int, string> dictionary = new Dictionary<int, string>();
                SqlConnection con = dbConnection.GetConnection();
                con.Open();
                SqlDataReader dataReader = null;

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM emp_details WHERE employee_id=" + empId;
                cmd.ExecuteNonQuery();

                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    txtEmpId.Text = dataReader[0].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void loadLeaveTypesToComboBox()
        {
            SqlConnection con = dbConnection.GetConnection();
            try
            {
                Dictionary<int, string> dictionary = new Dictionary<int, string>();

                con.Open();
                SqlDataReader dataReader = null;

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT id,name FROM leave_types";
                cmd.ExecuteNonQuery();

                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    dictionary.Add(int.Parse(dataReader[0].ToString()), dataReader[1].ToString());
                }
                comboBoxLeaveType.DataSource = new BindingSource(dictionary, null);
                comboBoxLeaveType.DisplayMember = "Value";
                comboBoxLeaveType.ValueMember = "Key";

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadTable()
        {
            SqlConnection con = dbConnection.GetConnection();

            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                String qry = "SELECT emp_attendance.emp_id, emp_details.name as emp_name,  emp_attendance.day_date, emp_attendance.status,in_time,out_time, emp_attendance.leave_type, emp_attendance.month,note FROM emp_attendance LEFT JOIN emp_details ON emp_attendance.emp_id = emp_details.employee_id ORDER BY emp_attendance.day_date";

                cmd.CommandText = qry;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetConnection();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                //int empId = Convert.ToInt32(txtEmpId.Text);

                TimeSpan inTime = timePickerIn.Value.TimeOfDay; // Get the time portion only
                TimeSpan outTime = timePickerOut.Value.TimeOfDay; // Get the time portion only

                cmd.CommandText = "INSERT INTO emp_attendance (emp_id, emp_name, day_date, status, in_time, out_time, leave_type, month, note) VALUES (@EmpId, @EmpName, @DayDate, @Status, @InTime, @OutTime, @LeaveType, @Month, @Note)";

                cmd.Parameters.AddWithValue("@EmpId", txtEmpId.Text);
                cmd.Parameters.AddWithValue("@EmpName", employeeComboBox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@DayDate", datePicker.Value);
                cmd.Parameters.AddWithValue("@Status", comboBoxStatus.SelectedItem.ToString());

                cmd.Parameters.AddWithValue("@InTime", inTime); // Use the TimeSpan value
                cmd.Parameters.AddWithValue("@OutTime", outTime); // Use the TimeSpan value

                cmd.Parameters.AddWithValue("@LeaveType", comboBoxLeaveType.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Month", comboBoxMonth.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record has been inserted!");

                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}