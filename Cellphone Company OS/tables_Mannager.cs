using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaGiVproject
{
    public partial class tables_Mannager : Form
    {
        public tables_Mannager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            workers f1 = new workers();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sapaks f5 = new sapaks();
            f5.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            order_sapak f10 = new order_sapak();
            f10.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clients f2 = new clients();
            f2.Show();
        }
    }
}
