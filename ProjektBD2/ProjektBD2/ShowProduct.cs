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
    public partial class ShowProduct : Form
    {
        public ShowProduct()
        {
            InitializeComponent();
        }

        private void ShowProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet7.ProductSet' table. You can move, or remove it, as needed.
            this.productSetTableAdapter.Fill(this.bD2DataSet7.ProductSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewMeeting.selectedProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            NewMeeting.selectedproductname = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value.ToString());

            this.Hide();
            NewMeeting powrot = new NewMeeting();
            powrot.Show();
        }
    }
}
