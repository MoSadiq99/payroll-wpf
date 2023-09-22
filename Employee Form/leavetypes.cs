using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_Form
{
    public partial class leavetypes : Form
    {
        DbConnection dbConnection = null;
#pragma warning disable CS0414 // The field 'leavetypes.con' is assigned but its value is never used
        SqlConnection con = null;
#pragma warning restore CS0414 // The field 'leavetypes.con' is assigned but its value is never used
        int leaveTypeId;

        public leavetypes()
        {
            InitializeComponent();
            dbConnection = new DbConnection();        
            LoadTable();
        }

        private void leavetypes_Load(object sender, EventArgs e)
        {

        }
        private void LoadTable()
        {
            SqlConnection con = dbConnection.GetConnection();

            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM leave_types";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridLeaveTypes.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error" + ex);
            }

        }

        private void insetButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetConnection();

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;


                string Name = txtLeaveType.Text;
                int Count = Convert.ToInt32(txtCount.Text);
                string Code = txtLeaveCode.Text;

                cmd.CommandText = "INSERT into leave_types (name, code, count) values " +
                    " ('" + Name + "', '" + Code + "', " + Count + ")";

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been inserted!");

                txtLeaveType.Clear();
                txtLeaveCode.Clear();
                txtCount.Clear();
                LoadTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetConnection();

            try
            {
                if (MessageBox.Show("Are you sure to Update?", "Update Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    
                    string Name = txtLeaveType.Text;
                    int Count = Convert.ToInt32(txtCount.Text);
                    string Code = txtLeaveCode.Text;



                    string qry = "";
                    qry = "UPDATE leave_types SET name= '" + Name + "', code='" + Code + "', count=" + Count + " WHERE id = " + this.leaveTypeId + " ";


                    cmd.CommandText = qry;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    this.leaveTypeId = 0;

                    MessageBox.Show("Record has been Updated!");


                    txtLeaveType.Clear();
                    txtLeaveCode.Clear();
                    txtCount.Clear();

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
            txtLeaveType.Clear();
            txtLeaveCode.Clear();
            txtCount.Clear();

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

                    string Name = txtLeaveType.Text;

                    cmd.CommandText = "delete from leave_types where name = " + Name + " ";


                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Record has been deleted!");
                    txtLeaveType.Clear();
                    txtLeaveCode.Clear();
                    txtCount.Clear();
                    LoadTable();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridLeaveTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridLeaveTypes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                    dataGridLeaveTypes.CurrentRow.Selected = true;

                    this.leaveTypeId = int.Parse(dataGridLeaveTypes.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
                    txtLeaveType.Text = dataGridLeaveTypes.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                    txtCount.Text = dataGridLeaveTypes.Rows[e.RowIndex].Cells["count"].FormattedValue.ToString();
                    txtLeaveCode.Text = dataGridLeaveTypes.Rows[e.RowIndex].Cells["code"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }
    }
}
