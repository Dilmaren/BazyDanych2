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
        private readonly Form parentForm;
        
        public showEmployees(Form parentFormReference)
        {
            InitializeComponent();
            parentForm = parentFormReference;
        }
        
        private void showEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet2.HCPSet' table. You can move, or remove it, as needed.
            hCPSetTableAdapter.Fill(bD2DataSet2.HCPSet);
            filtrujToolStrip.Visible = false;
            paramToolStripTextBox.Text = Convert.ToString(DBMonitor.pomoc);
            hCPSetTableAdapter.Filtruj(bD2DataSet2.HCPSet, (int)Convert.ChangeType(paramToolStripTextBox.Text, typeof(int)));
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.Enabled = true;
            Dispose();
        }
        
        private void filtrujToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // hCPSetTableAdapter.Filtruj(bD2DataSet2.HCPSet, ((int)(System.Convert.ChangeType(paramToolStripTextBox.Text, typeof(int)))));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void windowClosing(object sender, CancelEventArgs e)
        {
            parentForm.Enabled = true;
            Dispose();
        }
    }
}
