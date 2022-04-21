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
    public partial class ttables2 : Form
    {
        public ttables2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tables_phones f11 = new tables_phones();
            f11.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TABLES_order_pack f13 = new TABLES_order_pack();
            f13.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table_tikun f14 = new table_tikun();
            f14.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tablesWorker f12 = new tablesWorker();
            f12.Show();
        }
    }
}
