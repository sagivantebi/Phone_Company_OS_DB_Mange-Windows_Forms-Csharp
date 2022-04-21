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
    public partial class searchBillPack : Form
    {
        public searchBillPack()
        {
            InitializeComponent();
        }

        private void id_pComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void searchBillPack_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_pack' table. You can move, or remove it, as needed.
            this.t_packTableAdapter.Fill(this.phonesSAGIVDataSet.t_pack);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.Q_searchPACKbill' table. You can move, or remove it, as needed.
            this.q_searchPACKbillTableAdapter.Fill(this.phonesSAGIVDataSet.Q_searchPACKbill);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.phonesSAGIVDataSet.Q_searchPACKbill);
            dv.RowFilter = string.Format("id_pack Like '%{0}%'", id_pComboBox.SelectedValue);
            q_searchPACKbillDataGridView.DataSource = dv;
            label1.Text = "סך הזמנות מחבילה זה: " + (q_searchPACKbillDataGridView.Rows.Count - 1).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.phonesSAGIVDataSet.Q_searchPACKbill);
            dv.RowFilter = string.Format("phone_num Like '%{0}%'", maskedTextBox1.Text);
            q_searchPACKbillDataGridView.DataSource = dv;
            
        }

    }
}
