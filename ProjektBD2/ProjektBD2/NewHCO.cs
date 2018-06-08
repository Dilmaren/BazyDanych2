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
        private readonly Form parentForm;
        
        public NewHCO(Form parentFormReference)
        {
            InitializeComponent();
            parentForm = parentFormReference;
        }
        
        private void NewHCO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet5.AddressSet' table. You can move, or remove it, as needed.
            addressSetTableAdapter1.Fill(bD2DataSet5.AddressSet);
            // TODO: This line of code loads data into the 'bD2DataSet1.AddressSet' table. You can move, or remove it, as needed.
            //addressSetTableAdapter.Fill(bD2DataSet1.AddressSet);
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
            String commandText = "INSERT INTO HCOSet " +
                                 "VALUES(@Name,@Range,@Level,@SpecialType,@Beds,@Employees," +
                                 "@PhoneNumber,@Email,@Website,@AddressID)";
            string sConnection = Properties.Settings.Default.BD2ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sConnection;
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@Name", namebox1.Text);
                command.Parameters.AddWithValue("@Range", comboBox1.Text);
                command.Parameters.AddWithValue("@Level", Convert.ToInt16(comboBox2.Text));
                command.Parameters.AddWithValue("@SpecialType", comboBox3.Text);
                command.Parameters.AddWithValue("@Beds", bedsbox1.Text);
                command.Parameters.AddWithValue("@Employees", textBox1.Text);
                command.Parameters.AddWithValue("@PhoneNumber", Int32.Parse(textBox2.Text));
                command.Parameters.AddWithValue("@Email", textBox3.Text);
                command.Parameters.AddWithValue("@Website", textBox4.Text);
                command.Parameters.AddWithValue("@AddressID", Int32.Parse(label13.Text));
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
        
        private void button3_Click(object sender, EventArgs e)
        {
            Enabled = false;
            NewAddress nowyadres5 = new NewAddress(this);
            nowyadres5.Show();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            addressSetTableAdapter1.Fill(bD2DataSet5.AddressSet);
        }
        
        private void windowClosing(object sender, CancelEventArgs e)
        {
            parentForm.Enabled = true;
            Dispose();
        }
    }
}
