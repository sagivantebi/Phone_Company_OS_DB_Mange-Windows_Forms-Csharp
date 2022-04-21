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
    public partial class order_sapak : Form
    {
        public order_sapak()
        {
            InitializeComponent();
        }

        private void t_bill_sapakBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_bill_sapakBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phonesSAGIVDataSet);
    
        }

        private void order_sapak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_phones' table. You can move, or remove it, as needed.
            this.t_phonesTableAdapter.Fill(this.phonesSAGIVDataSet.t_phones);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_sapak' table. You can move, or remove it, as needed.
            this.t_sapakTableAdapter.Fill(this.phonesSAGIVDataSet.t_sapak);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_billdeat_sapak' table. You can move, or remove it, as needed.
            this.t_billdeat_sapakTableAdapter.Fill(this.phonesSAGIVDataSet.t_billdeat_sapak);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_bill_sapak' table. You can move, or remove it, as needed.
            this.t_bill_sapakTableAdapter.Fill(this.phonesSAGIVDataSet.t_bill_sapak);
            label2.Text = "";
            label4.Text = "";
            label6.Text = "";
            label5.Text = "";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            t_bill_sapakBindingSource.MoveFirst();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bool flag = true;
           

            if (dateTimePicker1.Value.ToShortDateString() != DateTime.Today.ToShortDateString())
            {
                flag = false;
                errorProvider1.SetError(dateTimePicker1, "תאריך לא תקין");
            }
            else
            {
          
                errorProvider1.SetError(dateTimePicker1, "");

            }
            if (id_sapakComboBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(id_sapakComboBox, "חובה לבחור ספק");
            }
            else
            {
           
                errorProvider1.SetError(id_sapakComboBox, "");
            }
           if (flag)
            {

                t_bill_sapakBindingSource.EndEdit();
                this.t_bill_sapakTableAdapter.Update(this.phonesSAGIVDataSet.t_bill_sapak);  
                MessageBox.Show("חשבונית נקלטה בהצלחה");  
            }
           else
               MessageBox.Show("קלט לא תקין");
       
      
        }

        private void button14_Click(object sender, EventArgs e)
        {
            t_bill_sapakBindingSource.AddNew();
            int max = 0, num;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_bill_sapak.Rows.Count; i++)
            {
                num = int.Parse(this.phonesSAGIVDataSet.t_bill_sapak.Rows[i][0].ToString());
                if (num > max)
                    max = num;
            }
            max++;
            id_bill_sTextBox.Text = max.ToString();
            id_sapakComboBox.Enabled = true;
            label2.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            t_bill_sapakBindingSource.MoveNext();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            t_bill_sapakBindingSource.MovePrevious();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            t_bill_sapakBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.t_billdeat_sapakTableAdapter.Fill(this.phonesSAGIVDataSet.t_billdeat_sapak);
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            t_billdeat_sapakBindingSource1.MoveFirst();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            t_billdeat_sapakBindingSource1.AddNew();
            id_bill_sTextBox1.Text = id_bill_sTextBox.Text;

            label4.Text = "";
            label6.Text = "";
            label5.Text = "";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            t_billdeat_sapakBindingSource1.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t_billdeat_sapakBindingSource1.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t_billdeat_sapakBindingSource1.MoveLast();
        }

        private void id_bill_sTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string s = id_pComboBox.Text;
            double p = 0;
            int a = int.Parse(amountTextBox.Text);
            for (int i = 0; i < this.phonesSAGIVDataSet.t_phones.Rows.Count; i++)
            {
                if (this.phonesSAGIVDataSet.t_phones.Rows[i][0].Equals(s))
                    p = double.Parse(this.phonesSAGIVDataSet.t_phones.Rows[i][7].ToString());


            }
            if (a >= 3)
            {
                if ((a >= 3) && (a <= 7))
                {
                    priceTextBox.Text = ((p * a) * 0.9).ToString();
                    label5.Text = "הנחה של 10 אחוזים";
                }
                if ((a >= 8) && (a <= 12))
                {
                    priceTextBox.Text = ((p * a) * 0.8).ToString();
                    label5.Text = "הנחה של 20 אחוזים";
                    if (a == 12)
                        MessageBox.Show("יותר משתלם להזמין 13 מוצרים");

                }
                if (a >= 13)
                {
                    priceTextBox.Text = ((p * a) * 0.7).ToString();
                    label5.Text = "הנחה של 30 אחוזים";
                }
            }
            else
            priceTextBox.Text = (p * a).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool flag = true;

            if (id_pComboBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(id_pComboBox, "חובה לבחור פלאפון");
            }
            else
            {
                errorProvider1.SetError(id_pComboBox, "");

            }
            if (amountTextBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(amountTextBox, "אין להשאיר שדה ריק");
            }
            else
            {
                errorProvider1.SetError(amountTextBox, "");

            }

            
            if (flag)
            {


                t_billdeat_sapakBindingSource1.EndEdit();
                this.t_billdeat_sapakTableAdapter.Update(this.phonesSAGIVDataSet.t_billdeat_sapak);

                MessageBox.Show("חשבונית נקלטה בהצלחה");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.phonesSAGIVDataSet.t_phones);
            dv.RowFilter = string.Format("yaz_p  Like '%{0}%' or type_p Like '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8)))
            {
                e.Handled = true;
                MessageBox.Show("ספרות בלבד");
            }
        }

        private void id_sapakComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = id_sapakComboBox.Text;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_sapak.Rows.Count; i++)
                if (this.phonesSAGIVDataSet.t_sapak.Rows[i][0].Equals(s))
                    label2.Text = this.phonesSAGIVDataSet.t_sapak.Rows[i][1].ToString();
        }

        private void id_pComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = id_pComboBox.Text;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_phones.Rows.Count; i++)
                if (this.phonesSAGIVDataSet.t_phones.Rows[i][0].Equals(s))
                {
                    label6.Text = "כמות במלאי: " + this.phonesSAGIVDataSet.t_phones.Rows[i][6].ToString();
                    label4.Text = this.phonesSAGIVDataSet.t_phones.Rows[i][1].ToString() + "  " + this.phonesSAGIVDataSet.t_phones.Rows[i][2].ToString();
                }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s1 = t_billdeat_sapakDataGridView.CurrentRow.Cells[1].Value.ToString();
            int num = int.Parse(t_billdeat_sapakDataGridView.CurrentRow.Cells[2].Value.ToString());
            int num2, total_num = 0;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_phones.Rows.Count; i++)
            {
                if (this.phonesSAGIVDataSet.t_phones.Rows[i][0].Equals(s1))
                {
                    num2 = int.Parse(this.phonesSAGIVDataSet.t_phones.Rows[i][6].ToString());
                    total_num = num2 + num;
                    DialogResult d = MessageBox.Show("אתה עומד לעדכן נתונים, האם אתה בטוח?", "אזהרה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        this.phonesSAGIVDataSet.t_phones.Rows[i][6] = total_num;
                        this.t_phonesTableAdapter.Update(this.phonesSAGIVDataSet.t_phones);
                    }



                }
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
             printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("דוח חשבונית הזמנת מספק", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(200, 100));
            e.Graphics.DrawLine(p, new Point(200, 150), new Point(710, 150));

            e.Graphics.DrawString(id_bill_sTextBox.Text+ ":מקט חשבונית", new Font("Ariel", 12, FontStyle.Bold), Brushes.Black, new Point(600, 185));
            e.Graphics.DrawString(dateTimePicker1.Text + " :תאריך חשבונית", new Font("Ariel", 12, FontStyle.Bold), Brushes.Black, new Point(510, 235));
            e.Graphics.DrawString(" תז ספק: "+id_sapakComboBox.Text, new Font("Ariel", 12, FontStyle.Bold), Brushes.Black, new Point(510, 260));

            int i = 0, j;
            int x = 70, y = 250;
            int w = t_billdeat_sapakDataGridView.Columns[0].Width, h = t_billdeat_sapakDataGridView.Rows[0].Height;
  
            while (i < t_billdeat_sapakDataGridView.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y, t_billdeat_sapakDataGridView.Columns[0].Width, t_billdeat_sapakDataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(t_billdeat_sapakDataGridView.Columns[i].HeaderText.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < t_billdeat_sapakDataGridView.Rows.Count - 1)
            {
                x = 70; y += 30;
                w = 100; h = 30;
                j = 0;
                while (j < t_billdeat_sapakDataGridView.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(t_billdeat_sapakDataGridView.Rows[i].Cells[j].FormattedValue.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x += 100;
                }
                i++;
            }
            int Abc = int.Parse(t_billdeat_sapakDataGridView.Rows.Count.ToString());
            e.Graphics.DrawString(Abc - 1 + "   :סך הזמנות סוגי פלאפונים מספק", new Font("Ariel", 15, FontStyle.Bold), Brushes.Black, new Point(200, y + 50));
        }

        private void button13_Click(object sender, EventArgs e)
        {
             DialogResult p = printDialog1.ShowDialog();
            if (p.Equals(DialogResult.OK))
                printDocument1.Print();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            searchbillsapak f1 = new searchbillsapak();
            f1.Show();
        }

        }
    }
