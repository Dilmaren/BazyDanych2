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
    public partial class showEmployees : Form
    {
        public showEmployees()
        {
            InitializeComponent();
        }

        private void showEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet2.HCPSet' table. You can move, or remove it, as needed.
            this.hCPSetTableAdapter.Fill(this.bD2DataSet2.HCPSet);
            filtrujToolStrip.Visible = false;
            paramToolStripTextBox.Text = Convert.ToString(DBMonitor.pomoc);
            this.hCPSetTableAdapter.Filtruj(this.bD2DataSet2.HCPSet, ((int)(System.Convert.ChangeType(paramToolStripTextBox.Text, typeof(int)))));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBMonitor powrot = new DBMonitor();
            powrot.Show();
            this.Hide();
        }

        private void filtrujToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.hCPSetTableAdapter.Filtruj(this.bD2DataSet2.HCPSet, ((int)(System.Convert.ChangeType(paramToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }

    }

