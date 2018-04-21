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
    public partial class EditPassword : Form
    {
        public EditPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((label3.Text.ToString().Equals("MATCH!")) && (label4.Text.ToString().Equals("Password is good with the policy.")))
            {
                String commandText = "UPDATE UserCredentialsSet SET Password=@pw WHERE UserID=@uid";
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
                conn.Open();
                try
                {
                    SqlCommand command = new SqlCommand(commandText, conn);
                    command.Parameters.AddWithValue("@uid", UserMonitor.pomoc);
                    command.Parameters.AddWithValue("@pw", textBox1.Text.ToString());
                    command.ExecuteNonQuery();
                    MessageBox.Show("DONE!", "Information");
                }
                catch (SqlException er)
                {
                    String text = "There was an error reported by SQL Server, " + er.Message;
                    MessageBox.Show(text, "ERROR");
                }
                conn.Close();
            }

            else
            {
                MessageBox.Show("Error: Password not match and/or is not good with policy");
            }

            this.Hide();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((textBox1.Text.ToString().Length < 8) && (textBox2.Text.ToString().Length < 8))
            {
                label4.ForeColor = Color.Blue;
                label4.Text = "Please select longer password. Password must have min. 8 characters.";
            }
            else
            {
                label4.ForeColor = Color.Green;
                label4.Text = "Password is good with the policy.";
            }
        }
        
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((textBox1.Text.ToString().Length < 8) && (textBox2.Text.ToString().Length < 8))
            {
                label4.ForeColor = Color.Blue;
                label4.Text = "Please select longer password. Password must have min. 8 characters.";
            }
            else
            {
                label4.ForeColor = Color.Green;
                label4.Text = "Password is good with the policy.";
            }

            if (textBox1.Text.ToString() == textBox2.Text.ToString())
            {
                label3.ForeColor = Color.Green;
                label3.Text = "MATCH!";
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "NOT MATCH!";
            }
        }
    }
}
