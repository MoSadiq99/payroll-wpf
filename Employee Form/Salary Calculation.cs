using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee_Form
{
    public partial class Salary_Calculation : Form
    {
        private DbConnection dbConnection = null;
        private string month = null;
        private int dateRange = 0;
        private int holidays = 0;
        private bool initDataLoaded = false;

        public Salary_Calculation()
        {
            InitializeComponent();
            dbConnection = new DbConnection();
            try
#pragma warning disable CS0168 // Variable is declared but never used
            {
                loadEmployessToComboBox();
            }
            catch (Exception ex)
            {
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void loadEmployessToComboBox()
        {
            SqlConnection con = dbConnection.GetConnection();
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
                    employeeComboBox.DisplayMember = "Name";
                    employeeComboBox.ValueMember = "Value";
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

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetConnection();
            try
            {
                Dictionary<int, string> dictionary = new Dictionary<int, string>();

                con.Open();
                SqlDataReader dataReader = null;

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM settings WHERE startdate between '" + dateTimePickerStart.Value.ToString() + "' and '" + dateTimePickerEnd.Value.ToString() + "'";
                cmd.ExecuteNonQuery();

                dataReader = cmd.ExecuteReader();
                if (!dataReader.HasRows)
                {
                    MessageBox.Show("Invalid Date Range!");
                }
                while (dataReader.Read())
                {
                    month = dataReader[1].ToString();
                    dateRange = int.Parse(dataReader[4].ToString());
                    holidays = int.Parse(dataReader[5].ToString());
                }

                txtBoxHolidays.Text = holidays.ToString();
                comboBoxMonth.SelectedItem = month;
                txtDateRange.Text = dateRange.ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error" + ex);
            }
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
                    txtBoxEmpId.Text = dataReader[0].ToString();
                    txtBoxOtRate.Text = dataReader[7].ToString();
                    txtBoxAllowance.Text = dataReader[8].ToString();
                    txtBoxMonthlySalary.Text = dataReader[6].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void txtDateRange_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void txtBoxGovTax_TextChanged(object sender, EventArgs e)
        {
        }

        private void Salary_Calculation_Load(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDateRange.Text == null || txtDateRange.Text == "")
                {
                    MessageBox.Show("Invalid Date Range!");
                    return;
                }

                decimal totalOT = txtBoxOtRate.Text != null && txtBoxOtRate.Text != "" && txtBoxOtHours.Text != null && txtBoxOtHours.Text != "" ? decimal.Parse(txtBoxOtRate.Text) * decimal.Parse(txtBoxOtHours.Text) : 0;

                decimal basePay = totalOT + decimal.Parse(txtBoxMonthlySalary.Text) + decimal.Parse(txtBoxAllowance.Text);

                decimal noPayValue = txtBoxLeaveCount.Text != null && txtBoxLeaveCount.Text != "" ? basePay / decimal.Parse(txtDateRange.Text) * decimal.Parse(txtBoxLeaveCount.Text) : 0;

                decimal taxDeduction = txtBoxGovTax.Text != null && txtBoxGovTax.Text != "" ? (basePay * decimal.Parse(txtBoxGovTax.Text)) / 100 : 0;

                decimal grossPay = basePay - noPayValue - taxDeduction;

                decimal roundedGrossPay = Math.Round(grossPay, 2);
                decimal roundedbasePay = Math.Round(basePay, 2);
                decimal roundedTaxDeduction = Math.Round(taxDeduction, 2);
                decimal roundedNoPay = Math.Round(noPayValue, 2);

                txtBoxTotalOT.Text = totalOT.ToString();
                txtBoxNoPay.Text = roundedNoPay.ToString();
                txtGrossPay.Text = roundedGrossPay.ToString();
                txtBoxBasePay.Text = roundedbasePay.ToString();
                txtBoxTaxDeduction.Text = roundedTaxDeduction.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetConnection();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "INSERT INTO emp_salary ( emp_id, name, month, mon_salary, allowance, ot_rate, ot_hours, holidays_month, leavedays, gov_tax, gross_salary, nopay) values ( " + txtBoxEmpId.Text + ", '" + employeeComboBox.SelectedItem + "', '" + comboBoxMonth.SelectedItem + "', " + txtBoxMonthlySalary.Text + ", " + txtBoxAllowance.Text + ", " + txtBoxOtRate.Text + ", " + txtBoxOtHours.Text + ", " + txtBoxHolidays.Text + ", " + txtBoxLeaveCount.Text + ", " + txtBoxGovTax.Text + ", " + txtGrossPay.Text + ", " + txtBoxNoPay.Text + ")";

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record has been inserted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void ButtonSalarySheet_Click(object sender, EventArgs e)
        {
            salary_sheet salarySheet = new salary_sheet();
            salarySheet.Show();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            txtBoxAllowance.Clear();
            txtBoxOtRate.Clear();
            txtBoxOtHours.Clear();
            txtBoxGovTax.Clear();
            txtBoxBasePay.Clear();
            txtBoxNoPay.Clear();
            txtBoxEmpId.Clear();
            txtBoxMonthlySalary.Clear();
            txtBoxHolidays.Clear();
            txtBoxLeaveCount.Clear();
            txtBoxTaxDeduction.Clear();
            txtGrossPay.Clear();
            txtDateRange.Clear();
            txtBoxTotalOT.Clear();
        }
    }
}