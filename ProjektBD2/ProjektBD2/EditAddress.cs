using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjektBD2
{
    public partial class EditAddress : Form
    {
        private readonly Form parentForm;
        
        //Creats EditAddress process, and connects to the database
        public EditAddress(Form parentFormReference)
        {
            InitializeComponent();
            parentForm = parentFormReference;
            
            string sConnection = Properties.Settings.Default.BD2ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sConnection;
            conn.Open();

            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@addressid1", DBMonitor.pomoc);

                command1.CommandText = "SELECT Street FROM dbo.AddressSet where AddressID = @addressid1";
                textBox1.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT City FROM dbo.AddressSet where AddressID = @addressid1";
                textBox2.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Territory FROM dbo.AddressSet where AddressID = @addressid1";
                comboBox1.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Country FROM dbo.AddressSet where AddressID = @addressid1";
                comboBox2.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT ZipCode FROM dbo.AddressSet where AddressID = @addressid1";
                textBox3.Text = Convert.ToString(command1.ExecuteScalar());
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }
        
        //Updates the Address and returns to the root DBMonitor window
        private void button1_Click(object sender, EventArgs e)
        {
            String commandText = "UPDATE AddressSet SET Street=@street, City=@city, Territory=@territory, Country=@country, ZipCode=@zipcode WHERE AddressID=@param";
            string sConnection = Properties.Settings.Default.BD2ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sConnection;
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@street", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@city", textBox2.Text.ToString());
                command.Parameters.AddWithValue("@territory", comboBox1.Text.ToString());
                command.Parameters.AddWithValue("@country", comboBox2.Text.ToString());
                command.Parameters.AddWithValue("@zipcode", Int32.Parse(textBox3.Text.ToString()));
                command.Parameters.AddWithValue("@param", DBMonitor.pomoc);
                command.ExecuteNonQuery();
                conn.Close();
                
                //DBMonitor powrot = new DBMonitor();
                parentForm.Enabled = true;
                //this.Hide();
                Dispose();
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }
    }
}
