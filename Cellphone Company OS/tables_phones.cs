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
    public partial class tables_phones : Form
    {
        public tables_phones()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            types f8 = new types();
            f8.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buyphones f9 = new buyphones();
            f9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            phones f1 = new phones();
            f1.Show();

        }
    }
}
