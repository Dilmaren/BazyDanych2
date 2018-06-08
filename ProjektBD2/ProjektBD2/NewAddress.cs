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
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace ProjektBD2
{
    public partial class NewAddress : Form
    {
        private readonly Form parentForm;
        
        public NewAddress(Form parentFormReference)
        {
            InitializeComponent();
            parentForm = parentFormReference;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String commandText = "INSERT INTO AddressSet " +
                                 "(Street, City, Territory, Country, ZipCode)" +
                                 "VALUES (@street, @city, @territory, @country, @zipcode)";
            string sConnection = Properties.Settings.Default.BD2ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sConnection;
            conn.Open();
            
            try
            {
                SqlCommand command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@street", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@city", textBox2.Text.ToString());
                command.Parameters.AddWithValue("@territory", comboBox1.Text.ToString());
                command.Parameters.AddWithValue("@country", comboBox2.Text.ToString());
                command.Parameters.AddWithValue("@zipcode", Int32.Parse(textBox3.Text.ToString()));
                command.Parameters.AddWithValue("@param", DBMonitor.pomoc);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException er)
            {
                String text = "There was an error reported by SQL Server, " + er.Message;
                MessageBox.Show(text, "ERROR");
            }
            
            /*
            String street = textBox1.Text.ToString();
            String city = textBox2.Text.ToString();
            String territory = comboBox1.Text.ToString();
            String country = comboBox2.Text.ToString();
            String zipcodeStr = textBox3.Text.ToString();
            Int32 zipcode = Int32.Parse( (zipcodeStr == "") ? "0" : zipcodeStr );
            var adres = new Address { Street = street, City = city, 
                Territory = territory, Country = country, ZipCode = zipcode };
            
            using (var context = new MedDBContainer())
            {
                context.AddressSet.Add(adres);
                context.SaveChanges();
            }
            */
            
            parentForm.Enabled = true;
            Dispose();
        }
        
        private void windowClosing(object sender, CancelEventArgs e)
        {
            parentForm.Enabled = true;
            Dispose();
        }
    }
}
