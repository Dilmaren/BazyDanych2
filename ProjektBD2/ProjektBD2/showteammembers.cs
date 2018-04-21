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
    public partial class showteammembers : Form
    {

        private DataTable dataTable = new DataTable();
        private BindingSource SBind = new BindingSource();

        public showteammembers()
        {
            InitializeComponent();
        }

        private void showteammembers_Load(object sender, EventArgs e)
        {
            string sConnection = Properties.Settings.Default.BD2ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sConnection;
            conn.Open();
            try
            {
                string query = "select distinct u1.FirstName, u1.LastName, u1.Username, u1.Email, u1.PhoneNumber from UserSet u1, UserSet u2 WHERE u1.UserID <> u2.UserID AND u1.ManagerID = @param";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@param", UserMonitor.pomoc);
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
            this.Hide();
        }
    }
}
