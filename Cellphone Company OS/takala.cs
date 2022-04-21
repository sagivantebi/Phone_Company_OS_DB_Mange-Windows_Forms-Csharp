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
    public partial class takala : Form
    {
        public takala()
        {
            InitializeComponent();
        }

        private void t_takalaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_takalaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phonesSAGIVDataSet);

        }

        private void takala_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_takala' table. You can move, or remove it, as needed.
            this.t_takalaTableAdapter.Fill(this.phonesSAGIVDataSet.t_takala);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            t_takalaBindingSource.AddNew();
            int max = 0, num;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_takala.Rows.Count; i++)
            {
                num = int.Parse(this.phonesSAGIVDataSet.t_takala.Rows[i][0].ToString());
                if (num > max)
                    max = num;
            }
            max++;
            num_takTextBox.Text = max.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t_takalaBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t_takalaBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t_takalaBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t_takalaBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool flag1 = true;

            if (tak_nameTextBox.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(tak_nameTextBox, "הקלד שם תקלה");
            }
            else
                errorProvider1.SetError(tak_nameTextBox, "");


            if (priceTextBox.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(priceTextBox, "הקלד מחיר");
            }
            else
                errorProvider1.SetError(priceTextBox, "");


            if (flag1)
            {
                t_takalaBindingSource.EndEdit();
                this.t_takalaTableAdapter.Update(this.phonesSAGIVDataSet.t_takala);
                MessageBox.Show("פרטייך נקלטו בהצלחה");
            }
            else
                MessageBox.Show("טופס לא תקין");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.t_takalaTableAdapter.Fill(this.phonesSAGIVDataSet.t_takala);
            t_takalaDataGridView.Refresh();
        }

        private void tak_nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'א' && e.KeyChar <= 'ת') || e.KeyChar == ' ' || e.KeyChar == 8))
            {
                e.Handled = true;
                MessageBox.Show("בעברית בלבד");
            }
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8)))
            {
                e.Handled = true;
                MessageBox.Show("ספרות בלבד");
            }
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
            e.Graphics.DrawString("דוח תקלות", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(300, 100));
            e.Graphics.DrawLine(p, new Point(300, 150), new Point(500, 150));

            int i = 0, j;
            int x = 270, y = 200;
            int w = 100, h = 30;
            while (i < phonesSAGIVDataSet.t_takala.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(phonesSAGIVDataSet.t_takala.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < phonesSAGIVDataSet.t_takala.Rows.Count)
            {
                x = 270;
                y += 30;
                w = 100;
                h = 30;
                j = 0;
                while (j < phonesSAGIVDataSet.t_takala.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(phonesSAGIVDataSet.t_takala.Rows[i][j].ToString(), new Font("Ariel", 6, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x = x + 100;
                }
                i++;
            }
        }
    }
}
