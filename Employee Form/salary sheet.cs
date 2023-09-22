using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee_Form
{
    public partial class salary_sheet : Form
    {
        DbConnection dbConnection = null;
#pragma warning disable CS0414 // The field 'salary_sheet.con' is assigned but its value is never used
        SqlConnection con = null;
#pragma warning restore CS0414 // The field 'salary_sheet.con' is assigned but its value is never used

        public salary_sheet()
        {
            dbConnection = new DbConnection();
            InitializeComponent();
            LoadTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadTable()
        {
            SqlConnection con = dbConnection.GetConnection();
            try
            {

                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                String qry = "SELECT * FROM emp_salary";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(comboBoxMonth.SelectedValue);
            string month = comboBoxMonth.Text;
            SqlConnection con = dbConnection.GetConnection();
            try
            {

                int count = 0;
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = "select * from emp_salary WHERE month like '%" + month + "%' ";
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


                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
