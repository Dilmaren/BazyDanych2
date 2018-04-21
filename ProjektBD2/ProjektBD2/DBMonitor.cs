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
        public static Int32 pomoc;
        public static String pomoc1;
        private static SqlDataAdapter adapt;
        public DBMonitor()
        {
            InitializeComponent();
            tabPage1.Text = "Address";
            tabPage2.Text = "HCO";
            tabPage3.Text = "HCP";
            toolTip1.SetToolTip(button3, "1 - cztery podstawowe specjalności (choroby wew., chirurgia, położnictwo, pediatria)\n2 - szpital wojewódzki - dodatkowe specjalności (np dermatologia, kardiochirurgia, neurologia itd.)\n3 - szpital kliniczny i jednostki MSWiA");
        }

        private void DBMonitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet5.AddressSet' table. You can move, or remove it, as needed.
            this.addressSetTableAdapter1.Fill(this.bD2DataSet5.AddressSet);
            // TODO: This line of code loads data into the 'bD2DataSet2.HCPSet' table. You can move, or remove it, as needed.
            this.hCPSetTableAdapter.Fill(this.bD2DataSet2.HCPSet);
            // TODO: This line of code loads data into the 'bD2DataSet.HCOSet' table. You can move, or remove it, as needed.
            this.hCOSetTableAdapter.Fill(this.bD2DataSet.HCOSet);
            // TODO: This line of code loads data into the 'bD2DataSet1.AddressSet' table. You can move, or remove it, as needed.
      //  this.addressSetTableAdapter.Fill(this.bD2DataSet1.AddressSet);

        }
        //New Address Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewHCO nowyszpital = new NewHCO();
            nowyszpital.Show();
        }

        //New HCO Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            NewAddress nowyadres = new NewAddress();
            nowyadres.Show();
            this.Hide();
        }

        //New HCP Button
        private void button8_Click(object sender, EventArgs e)
        {
            NewHCP nowylekarz = new NewHCP();
            nowylekarz.Show();
            this.Hide();
        }

        //Show Details HCO Button
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        //Show Details HCP
        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        //Level of treatment HELP Button
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 - cztery podstawowe specjalności (choroby wew., chirurgia, położnictwo, pediatria)\n2 - szpital wojewódzki - dodatkowe specjalności (np dermatologia, kardiochirurgia, neurologia itd.)\n3 - szpital kliniczny i jednostki MSWiA", "INFO");
        }

        //Edit Address Button
        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.BD2ConnectionString;
            // conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@name1", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                command1.CommandText = "SELECT AddressID FROM dbo.AddressSet where AddressID = @name1";
                pomoc1 = Convert.ToString(command1.ExecuteScalar());
                pomoc = Int32.Parse(pomoc1);
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
            EditAddress edytujadres = new EditAddress();
            edytujadres.Show();
            this.Hide();
        }

        //Edit HCO Button
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.BD2ConnectionString;
            // conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@name1", dataGridView2.CurrentCell.Value.ToString());
                command1.CommandText = "SELECT HCOID FROM dbo.HCOSet where NAME = @name1";
                pomoc1 = Convert.ToString(command1.ExecuteScalar());
                pomoc = Int32.Parse(pomoc1);
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }

            this.Hide();
            EditHCO edytujszpital = new EditHCO();
            edytujszpital.Show();
        }

        //Edit HCP Button
        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = Properties.Settings.Default.BD2ConnectionString;
            //conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@name1", dataGridView3.CurrentRow.Cells[3].Value.ToString());
                command1.CommandText = "SELECT HCPID FROM dbo.HCPSet where HCPID = @name1";
                pomoc = Int32.Parse(Convert.ToString(command1.ExecuteScalar()));
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
            EditHCP edytujlekarza = new EditHCP();
            edytujlekarza.Show();
            this.Hide();
        }

        //Show Doctors HCO Button
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.BD2ConnectionString;
            //conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@name1", dataGridView2.CurrentCell.Value.ToString());
                command1.CommandText = "SELECT HCOID FROM dbo.HCOSet where NAME = @name1";
                pomoc1 = Convert.ToString(command1.ExecuteScalar());
                pomoc = Int32.Parse(pomoc1);
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
            this.Hide();
            showEmployees pokazdoktorow = new showEmployees();
            pokazdoktorow.Show();
        }

        //Delete Address Button
        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.BD2ConnectionString;
            //conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@name1", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                command1.CommandText = "DELETE from dbo.AddressSet where AddressID = @name1";
                command1.ExecuteScalar();

                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from dbo.AddressSet", conn);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }

        //Show Meeting History Button
        private void button11_Click(object sender, EventArgs e)
        {
            pomoc = Convert.ToInt32(dataGridView3.CurrentRow.Cells[3].Value.ToString());
            this.Hide();
            MeetingHistory historiaspotkan = new MeetingHistory();
            historiaspotkan.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.BD2ConnectionString;
            //conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
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

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sConnection = Properties.Settings.Default.BD2ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sConnection;
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@name2", dataGridView3.CurrentRow.Cells[3].Value.ToString());

                command1.CommandText = "SELECT FirstName FROM dbo.HCPSet where HCPID = @name2";
                label35.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT MiddleName FROM dbo.HCPSet where HCPID = @name2";
                label37.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT LastName FROM dbo.HCPSet where HCPID = @name2";
                label39.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Gender FROM dbo.HCPSet where HCPID = @name2";
                label43.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Birthdate FROM dbo.HCPSet where HCPID = @name2";
                label57.Text = Convert.ToString(command1.ExecuteScalar()).Substring(0, 10);

                command1.CommandText = "SELECT AcademicTitle FROM dbo.HCPSet where HCPID = @name2";
                label41.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Specialty FROM dbo.HCPSet where HCPID = @name2";
                label46.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT KOL FROM dbo.HCPSet where HCPID = @name2";
                if ((bool)command1.ExecuteScalar())
                {
                    checkBox1.Checked = true;
                }

                command1.CommandText = "SELECT PhoneNumber FROM dbo.HCPSet where HCPID = @name2";
                label51.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT Email FROM dbo.HCPSet where HCPID = @name2";
                label53.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Name FROM dbo.HCPSet join dbo.HCOSet on dbo.HCOSet.HCOID = dbo.HCPSet.HCOID where  HCPID = @name2";
                label55.Text = (String)command1.ExecuteScalar();

            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }
    }
}
