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
        private readonly Form parentForm;
        
        public NewHCP(Form parentFormReference)
        {
            InitializeComponent();
            parentForm = parentFormReference;
        }

        private void NewHCP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet.HCOSet' table. You can move, or remove it, as needed.
            hCOSetTableAdapter.Fill(bD2DataSet.HCOSet);
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
                command.Parameters.AddWithValue("@firstname", textBox1.Text);
                command.Parameters.AddWithValue("@middlename", textBox2.Text);
                command.Parameters.AddWithValue("@lastname", textBox3.Text);
                command.Parameters.AddWithValue("@gender", comboBox1.Text);
                command.Parameters.AddWithValue("@academictitle", comboBox2.Text);
                command.Parameters.Add("@birthdate", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                command.Parameters.AddWithValue("@phonenumber", Convert.ToInt32(maskedTextBox1.Text));
                command.Parameters.AddWithValue("@email", textBox4.Text);
                command.Parameters.AddWithValue("@kol", Convert.ToBoolean(checkBox1.Checked.ToString()));
                command.Parameters.AddWithValue("@specialty", comboBox3.Text);
                command.Parameters.AddWithValue("@addressid", Convert.ToInt32(label12.Text));
                command.Parameters.AddWithValue("@hcoid", Convert.ToInt32(label11.Text));
                command.ExecuteNonQuery();
                conn.Close();

                parentForm.Enabled = true;
                Dispose();
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }
        
        private void windowClosing(object sender, CancelEventArgs e)
        {
            parentForm.Enabled = true;
            Dispose();
        }
    }
}
