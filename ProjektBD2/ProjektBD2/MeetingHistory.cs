using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ProjektBD2
{
    public partial class MeetingHistory : Form
    {
        private DataTable dataTable = new DataTable();
        private BindingSource SBind = new BindingSource();
        public MeetingHistory()
        {
            InitializeComponent();
        }

        private void MeetingHistory_Load(object sender, EventArgs e)
        {
            string sConnection = Properties.Settings.Default.BD2ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sConnection;
            conn.Open();
            try
            {
                string query = "SELECT MeetingSet.MeetingID, MeetingSet.Date, MeetingSet.Topic, ProductSet.ProductName, UserSet.FirstName, UserSet.LastName FROM MeetingSet JOIN ProductSet ON MeetingSet.ProductID = ProductSet.ProductID JOIN  UserSet ON MeetingSet.UserID = UserSet.UserID WHERE HCPID = @param";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@param", DBMonitor.pomoc);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                //SBind.DataSource = dataTable;
                dataGridView1.DataSource = dataTable;

               // da.Dispose();
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBMonitor powrot = new DBMonitor();
            powrot.Show();
        }
    }
}
