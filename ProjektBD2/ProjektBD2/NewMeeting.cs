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
    public partial class NewMeeting : Form
    {
        public static int selectedHCPID;
        public static int selectedProductID;
        DateTime meetingDayTime;
        public static String selectedproductname;
        public static String selectedhcpname;
        public NewMeeting()
        {
            InitializeComponent();
            newMeetingSelectedProduct.Text = Convert.ToString(selectedproductname);
            newMeetingSelectedHCP.Text = Convert.ToString(selectedhcpname);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowHCP wybierzlekarza = new ShowHCP();
            wybierzlekarza.Show();
            this.Hide();
        }

        private void NewMeeting_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowProduct pokazprodukty = new ShowProduct();
            pokazprodukty.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String commandText = "INSERT INTO MeetingSet VALUES(@hcpid, @date, @topic, @productid, @userid)";
            string sConnection = Properties.Settings.Default.BD2ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sConnection;
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@hcpid", selectedHCPID);
                meetingDayTime = datePicker1.Value.Date + timePicker1.Value.TimeOfDay;
                command.Parameters.AddWithValue("@date", meetingDayTime);
                command.Parameters.AddWithValue("@topic", richTextBox1.Text.ToString());
                command.Parameters.AddWithValue("@productid", selectedProductID);
                command.Parameters.AddWithValue("@userid", Form1.loggedUserID);                
                command.ExecuteNonQuery();

                conn.Close();
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
