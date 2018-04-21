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
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@userid1", UserMonitor.pomoc);

                command1.CommandText = "SELECT ManagerID FROM dbo.UserSet where UserID = @userid1";
                label10.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT Address_AddressID FROM dbo.UserSet where UserID = @userid1";
                label11.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT FirstName FROM dbo.UserSet where UserID = @userid1";
                textBox1.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT LastName FROM dbo.UserSet where UserID = @userid1";
                textBox2.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT Username FROM dbo.UserSet where UserID = @userid1";
                textBox3.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT JobTitle FROM dbo.UserSet where UserID = @userid1";
                comboBox1.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT Email FROM dbo.UserSet where UserID = @userid1";
                textBox4.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT PhoneNumber FROM dbo.UserSet where UserID = @userid1";
                maskedTextBox1.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT HireDate FROM dbo.UserSet where UserID = @userid1";
                dateTimePicker1.Text = Convert.ToString(command1.ExecuteScalar());
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String commandText = "UPDATE UserSet SET FirstName=@firstname, LastName=@lastname, JobTitle=@jobtitle, Email=@email, PhoneNumber=@phonenumber, HireDate=@hiredate, ManagerID=@managerid, Address_AddressID=@addressid, Username=@username WHERE UserID=@param";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@param", UserMonitor.pomoc);
                command.Parameters.AddWithValue("@firstname", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@lastname", textBox2.Text.ToString());
                command.Parameters.AddWithValue("@jobtitle", comboBox1.Text.ToString());
                command.Parameters.AddWithValue("@email", textBox4.Text.ToString());
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                command.Parameters.AddWithValue("@phonenumber", Convert.ToInt32(maskedTextBox1.Text.ToString()));
                command.Parameters.AddWithValue("@hiredate", dateTimePicker1.Value.Date);
                command.Parameters.AddWithValue("@managerid", label10.Text.ToString());
                command.Parameters.AddWithValue("@addressid", label11.Text.ToString());
                command.Parameters.AddWithValue("@username", textBox3.Text.ToString());

                command.ExecuteNonQuery();
                conn.Close();
                UserMonitor powrot = new UserMonitor();
                powrot.Show();
                this.Hide();
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
