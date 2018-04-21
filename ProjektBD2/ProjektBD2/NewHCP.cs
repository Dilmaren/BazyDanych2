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
    public partial class NewHCP : Form
    {
        public NewHCP()
        {
            InitializeComponent();
        }

        private void NewHCP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet.HCOSet' table. You can move, or remove it, as needed.
            this.hCOSetTableAdapter.Fill(this.bD2DataSet.HCOSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label12.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String commandText = "INSERT INTO HCPSet VALUES(@firstname, @middlename, @lastname, @gender, @academictitle, @birthdate, @phonenumber, @email, @kol, @specialty, @addressid, @hcoid)";
            string sConnection = Properties.Settings.Default.BD2ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sConnection;
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@firstname", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@middlename", textBox2.Text.ToString());
                command.Parameters.AddWithValue("@lastname", textBox3.Text.ToString());
                command.Parameters.AddWithValue("@gender", comboBox1.Text.ToString());
                command.Parameters.AddWithValue("@academictitle", comboBox2.Text.ToString());
                command.Parameters.Add("@birthdate", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                command.Parameters.AddWithValue("@phonenumber", Convert.ToInt32(maskedTextBox1.Text.ToString()));
                command.Parameters.AddWithValue("@email", textBox4.Text.ToString());
                command.Parameters.AddWithValue("@kol", Convert.ToBoolean(checkBox1.Checked.ToString()));
                command.Parameters.AddWithValue("@specialty", comboBox3.Text.ToString());
                command.Parameters.AddWithValue("@addressid", Convert.ToInt32(label12.Text.ToString()));
                command.Parameters.AddWithValue("@hcoid", Convert.ToInt32(label11.Text.ToString()));
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
