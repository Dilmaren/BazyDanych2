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
    public partial class showAddresses : Form
    {
        private DataTable dataTable = new DataTable();
        public showAddresses()
        {
            InitializeComponent();
        }

        private void showAddresses_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.BD2ConnectionString;
            //conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                string query = "SELECT AddressID, Street, City, Territory, Country, ZipCode FROM dbo.AddressSet";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewUser.AddressID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            this.Hide();
            NewUser powrot = new NewUser();
            powrot.Show();
        }
    }
}
