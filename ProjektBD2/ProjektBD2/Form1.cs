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
    public partial class Form1 : Form
    {
        
        public static int loggedUserID;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet.HCOSet' table. You can move, or remove it, as needed.
            this.hCOSetTableAdapter.Fill(this.bD2DataSet.HCOSet);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DBMonitor nowymonitor = new DBMonitor();
            nowymonitor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserMonitor paneluzytkownikow = new UserMonitor();
            paneluzytkownikow.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                String commandText = "SELECT dbo.UserCredentialsSet.Password FROM dbo.UserCredentialsSet join dbo.UserSet on dbo.UserSet.UserID = dbo.UserCredentialsSet.UserID  WHERE dbo.UserSet.Username = @param";
                SqlCommand command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@param", textBox1.Text.ToString());

                if (Convert.ToString(command.ExecuteScalar()) == textBox2.Text.ToString())
                {
                    SqlCommand command1 = new SqlCommand("", conn);
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = "SELECT FirstName FROM dbo.UserSet WHERE Username = @param2";
                    command1.Parameters.AddWithValue("@param2", textBox1.Text.ToString());
                    String fullname = (String)command1.ExecuteScalar();
                    command1.CommandText = "SELECT LastName FROM dbo.UserSet WHERE Username = @param3";
                    command1.Parameters.AddWithValue("@param3", textBox1.Text.ToString());
                    fullname = fullname + " " + Convert.ToString(command1.ExecuteScalar());
                    MessageBox.Show("Login successful. Welcome, " + fullname, "SIGN IN INFO");
                    command1.CommandText = "SELECT UserID FROM dbo.UserSet WHERE Username = @param5";
                    command1.Parameters.AddWithValue("@param5", textBox1.Text.ToString());
                    loggedUserID = Convert.ToInt32(command1.ExecuteScalar());
                    command1.CommandText = "SELECT JobTitle FROM dbo.UserSet WHERE Username = @param4";
                    command1.Parameters.AddWithValue("@param4", textBox1.Text.ToString());
                    switch ((String)command1.ExecuteScalar())
                    {
                        case "SYSTEM ADMIN": { button3.Enabled = true; button2.Enabled = true; button1.Enabled = true; break; }
                        case "LOCAL ADMIN": { button1.Enabled = true; button2.Enabled = false;  button3.Enabled = true; break;  }
                        case "Medical Representative": { button1.Enabled = true; button2.Enabled = true; button3.Enabled = false;  break; }
                        case "Medical Representative Manager": { button1.Enabled = true; button2.Enabled = true; button3.Enabled = false; break; }
                        default: { button2.Enabled = false; button1.Enabled = false; button3.Enabled = false; break; }
                    }
                }
                else
                {
                    MessageBox.Show("FAIL", "fail");
                }
                conn.Close();

            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MeetingModule modulspotkan = new MeetingModule();
            modulspotkan.Show();
        }
    }
}
