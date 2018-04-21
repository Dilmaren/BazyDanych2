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
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "---OTHER---")
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "If company is not present at the list please choose OTHER and type Company Name here";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String commandText = "INSERT INTO ProductSet VALUES(@productname, @antidesease, @manufacturer, @qty, @mainingr)";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@productname", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@antidesease", comboBox1.Text.ToString());
                if (comboBox2.Text.ToString().Equals("---OTHER---"))
                {
                    command.Parameters.AddWithValue("@manufacturer", textBox2.Text.ToString());
                }
                else
                {
                    command.Parameters.AddWithValue("@manufacturer", comboBox2.Text.ToString());
                }
                command.Parameters.AddWithValue("@qty", numericUpDown1.Value);
                command.Parameters.AddWithValue("@mainingr", textBox3.Text.ToString());
                command.ExecuteNonQuery();
                conn.Close();
                ProductCatalog powrot = new ProductCatalog();
                powrot.Show();
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
