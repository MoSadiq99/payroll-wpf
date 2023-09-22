using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee_Form
{
    public partial class LeaveManagement : Form
    {
        private DbConnection dbConnection = null;
        private SqlConnection con = null;
        private int leaveId;
#pragma warning disable CS0414 // The field 'LeaveManagement.initDataLoaded' is assigned but its value is never used

#pragma warning restore CS0414 // The field 'LeaveManagement.initDataLoaded' is assigned but its value is never used

        public LeaveManagement()
        {
            InitializeComponent();

            con = new SqlConnection("Data Source=SADIQSE\\SQLEXPRESS;Initial Catalog=grifindo_payroll;Integrated Security=True;");
            dbConnection = new DbConnection();

            loadEmployessToComboBox();
            loadLeaveTypesToComboBox();
            LoadTable();
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
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error" + ex);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void leave_Load(object sender, EventArgs e)
        {
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetConnection();

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                KeyValuePair<int, String> empID = (KeyValuePair<int, String>)employeeComboBox.SelectedItem;
                int empId = int.Parse(empID.Key.ToString());

                KeyValuePair<int, string> leaveTypeID = (KeyValuePair<int, string>)comboBoxLeaveType.SelectedItem;
                string leaveTypeId = leaveTypeID.Key.ToString();

                cmd.CommandText = "INSERT INTO leave ( emp_id,leave_type_id,from_date,to_date) values " +
                " ( " + empId + ",  " + leaveTypeId + ",'" + dateTimePickerStart.Value + "','" + dateTimePickerTo.Value + "' ) ";

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record has been inserted!");

                LoadTable();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error" + ex);
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

                String qry = "SELECT leave.id, leave_type_id, emp_details.name as emp_name, leave.emp_id, leave.from_date,to_date, leave_types.name as leaves_types_name FROM leave LEFT JOIN leave_types ON leave_types.id=leave.leave_type_id LEFT JOIN emp_details ON leave.emp_id=emp_details.employee_id ORDER BY leave.from_date";

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetConnection();
            try
            {
                if (MessageBox.Show("Are you sure to Update?", "Update Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    KeyValuePair<int, string> selectedEntry = (KeyValuePair<int, string>)comboBoxLeaveType.SelectedItem;

                    string qry = "";
                    qry = "UPDATE leave SET leave_type_id= " + selectedEntry.Key + ", from_date='" + dateTimePickerStart.Value + "', to_date='" + dateTimePickerTo.Value + "'  WHERE id = " + this.leaveId + " ";

                    cmd.CommandText = qry;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    this.leaveId = 0;

                    MessageBox.Show("Record has been Updated!");

                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    dateTimePickerStart.Text = dataGridView1.Rows[e.RowIndex].Cells["from_date"].FormattedValue.ToString();
                    dateTimePickerTo.Text = dataGridView1.Rows[e.RowIndex].Cells["to_date"].FormattedValue.ToString();
                    this.leaveId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
                    KeyValuePair<int, string> selectedEntry = new KeyValuePair<int, string>(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["leave_type_id"].FormattedValue.ToString()), dataGridView1.Rows[e.RowIndex].Cells["leaves_types_name"].FormattedValue.ToString());
                    comboBoxLeaveType.SelectedItem = selectedEntry;
                    KeyValuePair<int, string> selectedEmpEntry = new KeyValuePair<int, string>(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["emp_id"].FormattedValue.ToString()), dataGridView1.Rows[e.RowIndex].Cells["emp_name"].FormattedValue.ToString());
                    employeeComboBox.SelectedItem = selectedEmpEntry;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void employeeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetConnection();

            try
            {
                con.Open();

                int count = 0;
                Console.WriteLine(employeeComboBox.SelectedValue);
                string emp = employeeComboBox.Text;

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT leave.id, leave_type_id, emp_details.name as emp_name, leave.emp_id, leave.from_date,to_date, leave_types.name as leaves_types_name FROM leave LEFT JOIN leave_types ON leave_types.id=leave.leave_type_id LEFT JOIN emp_details ON leave.emp_id=emp_details.employee_id WHERE emp_details.name like '%" + emp + "%' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;

                if (count == 0)
                {
                    MessageBox.Show("Record not found!");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetConnection();
            try
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "DELETE FROM leave WHERE id = " + this.leaveId + " ";

                    cmd.ExecuteNonQuery();

                    con.Close();

                    this.leaveId = 0;

                    MessageBox.Show("Record has been deleted!");

                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error" + ex);
            }
        }
    }
}