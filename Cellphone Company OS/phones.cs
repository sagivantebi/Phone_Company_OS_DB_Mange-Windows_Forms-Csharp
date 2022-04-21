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
    public partial class phones : Form
    {
        public phones()
        {
            InitializeComponent();
        }

        private void t_phonesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_phonesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phonesSAGIVDataSet);

        }

        private void phones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_types' table. You can move, or remove it, as needed.
            this.t_typesTableAdapter.Fill(this.phonesSAGIVDataSet.t_types);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_yaz' table. You can move, or remove it, as needed.
            this.t_yazTableAdapter.Fill(this.phonesSAGIVDataSet.t_yaz);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_phones' table. You can move, or remove it, as needed.
            this.t_phonesTableAdapter.Fill(this.phonesSAGIVDataSet.t_phones);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t_phonesBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t_phonesBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t_phonesBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t_phonesBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            t_phonesBindingSource.AddNew();
            yaz_pComboBox.Enabled = true;
            type_pComboBox.Enabled = true;
            int max = 0, num;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_phones.Rows.Count; i++)
            {
                num = int.Parse(this.phonesSAGIVDataSet.t_phones.Rows[i][0].ToString());
                if (num > max)
                    max = num;
            }
            max++;
            id_pTextBox.Text = max.ToString();

        }

        private void amount_pTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8)))
            {
                e.Handled = true;
                MessageBox.Show("ספרות בלבד");
            }
        }

        private void price_pTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8)))
            {
                e.Handled = true;
                MessageBox.Show("ספרות בלבד");
            }
        }

        private void color_pTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'א' && e.KeyChar <= 'ת') || e.KeyChar == ' ' || e.KeyChar == 8))
            {
                e.Handled = true;
                MessageBox.Show("בעברית בלבד");
            }
        }

        private void color_pTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool flag = true;

            if (yaz_pComboBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(yaz_pComboBox, "חובה לבחור יצרן");
            }
            else
            {
                flag = true;
                errorProvider1.SetError(yaz_pComboBox, "");

            }
            if (type_pComboBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(type_pComboBox, "חובה לבחור סוג");
            }
            else
            {
                flag = true;
                errorProvider1.SetError(type_pComboBox, "");
            }
            if (color_pTextBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(color_pTextBox, "הקלד צבע");
            }
            else
            {
                errorProvider1.SetError(color_pTextBox, "");
                flag = true;
            }
            if (year_pTextBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(year_pTextBox, "הקלד שנת הוצאה");
            }
            else
            {
                errorProvider1.SetError(year_pTextBox, "");
                flag = true;
            }
            if (amount_pTextBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(amount_pTextBox, "הקלד כמות במלאי");
            }
            else
            {
                errorProvider1.SetError(amount_pTextBox, "");
                flag = true;
            }
            if (price_pTextBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(price_pTextBox, "הקלד מחיר ליחידה");
            }
            else
            {
                errorProvider1.SetError(price_pTextBox, "");
                flag = true;
            }


                  if ( information_pTextBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError( information_pTextBox, "הקלד מידע");
            }
            else
            {
                errorProvider1.SetError( information_pTextBox, "");
                flag = true;
            }



           



            if (flag)
            {

                t_phonesBindingSource.EndEdit();
                this.t_phonesTableAdapter.Update(this.phonesSAGIVDataSet.t_phones);
                MessageBox.Show("פלאפון נקלט בהצלחה");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
             this.t_phonesTableAdapter.Fill(this.phonesSAGIVDataSet.t_phones);
             t_phonesDataGridView.Refresh();
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool flag = true;

            if (yaz_pComboBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(yaz_pComboBox, "חובה לבחור יצרן");
            }
            else
            {
                flag = true;
                errorProvider1.SetError(yaz_pComboBox, "");

            }
            if (type_pComboBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(type_pComboBox, "חובה לבחור סוג");
            }
            else
            {
                flag = true;
                errorProvider1.SetError(type_pComboBox, "");
            }
            if (color_pTextBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(color_pTextBox, "הקלד צבע");
            }
            else
            {
                errorProvider1.SetError(color_pTextBox, "");
                flag = true;
            }
            if (year_pTextBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(year_pTextBox, "הקלד שנת הוצאה");
            }
            else
            {
                errorProvider1.SetError(year_pTextBox, "");
                flag = true;
            }
            if (amount_pTextBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(amount_pTextBox, "הקלד כמות במלאי");
            }
            else
            {
                errorProvider1.SetError(amount_pTextBox, "");
                flag = true;
            }
            if (price_pTextBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(price_pTextBox, "הקלד מחיר ליחידה");
            }
            else
            {
                errorProvider1.SetError(price_pTextBox, "");
                flag = true;
            }


            if (information_pTextBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(information_pTextBox, "הקלד מידע");
            }
            else
            {
                errorProvider1.SetError(information_pTextBox, "");
                flag = true;
            }







            if (flag)
            {

                t_phonesBindingSource.EndEdit();
                this.t_phonesTableAdapter.Update(this.phonesSAGIVDataSet.t_phones);
                MessageBox.Show("פלאפון נקלט בהצלחה");

            }

        }

        private void year_pTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("דוח פלאפונים", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(300, 100));
            e.Graphics.DrawLine(p, new Point(300, 150), new Point(565, 150));

            int i = 0, j;
            int x = 85, y = 200;
            int w = 75, h = 30;
            while (i < phonesSAGIVDataSet.t_phones.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(phonesSAGIVDataSet.t_phones.Columns[i].ColumnName.ToString(), new Font("Ariel", 7, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 75;
            }
            i = 0;
            while (i < phonesSAGIVDataSet.t_phones.Rows.Count)
            {
                x = 85;
                y += 30;
                w = 75;
                h = 30;
                j = 0;
                while (j < phonesSAGIVDataSet.t_phones.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(phonesSAGIVDataSet.t_phones.Rows[i][j].ToString(), new Font("Ariel", 6, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x = x + 75;
                }
                i++;
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
    }
}
