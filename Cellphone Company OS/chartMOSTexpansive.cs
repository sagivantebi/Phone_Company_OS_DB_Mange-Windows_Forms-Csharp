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
    public partial class chartMOSTexpansive : Form
    {
        public chartMOSTexpansive()
        {
            InitializeComponent();
        }

        private void chartMOSTexpansive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.Q_expansivePHONE' table. You can move, or remove it, as needed.
            this.q_expansivePHONETableAdapter.Fill(this.phonesSAGIVDataSet.Q_expansivePHONE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
        }
    }
}
