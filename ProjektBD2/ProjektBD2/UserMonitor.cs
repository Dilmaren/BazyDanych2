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
using System.Data.Sql;
using System.Data.SqlTypes;

namespace ProjektBD2
{
    public partial class UserMonitor : Form
    {

        private static SqlDataAdapter adapt;

        public static int pomoc;
        public UserMonitor()
        {
            InitializeComponent();
        }

        private void UserMonitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet6.UserSet' table. You can move, or remove it, as needed.
            this.userSetTableAdapter.Fill(this.bD2DataSet6.UserSet);

        }
        //Show Details Button
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@uid1", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                command1.CommandText = "SELECT FirstName FROM dbo.UserSet where UserID = @uid1";
                label9.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT LastName FROM dbo.UserSet where UserID = @uid1";
                label10.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT LastName FROM dbo.UserSet where UserID = @uid1";
                label10.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT JobTitle FROM dbo.UserSet where UserID = @uid1";
                label11.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Email FROM dbo.UserSet where UserID = @uid1";
                label12.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT PhoneNumber FROM dbo.UserSet where UserID = @uid1";
                label13.Text = Convert.ToString(command1.ExecuteScalar());

                command1.CommandText = "SELECT HireDate FROM dbo.UserSet where UserID = @uid1";
                label14.Text = Convert.ToString(command1.ExecuteScalar()).Substring(0,10);

                command1.CommandText = "SELECT ManagerID FROM dbo.UserSet where UserID = @uid1";
                if (Convert.IsDBNull(command1.ExecuteScalar()) )
                {
                    label15.Text = "NULL";
                }
                else
                {
                    label15.Text = Convert.ToString(command1.ExecuteScalar());
                }
                
                command1.CommandText = "SELECT Username FROM dbo.UserSet where UserID = @uid1";
                label16.Text = (String)command1.ExecuteScalar();
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pomoc = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            showteammembers pokazzespol = new showteammembers();
            pokazzespol.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser nowyuzytkownik = new NewUser();
            nowyuzytkownik.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pomoc = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            EditUser edytujuzytkownika = new EditUser();
            edytujuzytkownika.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@userid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                command1.CommandText = "DELETE from dbo.UserSet where UserID = @userid";
                command1.ExecuteScalar();

                command1.CommandText = "DELETE from dbo.UserCredentialsSet where UserID = @userid";
                command1.ExecuteScalar();

                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select UserID, FirstName, LastName, JobTitle from dbo.UserSet", conn);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }
    }
}
