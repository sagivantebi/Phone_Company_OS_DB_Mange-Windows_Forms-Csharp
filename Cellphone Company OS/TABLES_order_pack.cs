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
    public partial class TABLES_order_pack : Form
    {
        public TABLES_order_pack()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            packs f6 = new packs();
            f6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order_pack f1 = new Order_pack();
            f1.Show();
        }
    }
}
