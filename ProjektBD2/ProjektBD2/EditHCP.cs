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
    public partial class EditHCP : Form
    {
        public EditHCP()
        {
            InitializeComponent();
            this.hCOSetTableAdapter.Fill(this.bD2DataSet.HCOSet);
            textBox1.Text = "test";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@hcpid1", DBMonitor.pomoc);

                command1.CommandText = "SELECT FirstName FROM dbo.HCPSet where HCPID = @hcpid1";
                textBox1.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT MiddleName FROM dbo.HCPSet where HCPID = @hcpid1";
                textBox2.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT LastName FROM dbo.HCPSet where HCPID = @hcpid1";
                textBox3.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Gender FROM dbo.HCPSet where HCPID = @hcpid1";
                comboBox1.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT AcademicTitle FROM dbo.HCPSet where HCPID = @hcpid1";
                comboBox2.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Specialty FROM dbo.HCPSet where HCPID = @hcpid1";
                comboBox3.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Birthdate FROM dbo.HCPSet where HCPID = @hcpid1";
                dateTimePicker1.Value = (DateTime)command1.ExecuteScalar();

                command1.CommandText = "SELECT KOL FROM dbo.HCPSet where HCPID = @hcpid1";
                if ((Boolean)command1.ExecuteScalar())
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }

                command1.CommandText = "SELECT PhoneNumber FROM dbo.HCPSet where HCPID = @hcpid1";
                maskedTextBox1.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT Email FROM dbo.HCPSet where HCPID = @hcpid1";
                textBox4.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT HCOID FROM dbo.HCPSet where HCPID = @hcpid1";
                label11.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT AddressID FROM dbo.HCPSet where HCPID = @hcpid1";
                label12.Text = Convert.ToString(command1.ExecuteScalar());

            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label12.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String commandText = "UPDATE HCPSet SET FirstName=@firstname, MiddleName=@middlename, LastName=@lastname, Gender=@gender, AcademicTitle=@academictitle, Birthdate=@birthdate, PhoneNumber=@phonenumber, Email=@email, KOL=@kol, Specialty=@specialty, AddressID=@addressid, HCOID=@hcoid WHERE HCPID=@param";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@param", DBMonitor.pomoc);
                command.Parameters.AddWithValue("@firstname", textBox1.Text);
                command.Parameters.AddWithValue("@middlename", textBox2.Text);
                command.Parameters.AddWithValue("@lastname", textBox3.Text);
                command.Parameters.AddWithValue("@gender", comboBox1.Text);
                command.Parameters.AddWithValue("@academictitle", comboBox2.Text);
                command.Parameters.AddWithValue("@birthdate", dateTimePicker1.Value.Date);
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                command.Parameters.AddWithValue("@phonenumber", Convert.ToInt32(maskedTextBox1.Text.ToString()));
                command.Parameters.AddWithValue("@email", textBox4.Text);
                if (checkBox1.Checked)
                {
                    command.Parameters.AddWithValue("@kol", true);
                }
                else
                {
                    command.Parameters.AddWithValue("@kol", false);
                }
                command.Parameters.AddWithValue("@specialty", comboBox3.Text);
                command.Parameters.AddWithValue("@addressid", label12.Text);
                command.Parameters.AddWithValue("@hcoid", label11.Text);
                command.ExecuteNonQuery();
                conn.Close();
                DBMonitor powrot = new DBMonitor();
                powrot.Show();
                this.Hide();
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }
    }
}
