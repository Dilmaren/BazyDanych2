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
            
            //this.Hide();
            //DBMonitor nowy = new DBMonitor();
            parentForm.Enabled = true;
            Dispose();
        }
        
        
    }
}
