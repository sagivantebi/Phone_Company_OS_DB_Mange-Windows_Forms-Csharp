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
    public partial class table_tikun : Form
    {
        public table_tikun()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            takala f3 = new takala();
            f3.Show();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            order_fix f15 = new order_fix();
            f15.Show();
        }
    }
}
