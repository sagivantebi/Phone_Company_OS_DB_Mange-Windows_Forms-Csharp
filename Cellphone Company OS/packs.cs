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
    public partial class packs : Form
    {
        public packs()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_pack' table. You can move, or remove it, as needed.
            this.t_packTableAdapter.Fill(this.phonesSAGIVDataSet.t_pack);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tpackBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tpackBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tpackBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tpackBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tpackBindingSource.AddNew();
            int max = 0, num;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_pack.Rows.Count; i++)
            {
                num = int.Parse(this.phonesSAGIVDataSet.t_pack.Rows[i][0].ToString());
                if (num > max)
                    max = num;
            }
            max++;
            id_packTextBox.Text = max.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.t_packTableAdapter.Fill(this.phonesSAGIVDataSet.t_pack);
            t_packDataGridView.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool flag1 = true;

            if (name_packTextBox.Text == "")
                {
                    flag1 = false;
                    errorProvider1.SetError(name_packTextBox, "הקלד שם חבילה");
                }
                else
                errorProvider1.SetError(name_packTextBox, "");


            if (price_packTextBox.Text == "")
                {
                    flag1 = false;
                    errorProvider1.SetError(price_packTextBox, "הקלד מחיר");
                }
                else
                errorProvider1.SetError(price_packTextBox, "");


            if (tokefComboBox.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(tokefComboBox, "חובה לבחור תוקף");
            }
            else
            {
                flag1 = true;
                errorProvider1.SetError(tokefComboBox, "");
        }



            if (num_callsTextBox.Text == "")
                {
                    flag1 = false;
                    errorProvider1.SetError(num_callsTextBox, "הקלד מספר שיחות");
                }
                else
                errorProvider1.SetError(num_callsTextBox, "");



            if (num_smsTextBox.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(num_smsTextBox, "הקלד כמות מסרונים");
            }
            else
                errorProvider1.SetError(num_smsTextBox, "");


            if (num_internetTextBox.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(num_internetTextBox, "הקלד כמות חבילת גלישה");
            }
            else
                errorProvider1.SetError(num_internetTextBox, "");



                if (flag1)
                {
                    tpackBindingSource.EndEdit();
                    this.t_packTableAdapter.Update(this.phonesSAGIVDataSet.t_pack);
                    MessageBox.Show("פרטייך נקלטו בהצלחה");
                }
                else
                    MessageBox.Show("טופס לא תקין");


            }
         private void button8_Click(object sender, EventArgs e)
        {
            bool flag1 = true;

            if (name_packTextBox.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(name_packTextBox, "הקלד שם חבילה");
            }
            else
                errorProvider1.SetError(name_packTextBox, "");


            if (price_packTextBox.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(price_packTextBox, "הקלד מחיר");
            }
            else
                errorProvider1.SetError(price_packTextBox, "");


            if (tokefComboBox.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(tokefComboBox, "חובה לבחור תוקף");
            }
            else
            {
                flag1 = true;
                errorProvider1.SetError(tokefComboBox, "");
            }



            if (num_callsTextBox.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(num_callsTextBox, "הקלד מספר שיחות");
            }
            else
                errorProvider1.SetError(num_callsTextBox, "");



            if (num_smsTextBox.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(num_smsTextBox, "הקלד כמות מסרונים");
            }
            else
                errorProvider1.SetError(num_smsTextBox, "");


            if (num_internetTextBox.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(num_internetTextBox, "הקלד כמות חבילת גלישה");
            }
            else
                errorProvider1.SetError(num_internetTextBox, "");



            if (flag1)
            {
                tpackBindingSource.EndEdit();
                this.t_packTableAdapter.Update(this.phonesSAGIVDataSet.t_pack);
                MessageBox.Show("פרטייך נקלטו בהצלחה");
            }
            else
                MessageBox.Show("טופס לא תקין");

         }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'א' && e.KeyChar <= 'ת') || e.KeyChar == ' ' || e.KeyChar == 8))
            {
                e.Handled = true;
                MessageBox.Show("בעברית בלבד");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'א' && e.KeyChar <= 'ת') || e.KeyChar == ' ' || e.KeyChar == 8))
            {
                e.Handled = true;
                MessageBox.Show("בעברית בלבד");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ' ' || e.KeyChar == 8))
            {
                e.Handled = true;
                MessageBox.Show("מספרים בלבד");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ' ' || e.KeyChar == 8))
            {
                e.Handled = true;
                MessageBox.Show("מספרים בלבד");
            }
        }

        private void num_callsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8)))
            {
                e.Handled = true;
                MessageBox.Show("ספרות בלבד");
            }
        }

        private void num_smsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8)))
            {
                e.Handled = true;
                MessageBox.Show("ספרות בלבד");
            }
        }

        private void name_packTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'א' && e.KeyChar <= 'ת') || e.KeyChar == ' ' || e.KeyChar == 8))
            {
                e.Handled = true;
                MessageBox.Show("בעברית בלבד");
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
            e.Graphics.DrawString("דוח חבילות", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(300, 100));
            e.Graphics.DrawLine(p, new Point(300, 150), new Point(510, 150));

            int i = 0, j;
            int x = 100, y = 200;
            int w = 100, h = 30;
            while (i < phonesSAGIVDataSet.t_pack.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(phonesSAGIVDataSet.t_pack.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < phonesSAGIVDataSet.t_pack.Rows.Count)
            {
                x = 100;
                y += 30;
                w = 100;
                h = 30;
                j = 0;
                while (j < phonesSAGIVDataSet.t_pack.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(phonesSAGIVDataSet.t_pack.Rows[i][j].ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x = x + 100;
                }
                i++;
            }
                   
        }
    }
       
}
