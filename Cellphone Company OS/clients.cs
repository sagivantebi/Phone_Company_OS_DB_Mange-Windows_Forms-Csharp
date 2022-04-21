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
    public partial class clients : Form
    {
        public clients()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_client' table. You can move, or remove it, as needed.
            this.t_clientTableAdapter.Fill(this.phonesSAGIVDataSet.t_client);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tclientBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tclientBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tclientBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tclientBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Enabled = true;
            tclientBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.t_clientTableAdapter.Fill(this.phonesSAGIVDataSet.t_client);
            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool flag1 = true;

            if ((maskedTextBox1.Text == "" )||( maskedTextBox1.Text.Length != 9))
            {
                flag1 = false;
                errorProvider1.SetError(maskedTextBox1, "תעודת זהות 9 ספרות");
            }
            else
            {

                errorProvider1.SetError(maskedTextBox1, "");
                string s = maskedTextBox1.Text;
                for (int i = 0; i < phonesSAGIVDataSet.t_client.Rows.Count; i++)
                {
                    if (phonesSAGIVDataSet.t_client.Rows[i][0].ToString().Equals(s))
                    {
                        flag1 = false;
                        MessageBox.Show("כבר קיים");
                    }
                }
            }





            if (textBox1.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(textBox1, "הקלד שם לקוח");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
         
            }




            string s1 = maskedTextBox4.Text;
            int count = 0;
            for (int i = 0; i < s1.Length; i++)
                if (s1[i] >= '0' && s1[i] <= '9')
                    count++;
            if ((count != 10) || (maskedTextBox4.Text == "(   )    -"))
            {
                flag1 = false;
                errorProvider1.SetError(maskedTextBox4, "חובה להזין מס פלאפון חוקי");
            }
            else
            {
                flag1 = true;
                errorProvider1.SetError(maskedTextBox4, "");
                for (int i = 0; i < phonesSAGIVDataSet.t_client.Rows.Count; i++)
                {
                    if (phonesSAGIVDataSet.t_client.Rows[i][3].ToString().Equals(s1))
                    {
                        flag1 = false;
                        MessageBox.Show("כבר קיים");
                    }
                }
            }



            if (textBox5.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(textBox5, "הקלד כתובת");
            }
            else
            {
                errorProvider1.SetError(textBox5, "");
      
            }



            if (flag1)
            {
                tclientBindingSource.EndEdit();
                this.t_clientTableAdapter.Update(this.phonesSAGIVDataSet.t_client);
                MessageBox.Show("פרטייך נקלטו בהצלחה");
            }
            else
                MessageBox.Show("טופס לא תקין");
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ' ' || e.KeyChar == 8))
            {
                e.Handled = true;
                MessageBox.Show("מספרים בלבד");
            }
        }

        private void maskedTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ' ' || e.KeyChar == 8))
            {
                e.Handled = true;
                MessageBox.Show("מספרים בלבד");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'א' && e.KeyChar <= 'ת') || e.KeyChar == ' ' || e.KeyChar == 8))
            {
                e.Handled = true;
                MessageBox.Show("בעברית בלבד");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            if (maskedTextBox1.Text == "" || maskedTextBox1.Text.Length != 9)
            {
                flag1 = false;
                errorProvider1.SetError(maskedTextBox1, "תעודת זהות 9 ספרות");
            }
            else
            {
                errorProvider1.SetError(maskedTextBox1, "");
                string s = maskedTextBox1.Text;
                for (int i = 0; i < phonesSAGIVDataSet.t_client.Rows.Count; i++)
                {
                    if (phonesSAGIVDataSet.t_client.Rows[i][0].ToString().Equals(s))
                    {
                        flag1 = false;
                        MessageBox.Show("כבר קיים");
                    }
                    else
                        flag1 = true;
                }
            }
            if (textBox1.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(textBox1, "הקלד שם לקוח");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                flag1 = true;
            }
            string s1 = maskedTextBox4.Text;
            int count = 0;
            for (int i = 0; i < s1.Length; i++)
                if (s1[i] >= '0' && s1[i] <= '9')
                    count++;
            if (count != 10)
            {
                flag1 = false;
                errorProvider1.SetError(maskedTextBox4, "חובה להקליד מס פלאפון תקין");
            }
            else
            {
                flag1 = true;
                errorProvider1.SetError(maskedTextBox4, "");
            }
            if (textBox5.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(textBox5, "הקלד כתובת");
            }
            else
            {
                errorProvider1.SetError(textBox5, "");
                flag1 = true;
            }



            if (flag1)
            {
                tclientBindingSource.EndEdit();
                this.t_clientTableAdapter.Update(this.phonesSAGIVDataSet.t_client);
                MessageBox.Show("פרטייך נקלטו בהצלחה");
            }
            else
                MessageBox.Show("טופס לא תקין");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            e.Graphics.DrawString("דוח לקוחות", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(300, 100));
            e.Graphics.DrawLine(p, new Point(300, 150), new Point(500, 150));

            int i = 0, j;
            int x = 200, y = 200;
            int w = 100, h = 30;
            while (i < phonesSAGIVDataSet.t_client.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(phonesSAGIVDataSet.t_client.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < phonesSAGIVDataSet.t_client.Rows.Count)
            {
                x = 200;
                y += 30;
                w = 100;
                h = 30;
                j = 0;
                while (j < phonesSAGIVDataSet.t_client.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(phonesSAGIVDataSet.t_client.Rows[i][j].ToString(), new Font("Ariel", 7, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x = x + 100;
                }
                i++;
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
