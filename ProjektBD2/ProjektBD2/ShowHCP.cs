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
    public partial class ShowHCP : Form
    {
        public ShowHCP()
        {
            InitializeComponent();
        }
        
        private void ShowHCP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet2.HCPSet' table. You can move, or remove it, as needed.
            hCPSetTableAdapter.Fill(bD2DataSet2.HCPSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewMeeting.selectedHCPID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            NewMeeting.selectedhcpname = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value + " " + dataGridView1.CurrentRow.Cells[3].Value);
            Hide();
            NewMeeting powrot = new NewMeeting();
            powrot.Show();
        }
    }
}
