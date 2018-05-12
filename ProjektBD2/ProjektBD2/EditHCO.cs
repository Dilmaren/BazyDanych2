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
    public partial class EditHCO : Form
    {
        public EditHCO()
        {
            InitializeComponent();
            string sConnection = Properties.Settings.Default.BD2ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sConnection;
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@hcoid1", DBMonitor.pomoc);

                command1.CommandText = "SELECT Name FROM dbo.HCOSet where HCOID = @hcoid1";
                namebox1.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Range FROM dbo.HCOSet where HCOID = @hcoid1";
                comboBox1.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Level FROM dbo.HCOSet where HCOID = @hcoid1";
                comboBox2.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT SpecialType FROM dbo.HCOSet where HCOID = @hcoid1";
                comboBox3.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT Beds FROM dbo.HCOSet where HCOID = @hcoid1";
                bedsbox1.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT Employees FROM dbo.HCOSet where HCOID = @hcoid1";
                textBox1.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT PhoneNumber FROM dbo.HCOSet where HCOID = @hcoid1";
                textBox2.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT Email FROM dbo.HCOSet where HCOID = @hcoid1";
                textBox3.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT Website FROM dbo.HCOSet where HCOID = @hcoid1";
                textBox4.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT AddressID FROM dbo.HCOSet where HCOID = @hcoid1";
                label13.Text = Convert.ToString(command1.ExecuteScalar());

            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }

        private void EditHCO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet5.AddressSet' table. You can move, or remove it, as needed.
            this.addressSetTableAdapter1.Fill(this.bD2DataSet5.AddressSet);
            // TODO: This line of code loads data into the 'bD2DataSet1.AddressSet' table. You can move, or remove it, as needed.
            //this.addressSetTableAdapter.Fill(this.bD2DataSet1.AddressSet);
            for (int i = 1; i <= 5; i++)
            {
                AddressView1.Columns[i].DefaultCellStyle.BackColor = Color.LightGray;
                AddressView1.Columns[i].DefaultCellStyle.ForeColor = Color.DarkGray;
                AddressView1.Columns[i].DefaultCellStyle.SelectionBackColor = Color.LightGray;
                AddressView1.Columns[i].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label13.Text = AddressView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String commandText = "UPDATE HCOSet SET Name=@Name, Range=@Range, Level=@Level, SpecialType=@SpecialType, Beds=@Beds, Employees=@Employees, PhoneNumber=@PhoneNumber, Email=@Email, Website=@Website, AddressID=@AddressID WHERE HCOID=@param";
            string sConnection = Properties.Settings.Default.BD2ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sConnection;
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@Name", namebox1.Text.ToString());
                command.Parameters.AddWithValue("@Range", comboBox1.Text.ToString());
                command.Parameters.AddWithValue("@Level", Convert.ToInt16(comboBox2.Text.ToString()));
                command.Parameters.AddWithValue("@SpecialType", comboBox3.Text.ToString());
                command.Parameters.AddWithValue("@Beds", bedsbox1.Text.ToString());
                command.Parameters.AddWithValue("@Employees", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@PhoneNumber", Int32.Parse(textBox2.Text.ToString()));
                command.Parameters.AddWithValue("@Email", textBox3.Text.ToString());
                command.Parameters.AddWithValue("@Website", textBox4.Text.ToString());
                command.Parameters.AddWithValue("@AddressID", Int32.Parse(label13.Text.ToString()));
                command.Parameters.AddWithValue("@param", DBMonitor.pomoc);
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
