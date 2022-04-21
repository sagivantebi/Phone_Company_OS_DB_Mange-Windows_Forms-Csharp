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
    public partial class chartwpacks : Form
    {
        public chartwpacks()
        {
            InitializeComponent();
        }

        private void chartwpacks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.Q_bestWpacks' table. You can move, or remove it, as needed.
            this.q_bestWpacksTableAdapter.Fill(this.phonesSAGIVDataSet.Q_bestWpacks);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("דוח כמות מכירות חבילות של כל עובד", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(40, 100));
            e.Graphics.DrawLine(p, new Point(40, 150), new Point(740, 150));

            int i = 0, j;
            int x = 270, y = 200;
            int w = 100, h = 30;
            while (i < phonesSAGIVDataSet.Q_bestWpacks.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(phonesSAGIVDataSet.Q_bestWpacks.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < phonesSAGIVDataSet.Q_bestWpacks.Rows.Count)
            {
                x = 270;
                y += 30;
                w = 100;
                h = 30;
                j = 0;
                while (j < phonesSAGIVDataSet.Q_bestWpacks.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(phonesSAGIVDataSet.Q_bestWpacks.Rows[i][j].ToString(), new Font("Ariel", 6, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x = x + 100;
                }
                i++;
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult p = printDialog1.ShowDialog();
            if (p.Equals(DialogResult.OK))
                printDocument1.Print();
        }
    }
}
