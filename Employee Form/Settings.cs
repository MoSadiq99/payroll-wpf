using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee_Form
{
    public partial class Settings : Form
    {
        private DbConnection dbConnection = null;
#pragma warning disable CS0414 // The field 'Settings.con' is assigned but its value is never used
        private SqlConnection con = null;
#pragma warning restore CS0414 // The field 'Settings.con' is assigned but its value is never used

        private int id = 0;

        public Settings()
        {
            InitializeComponent();
            dbConnection = new DbConnection();
            LoadTable();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetConnection();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                //monthCalendarStart.SelectionRange = new SelectionRange(monthCalendarStart.SelectionStart, monthCalendarEnd.SelectionStart);
                DateTime startDate = DateTime.Parse(monthCalendarStart.SelectionStart.ToString());
                DateTime endDate = DateTime.Parse(monthCalendarEnd.SelectionStart.ToString());
                TimeSpan diff = endDate - startDate;
                double days = diff.TotalDays + 1;
                int holidaysMonth = Convert.ToInt32(txtHolidayPerMonth.Text);
                
                txtDateRange.Text = days.ToString();

                cmd.CommandText = "INSERT into settings ( month,startdate,enddate,date_range,leaves_per_mon,leaves_per_year) values " +
                " ( '" + txtMonth.Text + "','" + startDate + "','" + monthCalendarEnd.SelectionStart + "', " + days + ", " + txtHolidayPerMonth.Text + ", " + txtHolidayPerYear.Text + " ) ";

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

        private void LoadTable()
        {
            SqlConnection con = dbConnection.GetConnection();
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                String qry = "SELECT * FROM settings ";

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

                    DateTime startDate = DateTime.Parse(monthCalendarStart.SelectionStart.ToString());
                    DateTime endDate = DateTime.Parse(monthCalendarEnd.SelectionStart.ToString());
                    TimeSpan diff = endDate - startDate;
                    double days = diff.TotalDays + 1;

                    string qry = "";
                    qry = "UPDATE settings SET month= '" + txtMonth.Text + "', startdate='" + startDate + "', enddate='" + endDate + "', date_range=" + days + ", leaves_per_mon=" + txtHolidayPerMonth.Text + ", leaves_per_year=" + txtHolidayPerYear.Text + "  where id = " + this.id + " ";

                    cmd.CommandText = qry;
                    cmd.ExecuteNonQuery();

                    con.Close();
                    this.id = 0;
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
                DateTime startDate = DateTime.Parse(monthCalendarStart.SelectionStart.ToString());
                DateTime endDate = DateTime.Parse(monthCalendarEnd.SelectionStart.ToString());
                TimeSpan diff = endDate - startDate;
                double days = diff.TotalDays;

                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    monthCalendarStart.SelectionStart = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["startdate"].FormattedValue.ToString());
                    monthCalendarEnd.SelectionStart = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["enddate"].FormattedValue.ToString());
                    this.id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
                    txtMonth.Text = dataGridView1.Rows[e.RowIndex].Cells["month"].FormattedValue.ToString();
                    txtDateRange.Text = dataGridView1.Rows[e.RowIndex].Cells["date_range"].FormattedValue.ToString();
                    txtHolidayPerMonth.Text = dataGridView1.Rows[e.RowIndex].Cells["leaves_per_mon"].FormattedValue.ToString();
                    txtHolidayPerYear.Text = dataGridView1.Rows[e.RowIndex].Cells["leaves_per_year"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetConnection();
            try
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "delete from settings where id = " + this.id + " ";

                    cmd.ExecuteNonQuery();
                    con.Close();

                    this.id = 0;

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

        private void resetButton_Click(object sender, EventArgs e)
        {
            txtHolidayPerMonth.Clear();
            txtMonth.Clear();
            txtDateRange.Clear();
            txtHolidayPerYear.Clear();
            monthCalendarStart.SelectionStart = DateTime.Today;
            monthCalendarEnd.SelectionEnd = DateTime.Today;
        }

        private void monthCalendarEnd_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime startDate = DateTime.Parse(monthCalendarStart.SelectionStart.ToString());
            DateTime endDate = DateTime.Parse(monthCalendarEnd.SelectionStart.ToString());
            TimeSpan diff = endDate - startDate;
            double days = diff.TotalDays + 1;


            txtDateRange.Text = days.ToString();
        }

        private void monthCalendarStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime startDate = DateTime.Parse(monthCalendarStart.SelectionStart.ToString());
            DateTime endDate = DateTime.Parse(monthCalendarEnd.SelectionStart.ToString());
            TimeSpan diff = endDate - startDate;
            double days = diff.TotalDays + 1;
            
            //DateTime dateTime = DateTime.Now;
            txtMonth.Text = startDate.ToString("MMMM");

            txtDateRange.Text = days.ToString();
        }
    }
}