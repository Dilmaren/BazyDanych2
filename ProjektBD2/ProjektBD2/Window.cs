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
    public partial class Window : Form
    {
        public static Window window = null;

        public Window()
        {
            
            InitializeComponent();

            window = this;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = Form1.form;
            form1.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form1 form1 = Form1.form;
            form1.Show();
            Hide();
        }
    }
}
