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
    public partial class searchbill1 : Form
    {
        public searchbill1()
        {
            InitializeComponent();
        }

        private void searchbill1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.Q_BILL' table. You can move, or remove it, as needed.
            this.q_BILLTableAdapter.Fill(this.phonesSAGIVDataSet.Q_BILL);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_worker' table. You can move, or remove it, as needed.
            this.t_workerTableAdapter.Fill(this.phonesSAGIVDataSet.t_worker);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_client' table. You can move, or remove it, as needed.
            this.t_clientTableAdapter.Fill(this.phonesSAGIVDataSet.t_client);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_phones' table. You can move, or remove it, as needed.
            this.t_phonesTableAdapter.Fill(this.phonesSAGIVDataSet.t_phones);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void t_phonesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_phonesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phonesSAGIVDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.phonesSAGIVDataSet.Q_BILL);
            dv.RowFilter = string.Format("id_phone Like '%{0}%'", id_pComboBox.SelectedValue);
            q_BILLDataGridView.DataSource = dv;
            label1.Text = "סך קניות מפלאפון זה: " + (q_BILLDataGridView.Rows.Count - 1).ToString();
            button10.Visible = true;
            button9.Visible = true;


            button5.Visible = false;
            button7.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.phonesSAGIVDataSet.Q_BILL);
            dv.RowFilter = string.Format("w_id Like '%{0}%'", w_idComboBox.SelectedValue);
            q_BILLDataGridView.DataSource = dv;
            label1.Text = "סך מכירות של עובד זה: " + (q_BILLDataGridView.Rows.Count - 1).ToString();
            button5.Visible = true;
            button7.Visible = true;

            button6.Visible = false;
            button8.Visible = false;
            button10.Visible = false;
            button9.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.phonesSAGIVDataSet.Q_BILL);
            dv.RowFilter = string.Format("id_client Like '%{0}%'", id_clientComboBox.SelectedValue);
            q_BILLDataGridView.DataSource = dv;
            label1.Text = "סך קניות של לקוח זה: " + (q_BILLDataGridView.Rows.Count - 1).ToString();
            button6.Visible = true;
            button8.Visible = true;


            button5.Visible = false;
            button7.Visible = false;
            button10.Visible = false;
            button9.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime t = new DateTime();
            string t1=dateTimePicker1.Value.ToString().Substring(0,10);
            t = DateTime.Parse(t1);
            DateTime y = new DateTime();
            string y1 = dateTimePicker2.Value.ToString().Substring(0, 10);
            y = DateTime.Parse(y1);
          
            DataView dv = new DataView(this.phonesSAGIVDataSet.Q_BILL);
            dv.RowFilter = string.Format("(bill_date>='{0}') AND (bill_date<='{1}')", t.ToString(), y.ToString());
            q_BILLDataGridView.DataSource = dv;
            label1.Text = "סך חשבוניות של הזמנות בין התאריכים: " + (q_BILLDataGridView.Rows.Count - 1).ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("דוח חשבונית של לקוח", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(200, 100));
            e.Graphics.DrawLine(p, new Point(200, 150), new Point(600, 150));

            e.Graphics.DrawString(" שם לקוח: " + id_clientComboBox.Text, new Font("Ariel", 12, FontStyle.Bold), Brushes.Black, new Point(510, 160));

            int i = 0, j;
            int x = 45, y = 200;
            int w = q_BILLDataGridView.Columns[0].Width, h = q_BILLDataGridView.Rows[0].Height;

            while (i < q_BILLDataGridView.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y, q_BILLDataGridView.Columns[0].Width, q_BILLDataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(q_BILLDataGridView.Columns[i].HeaderText.ToString(), new Font("Ariel", 8, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < q_BILLDataGridView.Rows.Count - 1)
            {
                x = 45; y += 30;
                w = 100; h = 30;
                j = 0;
                while (j < q_BILLDataGridView.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(q_BILLDataGridView.Rows[i].Cells[j].FormattedValue.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x += 100;
                }
                i++;
            }
            int Abc = int.Parse(q_BILLDataGridView.Rows.Count.ToString());
            e.Graphics.DrawString(Abc - 1 + "   :סך חשבוניות פלאפונים מלקוח זה", new Font("Ariel", 15, FontStyle.Bold), Brushes.Black, new Point(200, y + 50));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("דוח חשבונית של עובד", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(200, 100));
            e.Graphics.DrawLine(p, new Point(200, 150), new Point(600, 150));

            e.Graphics.DrawString(" שם עובד: " + w_idComboBox.Text, new Font("Ariel", 12, FontStyle.Bold), Brushes.Black, new Point(510, 160));

            int i = 0, j;
            int x = 45, y = 200;
            int w = q_BILLDataGridView.Columns[0].Width, h = q_BILLDataGridView.Rows[0].Height;

            while (i < q_BILLDataGridView.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y, q_BILLDataGridView.Columns[0].Width, q_BILLDataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(q_BILLDataGridView.Columns[i].HeaderText.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < q_BILLDataGridView.Rows.Count - 1)
            {
                x = 45; y += 30;
                w = 100; h = 30;
                j = 0;
                while (j < q_BILLDataGridView.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(q_BILLDataGridView.Rows[i].Cells[j].FormattedValue.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x += 100;
                }
                i++;
            }
            int Abc = int.Parse(q_BILLDataGridView.Rows.Count.ToString());
            e.Graphics.DrawString(Abc - 1 + "   :סך חשבוניות פלאפונים שהדפיס העובד", new Font("Ariel", 15, FontStyle.Bold), Brushes.Black, new Point(200, y + 50));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult p = printDialog1.ShowDialog();
            if (p.Equals(DialogResult.OK))
                printDocument1.Print();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult p = printDialog2.ShowDialog();
            if (p.Equals(DialogResult.OK))
                printDocument2.Print();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            printPreviewDialog3.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult p = printDialog3.ShowDialog();
            if (p.Equals(DialogResult.OK))
                printDocument3.Print();
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("דוח חשבונית של פלאפון", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(200, 100));
            e.Graphics.DrawLine(p, new Point(200, 150), new Point(630, 150));

            e.Graphics.DrawString(" שם פלאפון: " + id_pComboBox.Text, new Font("Ariel", 12, FontStyle.Bold), Brushes.Black, new Point(510, 160));

            int i = 0, j;
            int x = 45, y = 200;
            int w = q_BILLDataGridView.Columns[0].Width, h = q_BILLDataGridView.Rows[0].Height;

            while (i < q_BILLDataGridView.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y, q_BILLDataGridView.Columns[0].Width, q_BILLDataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(q_BILLDataGridView.Columns[i].HeaderText.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < q_BILLDataGridView.Rows.Count - 1)
            {
                x = 45; y += 30;
                w = 100; h = 30;
                j = 0;
                while (j < q_BILLDataGridView.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(q_BILLDataGridView.Rows[i].Cells[j].FormattedValue.ToString(), new Font("Ariel", 7, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x += 100;
                }
                i++;
            }
            int Abc = int.Parse(q_BILLDataGridView.Rows.Count.ToString());
            e.Graphics.DrawString(Abc - 1 + "   :סך חשבוניות פלאפונים מסוג זה", new Font("Ariel", 15, FontStyle.Bold), Brushes.Black, new Point(200, y + 50));
        }
        }
    }
