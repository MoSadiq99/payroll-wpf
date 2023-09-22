using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_Form
{
    public partial class user_LogIn : Form
    {
        DbConnection dbConnection = null;
#pragma warning disable CS0414 // The field 'user_LogIn.con' is assigned but its value is never used
        SqlConnection con = null;
#pragma warning restore CS0414 // The field 'user_LogIn.con' is assigned but its value is never used
        int userId ;

        public user_LogIn()
        {
            InitializeComponent();
            comboBoxUserType.SelectedIndex = 0;
            dbConnection = new DbConnection();
            loadEmployeesToComboBox();
            LoadTable();
        }

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadEmployeesToComboBox()
        {
            SqlConnection con = dbConnection.GetConnection();
#pragma warning disable CS0168 // Variable is declared but never used
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
                
                while (dataReader.Read())
                {
                    dictionary.Add(int.Parse(dataReader[0].ToString()), dataReader[1].ToString());
                }
                employeeComboBox.DataSource = new BindingSource(dictionary, null);
                employeeComboBox.DisplayMember = "Name";
                employeeComboBox.ValueMember = "Value";

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                //MessageBox.Show("Error" + ex);
            }
#pragma warning restore CS0168 // Variable is declared but never used

        }
        /*
         * 
         * 
         * 
         */
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetConnection();
            try
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                KeyValuePair<int, string> selectedEntry = (KeyValuePair<int, string>)employeeComboBox.SelectedItem;

                cmd.CommandText = "INSERT into user_details ( user_name,userType,emp_id,password) values " +
                " ( '" + txtUsername.Text + "', '" + comboBoxUserType.SelectedItem + "', " + selectedEntry.Key + ",'" + MD5Hash(txtPassword.Text)+ "' ) ";
                
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

        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        private void user_LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

                cmd.CommandText = "SELECT * FROM user_details";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                userDataGridView.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error" + ex);
            }
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (userDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    userDataGridView.CurrentRow.Selected = true;
                    comboBoxUserType.SelectedItem = userDataGridView.Rows[e.RowIndex].Cells["usertype"].FormattedValue.ToString();
                    txtUsername.Text = userDataGridView.Rows[e.RowIndex].Cells["user_name"].FormattedValue.ToString();
                    this.userId = int.Parse(userDataGridView.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
                    KeyValuePair<int, string> selectedEntry = new KeyValuePair<int, string>(int.Parse(userDataGridView.Rows[e.RowIndex].Cells["emp_id"].FormattedValue.ToString()), "ww");
                    employeeComboBox.SelectedItem = selectedEntry;
                }

            }catch (Exception ex)
            {
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

                    int Id = this.userId;
                    string userName = txtUsername.Text;
                    string userType = comboBoxUserType.SelectedItem.ToString();
                    KeyValuePair<int, string> selectedEntry = (KeyValuePair<int, string>)employeeComboBox.SelectedItem;
                    string password=txtPassword.Text;
                    
                    string qry = "";

                    if (password!=null && password != "")
                    {
                        qry = "UPDATE user_details SET user_name= '" + userName + "', usertype='" + userType + "', emp_id="+selectedEntry.Key+"  where id = " + this.userId + " ";

                    }
                    else
                    {
                        qry = "UPDATE user_details SET user_name= '" + userName + "', usertype='" + userType + "', emp_id=" + selectedEntry.Key + ", password='"+MD5Hash(password)+"'  where id = " + this.userId + " ";
                    }                    

                    cmd.CommandText = qry;
                    cmd.ExecuteNonQuery();

                    con.Close();
                    this.userId = 0;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
   
}
