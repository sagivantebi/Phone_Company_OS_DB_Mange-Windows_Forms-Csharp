﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaGiVproject
{
    public partial class types : Form
    {
        public types()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_yaz' table. You can move, or remove it, as needed.
            this.t_yazTableAdapter.Fill(this.phonesSAGIVDataSet.t_yaz);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_types' table. You can move, or remove it, as needed.
            this.t_typesTableAdapter.Fill(this.phonesSAGIVDataSet.t_types);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ttypesBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ttypesBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ttypesBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ttypesBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ttypesBindingSource.MoveLast();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ttypesBindingSource.EndEdit();
            this.t_typesTableAdapter.Update(this.phonesSAGIVDataSet.t_types);
            MessageBox.Show("פרטייך נקלטו בהצלחה");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.t_typesTableAdapter.Fill(this.phonesSAGIVDataSet.t_types);
            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            if (textBox1.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(textBox1, "הקלד סוג פלאפון");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");

                if (flag1)
                {
                    ttypesBindingSource.EndEdit();
                    this.t_typesTableAdapter.Update(this.phonesSAGIVDataSet.t_types);
                    MessageBox.Show("פרטייך נקלטו בהצלחה");
                }
                else
                    MessageBox.Show("טופס לא תקין");
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
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
            e.Graphics.DrawString("דוח דגמים", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(300, 100));
            e.Graphics.DrawLine(p, new Point(300, 150), new Point(500, 150));

            int i = 0, j;
            int x = 360, y = 200;
            int w = 100, h = 30;
            while (i < phonesSAGIVDataSet.t_types.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(phonesSAGIVDataSet.t_types.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < phonesSAGIVDataSet.t_types.Rows.Count)
            {
                x = 360;
                y += 30;
                w = 100;
                h = 30;
                j = 0;
                while (j < phonesSAGIVDataSet.t_types.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(phonesSAGIVDataSet.t_types.Rows[i][j].ToString(), new Font("Ariel", 6, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x = x + 100;
                }
                i++;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            t_yazBindingSource.MoveFirst();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            t_yazBindingSource.MoveNext();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            t_yazBindingSource.MovePrevious();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            t_yazBindingSource.MoveLast();
        }
    }
}
