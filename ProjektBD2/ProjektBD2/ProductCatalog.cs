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
    public partial class ProductCatalog : Form
    {
        public static Int32 pomoc;
        public ProductCatalog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ProductCatalog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2DataSet7.ProductSet' table. You can move, or remove it, as needed.
            this.productSetTableAdapter.Fill(this.bD2DataSet7.ProductSet);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Width = dataGridView1.Columns[0].Width + dataGridView1.Columns[1].Width + dataGridView1.Columns[2].Width + dataGridView1.Columns[3].Width + dataGridView1.Columns[4].Width + dataGridView1.Columns[5].Width + 45;
            this.Width = dataGridView1.Width+50;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewProduct nowyprodukt = new NewProduct();
            nowyprodukt.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pomoc = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            EditProduct edytujprodukt = new EditProduct();
            edytujprodukt.ShowDialog();
            this.Hide();
        }
    }
}
