using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Form
{

    public partial class LogIn : Form
    {
        DbConnection dbConnection = null;
#pragma warning disable CS0414 // The field 'LogIn.con' is assigned but its value is never used
        SqlConnection con = null;
#pragma warning restore CS0414 // The field 'LogIn.con' is assigned but its value is never used
        

        public LogIn()
        {
            InitializeComponent();
            //this.MaximumSize = new Size(2160, int.MaxValue);
            dbConnection = new DbConnection();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
             

        private void LogIn_Load(object sender, EventArgs e)
        {

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
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact the Admin, Name= ##, E-mail = #####");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetConnection();
            if (txtUsername.Text == null || txtUsername.Text == "")
            {
                MessageBox.Show("Username required");
                return;
            }

            if (txtPassword.Text == null || txtPassword.Text == "")
            {
                MessageBox.Show("Password required");
                return;
            }
            try
            {


                con.Open();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT id,user_name,userType, password,emp_id FROM user_details where user_name='" + txtUsername.Text + "'";

                cmd.ExecuteNonQuery();
                SqlDataReader dataReader = cmd.ExecuteReader();
                String username = null;
                String passwordHash = null;
                String userType = null;
                int empId = 0;

                while (dataReader.Read())
                {
                    empId = int.Parse(dataReader[4].ToString());
                    username = dataReader[1].ToString();
                    passwordHash = dataReader[3].ToString();
                    userType = dataReader[2].ToString();
                }

                if (username == null)
                {
                    MessageBox.Show("Invalid username password");
                    con.Close();
                    return;
                }

                if (passwordHash != MD5Hash(txtPassword.Text))
                {
                    MessageBox.Show("Invalid username password");
                    con.Close();
                    return;
                }

                con.Close();

                MessageBox.Show("Successfully logged in");

                Home homeWindow = new Home(userType, empId);
                homeWindow.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        
    }
}
