using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjektBD2
{
    public partial class NewUser : Form
    {
        public static Int32 ManagerID;
        public static Int32 AddressID;
        public static String username;
        public NewUser()
        {
            InitializeComponent();
            label10.Text = Convert.ToString(ManagerID);
            label11.Text = Convert.ToString(AddressID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showManagers pokazmanagerow = new showManagers();
            pokazmanagerow.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            showAddresses pokazadresy = new showAddresses();
            pokazadresy.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String commandText = "INSERT INTO UserSet VALUES(@firstname, @lastname, @jobtitle, @email, @phonenumber, @hiredate, @managerid, @addressid, @username)";
            String commandText2 = "select count(*) from UserSet where Username = @param2";

            string sConnection = Properties.Settings.Default.BD2ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sConnection;
            conn.Open();
            try
            {
                SqlCommand command2 = new SqlCommand(commandText2, conn);
                command2.Parameters.AddWithValue("@param2", textBox3.Text.ToString());
                if (Convert.ToInt32(command2.ExecuteScalar()) > 0)
                {
                    SqlCommand command = new SqlCommand(commandText, conn);
                    command.Parameters.AddWithValue("@firstname", textBox1.Text.ToString());
                    command.Parameters.AddWithValue("@lastname", textBox2.Text.ToString());
                    command.Parameters.AddWithValue("jobtitle", comboBox1.Text.ToString());
                    command.Parameters.AddWithValue("@email", textBox4.Text.ToString());
                    maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    command.Parameters.AddWithValue("@phonenumber", Convert.ToInt32(maskedTextBox1.Text.ToString()));
                    command.Parameters.Add("@hiredate", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    command.Parameters.AddWithValue("@managerid", label10.Text.ToString());
                    command.Parameters.AddWithValue("@addressid", label11.Text.ToString());
                    String pomoc = textBox1.Text.ToString().ToLower() + "." + Convert.ToString((Convert.ToInt32(command2.ExecuteScalar())+1)) + "." + textBox2.Text.ToString().ToLower();
                    command.Parameters.AddWithValue("@username", pomoc);
                    username = pomoc;
                    command.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand command = new SqlCommand(commandText, conn);
                    command.Parameters.AddWithValue("@firstname", textBox1.Text.ToString());
                    command.Parameters.AddWithValue("@lastname", textBox2.Text.ToString());
                    command.Parameters.AddWithValue("jobtitle", comboBox1.Text.ToString());
                    command.Parameters.AddWithValue("@email", textBox4.Text.ToString());
                    maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    command.Parameters.AddWithValue("@phonenumber", Convert.ToInt32(maskedTextBox1.Text.ToString()));
                    command.Parameters.Add("@hiredate", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    command.Parameters.AddWithValue("@managerid", label10.Text.ToString());
                    command.Parameters.AddWithValue("@addressid", label11.Text.ToString());
                    command.Parameters.AddWithValue("@username", textBox1.Text.ToString().ToLower() + ".x." + textBox2.Text.ToString().ToLower());
                    username = textBox1.Text.ToString().ToLower() + ".x." + textBox2.Text.ToString().ToLower();
                    command.ExecuteNonQuery();
                }
                
                setPassword ustawhaslo = new setPassword();
                ustawhaslo.Show();
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

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text.ToString().ToLower() + ".x." + textBox2.Text.ToString().ToLower();
        }
    }
}
