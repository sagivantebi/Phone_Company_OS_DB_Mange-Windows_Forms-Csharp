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
    public partial class Phone_sold : Form
    {
        public Phone_sold()
        {
            InitializeComponent();
        }

        private void Phone_sold_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.Q_Num_sold' table. You can move, or remove it, as needed.
            this.q_Num_soldTableAdapter.Fill(this.phonesSAGIVDataSet.Q_Num_sold);
            chart1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart1.Series["Num_sold"].Points.Clear();
            string x, x1;
            int y;
            for (int i = 0; i < phonesSAGIVDataSet.Q_Num_sold.Rows.Count; i++)
            {
                x = phonesSAGIVDataSet.Q_Num_sold.Rows[i][1].ToString();
                x1 = phonesSAGIVDataSet.Q_Num_sold.Rows[i][2].ToString();
                y = int.Parse(x1);
                chart1.Series["Num_sold"].Points.AddXY(x, y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("דוח כמות מכירות מכל מוצר", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(100, 100));
            e.Graphics.DrawLine(p, new Point(120, 150), new Point(620, 150));

            int i = 0, j;
            int x = 270, y = 200;
            int w = 100, h = 30;
            while (i < phonesSAGIVDataSet.Q_Num_sold.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(phonesSAGIVDataSet.Q_Num_sold.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < phonesSAGIVDataSet.Q_Num_sold.Rows.Count)
            {
                x = 270;
                y += 30;
                w = 100;
                h = 30;
                j = 0;
                while (j < phonesSAGIVDataSet.Q_Num_sold.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(phonesSAGIVDataSet.Q_Num_sold.Rows[i][j].ToString(), new Font("Ariel", 6, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x = x + 100;
                }
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult p = printDialog1.ShowDialog();
            if (p.Equals(DialogResult.OK))
                printDocument1.Print();
        }
    }
}
