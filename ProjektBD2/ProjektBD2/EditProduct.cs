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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.BD2ConnectionString;
           // conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("", conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@prdid", ProductCatalog.pomoc);

                command1.CommandText = "SELECT ProductName FROM dbo.ProductSet where ProductID = @prdid";
                textBox1.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT AntiDisease FROM dbo.ProductSet where ProductID = @prdid";
                comboBox1.Text = (String)command1.ExecuteScalar();

                command1.CommandText = "SELECT Manufacturer FROM dbo.ProductSet where ProductID = @prdid";
                if( comboBox2.Items.Contains(Convert.ToString(command1.ExecuteScalar())))
                {
                    comboBox2.Text = Convert.ToString(command1.ExecuteScalar());
                    
                }
                else
                {
                    textBox2.Enabled = true;
                    textBox2.Text = "";
                    textBox2.Text = Convert.ToString(command1.ExecuteScalar());
                    comboBox2.Text = "---OTHER---";
                }

                command1.CommandText = "SELECT QtyPerCase FROM dbo.ProductSet where ProductID  = @prdid";
                numericUpDown1.Value = Convert.ToInt32(command1.ExecuteScalar());

                command1.CommandText = "SELECT MIngredient FROM dbo.ProductSet where ProductID  = @prdid";
                textBox3.Text = (String)command1.ExecuteScalar();
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String commandText = "UPDATE ProductSet SET ProductName=@productname, AntiDisease=@ad, Manufacturer=@manufacturer, QtyPerCase=@qty, MIngredient=@mi WHERE ProductID=@param";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.BD2ConnectionString; 
            //conn.ConnectionString = "Data Source=DESKTOP-8KR5DN1\\BNINSTANCE;Initial Catalog=BD2;Integrated Security=True";
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@param", ProductCatalog.pomoc);
                command.Parameters.AddWithValue("@productname", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@ad", comboBox1.Text.ToString());
                if (textBox2.Enabled == true)
                {
                    command.Parameters.AddWithValue("@manufacturer", textBox2.Text.ToString());
                }
                else
                {
                    command.Parameters.AddWithValue("@manufacturer", comboBox2.Text.ToString());
                }
                command.Parameters.AddWithValue("@qty", numericUpDown1.Value);
                command.Parameters.AddWithValue("@mi", textBox3.Text.ToString());
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

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {

            if (comboBox2.Text == "---OTHER---")
            {
                textBox2.Enabled = true;

            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "If company is not present at the list please choose OTHER and type Company Name here";
            }
        }
    }
}
