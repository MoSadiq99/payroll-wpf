using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee_Form
{
    public partial class EmployeeComponetsNew : Form
    {
        private DbConnection dbConnection = null;
        private SqlConnection con = null;

        public EmployeeComponetsNew()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=SADIQSE\\SQLEXPRESS;Initial Catalog=grifindo_payroll;Integrated Security=True;");
            dbConnection = new DbConnection();
        }

        public EmployeeComponetsNew(String userType)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=SADIQSE\\SQLEXPRESS;Initial Catalog=grifindo_payroll;Integrated Security=True;");
            dbConnection = new DbConnection();

            if (userType != "Admin")
            {
                insetEmployee.Visible = false;
                updateButton.Visible = false;
                deleteButton.Visible = false;
            }
            LoadTable();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void EmployeeComponetsNew_Load(object sender, EventArgs e)
        {
        }

        private void insetEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string Name = employeeName.Text;
                string Address = address.Text;
                string Emptype = empType.Text;
                string Gender = gender.Text;
                int Age = Convert.ToInt32(age.Text);
                float OtRate = float.Parse(otRate.Text);
                int PhoneNo = Convert.ToInt32(phoneNo.Text);
                float Salary = float.Parse(moSalary.Text);
                float Allowance = float.Parse(allowance.Text);

                cmd.CommandText = "INSERT into emp_details ( emptype,name,address,gender,age,salary,ot_rate,allowance,phoneno) values " +
                    " ('" + Emptype + "', '" + Name + "', '" + Address + "', '" + Gender + "', " + Age + ", " + Salary + ", " + OtRate + ", " + Allowance + ", " + PhoneNo + ")";

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been inserted!");

                id.Clear();
                employeeName.Clear();
                age.Clear();
                empType.Clear();
                address.Clear();
                gender.Clear();
                moSalary.Clear();
                otRate.Clear();
                allowance.Clear();
                phoneNo.Clear();

                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        // Button Update Command

        private void updateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to Update?", "Update Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    int Id = Convert.ToInt32(id.Text);
                    string Name = employeeName.Text;
                    string Address = address.Text;
                    string Emptype = empType.Text;
                    string Gender = gender.Text;
                    int Age = Convert.ToInt32(age.Text);
                    float OtRate = float.Parse(otRate.Text);
                    int PhoneNo = Convert.ToInt32(phoneNo.Text);
                    float Salary = float.Parse(moSalary.Text);
                    float Allowance = float.Parse(allowance.Text);

                    string qry = "UPDATE emp_details SET EmpType= '" + Emptype + "', name='" + Name + "', address='" + Address + "', gender='" + Gender + "', age=" + Age + ", phoneno=" + PhoneNo + ", salary=" + Salary + ", allowance=" + Allowance + " where employee_id = " + Id + " ";

                    cmd.CommandText = qry;
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Record has been Updated!");

                    id.Clear();
                    employeeName.Clear();
                    age.Clear();
                    empType.Clear();
                    address.Clear();
                    gender.Clear();
                    moSalary.Clear();
                    otRate.Clear();
                    allowance.Clear();
                    phoneNo.Clear();
                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error" + ex);
            }
        }

        //  Load Table Command

        private void LoadTable()
        {
            try
            {
                SqlConnection con = dbConnection.GetConnection();
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM emp_details";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        //   Load Table command

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                employeeName.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                id.Text = dataGridView1.Rows[e.RowIndex].Cells["employee_id"].FormattedValue.ToString();
                empType.Text = dataGridView1.Rows[e.RowIndex].Cells["emptype"].FormattedValue.ToString();
                address.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
                gender.Text = dataGridView1.Rows[e.RowIndex].Cells["gender"].FormattedValue.ToString();
                age.Text = dataGridView1.Rows[e.RowIndex].Cells["age"].FormattedValue.ToString();
                otRate.Text = dataGridView1.Rows[e.RowIndex].Cells["ot_rate"].FormattedValue.ToString();
                allowance.Text = dataGridView1.Rows[e.RowIndex].Cells["allowance"].FormattedValue.ToString();
                phoneNo.Text = dataGridView1.Rows[e.RowIndex].Cells["phoneno"].FormattedValue.ToString();
                moSalary.Text = dataGridView1.Rows[e.RowIndex].Cells["salary"].FormattedValue.ToString();
            }
        }

        // Delete Record Command

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    int Id = Convert.ToInt32(id.Text);

                    cmd.CommandText = "delete from emp_details where employee_id = " + Id + " ";

                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Record has been deleted!");
                    id.Clear();
                    employeeName.Clear();
                    age.Clear();
                    empType.Clear();
                    address.Clear();
                    gender.Clear();
                    moSalary.Clear();
                    otRate.Clear();
                    allowance.Clear();
                    phoneNo.Clear();
                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void textBoxSearchEmp_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Button Reset  command

        private void resetButton_Click(object sender, EventArgs e)
        {
            id.Clear();
            employeeName.Clear();
            age.Clear();
            empType.Clear();
            address.Clear();
            gender.Clear();
            moSalary.Clear();
            otRate.Clear();
            allowance.Clear();
            phoneNo.Clear();
        }

        // Button Reset Command END

        // Button Search Command

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string Name = textBoxSearchEmp.Text;
                cmd.CommandText = "select * from emp_details where  name like  '%" + Name + "%' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;

                con.Close();

                if (count == 0)
                {
                    MessageBox.Show("Record not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }
    }
}