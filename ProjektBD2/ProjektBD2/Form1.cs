using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektBD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet.HCOSet' table. You can move, or remove it, as needed.
            this.hCOSetTableAdapter.Fill(this.bD2DataSet.HCOSet);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBMonitor nowymonitor = new DBMonitor();
            nowymonitor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String street = "Kolorowa 6";
            String city = "Poznań";
            String territory = "Wielkopolska";
            String country = "Polska";
            Int32 zipcode = 12010;
            var adres = new Address { Street = street, City=city, Territory=territory, Country=country, ZipCode=zipcode };

            using (var context = new MedDBContainer())
            {
                context.AddressSet.Add(adres);
                context.SaveChanges();
            }
        }
    }
}
