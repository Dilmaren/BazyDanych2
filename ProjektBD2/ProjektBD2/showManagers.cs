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
    public partial class showManagers : Form
    {
        private DataTable dataTable = new DataTable();
        public showManagers()
        {
            InitializeComponent();
        }

        private void showManagers_Load(object sender, EventArgs e)
        {
            string sConnection = Properties.Settings.Default.BD2ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sConnection;
            conn.Open();
            try
            {
                string query = "SELECT UserID, FirstName, LastName, Email, PhoneNumber, JobTitle from dbo.UserSet WHERE JobTitle='Medical Representative Manager' OR  JobTitle='LOCAL ADMIN' OR  JobTitle='SYSTEM ADMIN'";
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
            NewUser.ManagerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            this.Hide();
            NewUser powrot = new NewUser();
            powrot.Show();
        }
    }
}
