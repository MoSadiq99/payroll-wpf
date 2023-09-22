using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Form
{
    internal class DbConnection
    {
        SqlConnection con = null;
        public DbConnection() 
        {
            try
            {
                con = new SqlConnection("Data Source=SADIQSE\\SQLEXPRESS;Initial Catalog=grifindo_payroll;Integrated Security=True;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
