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
    public partial class DBMonitor : Form
    {
        public DBMonitor()
        {
            InitializeComponent();
            tabPage1.Text = "Address";
            tabPage2.Text = "HCO";
            toolTip1.SetToolTip(button3, "1 - cztery podstawowe specjalności (choroby wew., chirurgia, położnictwo, pediatria)\n2 - szpital wojewódzki - dodatkowe specjalności (np dermatologia, kardiochirurgia, neurologia itd.)\n3 - szpital kliniczny i jednostki MSWiA");
        }

        private void DBMonitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet.HCOSet' table. You can move, or remove it, as needed.
            this.hCOSetTableAdapter.Fill(this.bD2DataSet.HCOSet);
            // TODO: This line of code loads data into the 'bD2DataSet1.AddressSet' table. You can move, or remove it, as needed.
            this.addressSetTableAdapter.Fill(this.bD2DataSet1.AddressSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewHCO nowyszpital = new NewHCO();
            nowyszpital.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("",conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@name1", dataGridView2.CurrentCell.Value.ToString());
                command1.CommandText = "SELECT Name FROM dbo.HCOSet where NAME = @name1";
                label3.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Range FROM dbo.HCOSet where NAME = @name1";
                label5.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Level FROM dbo.HCOSet where NAME = @name1";
                label7.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT SpecialType FROM dbo.HCOSet where NAME = @name1";
                label9.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT Beds FROM dbo.HCOSet where NAME = @name1";
                label24.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT Employees FROM dbo.HCOSet where NAME = @name1";
                label25.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT PhoneNumber FROM dbo.HCOSet where NAME = @name1";
                label30.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT Email FROM dbo.HCOSet where NAME = @name1";
                label31.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT Website FROM dbo.HCOSet where NAME = @name1";
                label32.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "Select Street from dbo.HCOSet join dbo.AddressSet on dbo.AddressSet.AddressID = dbo.HCOSet.AddressID where NAME = @name1";
                label16.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "Select City from dbo.HCOSet join dbo.AddressSet on dbo.AddressSet.AddressID = dbo.HCOSet.AddressID where NAME = @name1";
                label17.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "Select ZipCode from dbo.HCOSet join dbo.AddressSet on dbo.AddressSet.AddressID = dbo.HCOSet.AddressID where NAME = @name1";
                label18.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "Select Territory from dbo.HCOSet join dbo.AddressSet on dbo.AddressSet.AddressID = dbo.HCOSet.AddressID where NAME = @name1";
                label19.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "Select Country from dbo.HCOSet join dbo.AddressSet on dbo.AddressSet.AddressID = dbo.HCOSet.AddressID where NAME = @name1";
                label20.Text = Convert.ToString(command1.ExecuteScalar());


            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 - cztery podstawowe specjalności (choroby wew., chirurgia, położnictwo, pediatria)\n2 - szpital wojewódzki - dodatkowe specjalności (np dermatologia, kardiochirurgia, neurologia itd.)\n3 - szpital kliniczny i jednostki MSWiA", "INFO");
        }
    }
}
