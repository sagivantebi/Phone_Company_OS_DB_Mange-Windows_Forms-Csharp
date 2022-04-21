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
    public partial class sapaks : Form
    {
        public sapaks()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_sapak' table. You can move, or remove it, as needed.
            this.t_sapakTableAdapter.Fill(this.phonesSAGIVDataSet.t_sapak);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_order_pack' table. You can move, or remove it, as needed.
            this.t_order_packTableAdapter.Fill(this.phonesSAGIVDataSet.t_order_pack);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tsapakBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tsapakBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tsapakBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tsapakBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tsapakBindingSource.AddNew();
            maskedTextBox1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.t_sapakTableAdapter.Fill(this.phonesSAGIVDataSet.t_sapak);
            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            string s123=maskedTextBox1.Text;
            int count8=0;
            for (int i=0;i<s123.Length;i++)
            {
                if(s123[i]>='0' && s123[i]<='9')
                    count8++;
            }
            if (count8!=9)
            {
                flag1 = false;
                errorProvider1.SetError(maskedTextBox1, "תעודת זהות 9 ספרות");
            }
            else
            {
                flag1 = true;
                errorProvider1.SetError(maskedTextBox1, "");
                string s = maskedTextBox1.Text;
                for (int i = 0; i < phonesSAGIVDataSet.t_sapak.Rows.Count; i++)
                {
                    if (phonesSAGIVDataSet.t_sapak.Rows[i][0].ToString().Equals(s))
                    {
                        flag1 = false;
                        MessageBox.Show("כבר קיים");
                    }
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
     


                string s12 = maskedTextBox2.Text;
                int count2 = 0;
                for (int i2 = 0; i2 < s12.Length; i2++)
                    if (s12[i2] >= '0' && s12[i2] <= '9')
                        count2++;
                if ((count2 != 10) || (maskedTextBox2.Text == "(   )    -"))
                {
                    flag1 = false;
                    errorProvider1.SetError(maskedTextBox2, "חובה להזין מס פלאפון חוקי");
                }



                if (textBox1.Text == "")
                {
                    flag1 = false;
                    errorProvider1.SetError(textBox1, "הקלד שם ספק");
                }
                else
                {
                    errorProvider1.SetError(textBox1, "");

                }
                if (textBox2.Text == "")
                {
                    flag1 = false;
                    errorProvider1.SetError(textBox2, "הקלד שם כתובת");
                }
                else
                {
                    errorProvider1.SetError(textBox2, "");

                }
                if (textBox5.Text == "")
                {
                    flag1 = false;
                    errorProvider1.SetError(textBox5, "הקלד שם אימייל");
                }
                else
                {
                    errorProvider1.SetError(textBox5, "");

                }



                if (flag1)
                {
                    tsapakBindingSource.EndEdit();
                    this.t_sapakTableAdapter.Update(this.phonesSAGIVDataSet.t_sapak);
                    MessageBox.Show("פרטייך נקלטו בהצלחה");
                }
                else
                    MessageBox.Show("טופס לא תקין");
            }
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


            string s2 = maskedTextBox2.Text;
            int count2 = 0;
            for (int i = 0; i < s2.Length; i++)
                if (s2[i] >= '0' && s2[i] <= '9')
                    count2++;
            if (count != 10)
            {
                flag1 = false;
                errorProvider1.SetError(maskedTextBox2, "חובה להקליד מס פלאפון תקין");
            }
            else
            {
                flag1 = true;
                errorProvider1.SetError(maskedTextBox2, "");
            }


            if (textBox1.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(textBox1, "הקלד שם ספק");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                flag1 = true;
            }
            if (textBox2.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(textBox2, "הקלד שם כתובת");
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
                flag1 = true;
            }
            if (textBox5.Text == "")
            {
                flag1 = false;
                errorProvider1.SetError(textBox5, "הקלד שם אימייל");
            }
            else
            {
                errorProvider1.SetError(textBox5, "");
                flag1 = true;
            }



            if (flag1)
            {
                tsapakBindingSource.EndEdit();
                this.t_sapakTableAdapter.Update(this.phonesSAGIVDataSet.t_sapak);
                MessageBox.Show("פרטייך נקלטו בהצלחה");
            }
            else
                MessageBox.Show("טופס לא תקין");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
            e.Graphics.DrawString("דוח ספקים", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(300, 100));
            e.Graphics.DrawLine(p, new Point(300, 150), new Point(500, 150));

            int i = 0, j;
            int x = 100, y = 200;
            int w = 100, h = 30;
            while (i < phonesSAGIVDataSet.t_sapak.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray,new Rectangle(x,y,w,h));
                e.Graphics.DrawRectangle(p,new Rectangle(x,y,w,h));
                e.Graphics.DrawString(phonesSAGIVDataSet.t_sapak.Columns[i].ColumnName.ToString(),new Font("Ariel",10,FontStyle.Regular),Brushes.Black,new Rectangle(x+20,y,w,h));
                i++;
                x=x+100;
            }
            i=0;
            while(i < phonesSAGIVDataSet.t_sapak.Rows.Count)
            {
                x=100;
                y+=30;
                w=100;
                h=30;
                j=0;
                while(j < phonesSAGIVDataSet.t_sapak.Columns.Count)
                {
                     e.Graphics.DrawRectangle(p,new Rectangle(x,y,w,h));
                    e.Graphics.DrawString(phonesSAGIVDataSet.t_sapak.Rows[i][j].ToString(),new Font("Ariel",6,FontStyle.Regular),Brushes.Black,new Rectangle(x+20,y,w,h));
                    j++;
                    x=x+100;
                }
                i++;
            }
                   
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = (int)e.KeyChar;
            if(!((e.KeyChar>='a'&& e.KeyChar<='z')||(e.KeyChar>='A' && e.KeyChar<='Z')||(e.KeyChar=='.')||(e.KeyChar=='@')||(e.KeyChar>='0' && e.KeyChar<='9')||(x==8)||(e.KeyChar == '_')))
            {
                e.Handled = true;
                MessageBox.Show("ניתן להקליד רק ספרות,ואותיות באנגלית");

            }
        }
    }
}

            
       

