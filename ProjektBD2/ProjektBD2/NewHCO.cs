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
    public partial class NewHCO : Form
    {
        private static SqlDataAdapter adapt;
        public NewHCO()
        {
            InitializeComponent();
        }

        private void NewHCO_Load(object sender, EventArgs e)
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
            String commandText = "INSERT INTO HCOSet VALUES(@Name,@Range,@Level,@SpecialType,@Beds,@Employees,@PhoneNumber,@Email,@Website,@AddressID)";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
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

        private void button3_Click(object sender, EventArgs e)
        {

            NewAddress nowyadres5 = new NewAddress();
            nowyadres5.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }

 
    
}
    

