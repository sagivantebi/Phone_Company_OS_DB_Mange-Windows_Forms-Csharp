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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_yaz' table. You can move, or remove it, as needed.
            this.t_yazTableAdapter.Fill(this.phonesSAGIVDataSet.t_yaz);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tyazBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tyazBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tyazBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tyazBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tyazBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.t_yazTableAdapter.Fill(this.phonesSAGIVDataSet.t_yaz);
            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            if (textBox1.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(textBox1, "הקלד שם תקלה");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                
                if (flag1)
                {
                    tyazBindingSource.EndEdit();
                    this.t_yazTableAdapter.Update(this.phonesSAGIVDataSet.t_yaz);
                    MessageBox.Show("פרטייך נקלטו בהצלחה");
                }
                else
                    MessageBox.Show("טופס לא תקין");


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
              bool flag1 = true;
              if (textBox1.Text == "")
              {
                  flag1 = false;
                  errorProvider1.SetError(textBox1, "הקלד שם יצרן");
              }
              else
              {
                  errorProvider1.SetError(textBox1, "");

                  if (flag1)
                  {
                      tyazBindingSource.EndEdit();
                      this.t_yazTableAdapter.Update(this.phonesSAGIVDataSet.t_yaz);
                      MessageBox.Show("פרטייך נקלטו בהצלחה");
                  }
              }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult p = printDialog1.ShowDialog();
            if (p.Equals(DialogResult.OK))
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("דוח יצרנים", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(300, 100));
            e.Graphics.DrawLine(p, new Point(300, 150), new Point(500, 150));

            int i = 0, j;
            int x = 360, y = 200;
            int w = 100, h = 30;
            while (i < phonesSAGIVDataSet.t_yaz.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(phonesSAGIVDataSet.t_yaz.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < phonesSAGIVDataSet.t_yaz.Rows.Count)
            {
                x = 360;
                y += 30;
                w = 100;
                h = 30;
                j = 0;
                while (j < phonesSAGIVDataSet.t_yaz.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(phonesSAGIVDataSet.t_yaz.Rows[i][j].ToString(), new Font("Ariel", 6, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x = x + 100;
                }
                i++;
            }
        }
    }
}
