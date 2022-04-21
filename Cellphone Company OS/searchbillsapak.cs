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
    public partial class searchbillsapak : Form
    {
        public searchbillsapak()
        {
            InitializeComponent();
        }

        private void searchbillsapak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.Q_BILLS' table. You can move, or remove it, as needed.
            this.q_BILLSTableAdapter.Fill(this.phonesSAGIVDataSet.Q_BILLS);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_sapak' table. You can move, or remove it, as needed.
            this.t_sapakTableAdapter.Fill(this.phonesSAGIVDataSet.t_sapak);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_phones' table. You can move, or remove it, as needed.
            this.t_phonesTableAdapter.Fill(this.phonesSAGIVDataSet.t_phones);

        }

        private void t_phonesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_phonesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phonesSAGIVDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.phonesSAGIVDataSet.Q_BILLS);
            dv.RowFilter = string.Format("id_p Like '%{0}%'", id_pComboBox.SelectedValue);
            q_BILLSDataGridView.DataSource = dv;
            label1.Text = "סך קניות מספק פלאפון זה: "+(q_BILLSDataGridView.Rows.Count - 1).ToString() ;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.phonesSAGIVDataSet.Q_BILLS);
            dv.RowFilter = string.Format("id_sapak Like '%{0}%'", id_sapakComboBox.SelectedValue);
            q_BILLSDataGridView.DataSource = dv;
            label1.Text = "סך קניות מספק זה: " + (q_BILLSDataGridView.Rows.Count - 1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime t = new DateTime();
            t = dateTimePicker1.Value;
            DateTime y = new DateTime();
            y = dateTimePicker2.Value;
            DataView dv = new DataView(this.phonesSAGIVDataSet.Q_BILLS);
            dv.RowFilter = string.Format("(bill_date_s>='{0}') AND (bill_date_s<='{1}')", t.ToString(), y.ToString());
            q_BILLSDataGridView.DataSource = dv;
            label1.Text = (q_BILLSDataGridView.Rows.Count - 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("דוח חשבונית הזמנת מספק", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(200, 100));
            e.Graphics.DrawLine(p, new Point(200, 150), new Point(700, 150));

            e.Graphics.DrawString(" שם ספק: " + id_sapakComboBox.Text, new Font("Ariel", 12, FontStyle.Bold), Brushes.Black, new Point(510, 160));

            int i = 0, j;
            int x = 45, y = 250;
            int w = q_BILLSDataGridView.Columns[0].Width, h = q_BILLSDataGridView.Rows[0].Height;

            while (i < q_BILLSDataGridView.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y, q_BILLSDataGridView.Columns[0].Width, q_BILLSDataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(q_BILLSDataGridView.Columns[i].HeaderText.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < q_BILLSDataGridView.Rows.Count - 1)
            {
                x = 45; y += 30;
                w = 100; h = 30;
                j = 0;
                while (j < q_BILLSDataGridView.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(q_BILLSDataGridView.Rows[i].Cells[j].FormattedValue.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x += 100;
                }
                i++;
            }
            int Abc = int.Parse(q_BILLSDataGridView.Rows.Count.ToString());
            e.Graphics.DrawString(Abc - 1 + "   :סך חשבוניות פלאפונים מספק", new Font("Ariel", 15, FontStyle.Bold), Brushes.Black, new Point(200, y + 50));
        }
    }
}
