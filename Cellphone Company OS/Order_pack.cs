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
    public partial class Order_pack : Form
    {
        public Order_pack()
        {
            InitializeComponent();
        }

        private void Order_pack_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_pack' table. You can move, or remove it, as needed.
            this.t_packTableAdapter.Fill(this.phonesSAGIVDataSet.t_pack);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_client' table. You can move, or remove it, as needed.
            this.t_clientTableAdapter.Fill(this.phonesSAGIVDataSet.t_client);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_worker' table. You can move, or remove it, as needed.
            this.t_workerTableAdapter.Fill(this.phonesSAGIVDataSet.t_worker);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_order_pack' table. You can move, or remove it, as needed.
            this.t_order_packTableAdapter.Fill(this.phonesSAGIVDataSet.t_order_pack);
            label1.Text = "";
            label6.Text = "";
            label8.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            t_order_packBindingSource1.AddNew();
            pack_dateDateTimePicker.Value = DateTime.Today;
            int max = 0, num;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_order_pack.Rows.Count; i++)
            {
                num = int.Parse(this.phonesSAGIVDataSet.t_order_pack.Rows[i][0].ToString());
                if (num > max)
                    max = num;
            }
            max++;
            id_order_packTextBox.Text = max.ToString();

            label1.Text = "";
            label6.Text = "";
            label8.Text = "";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool flag = true;

            if (id_wComboBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(id_wComboBox, "חובה לבחור עובד");
            }
            else
            {
                flag = true;
                errorProvider1.SetError(id_wComboBox, "");

            }
            if (id_clientComboBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(id_clientComboBox, "חובה לבחור קליינט");
            }
            else
            {
                flag = true;
                errorProvider1.SetError(id_clientComboBox, "");
            }



            if (id_packComboBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(id_packComboBox, "חובה לבחור חבילה");
            }
            else
            {
                flag = true;
                errorProvider1.SetError(id_packComboBox, "");
            }




            string s = maskedTextBox1.Text;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] >= '0' && s[i] <= '9')
                    count++;
            if ((count != 10) || (maskedTextBox1.Text == "(   )    -"))
            {
                flag = false;
                errorProvider1.SetError(maskedTextBox1, "חובה להזין מס פלאפון חוקי");
            }
            else
            {
                flag = true;
                errorProvider1.SetError(maskedTextBox1, "");
                string s1 = maskedTextBox1.Text;
                for (int i = 0; i < phonesSAGIVDataSet.t_order_pack.Rows.Count; i++)
                {
                    if (phonesSAGIVDataSet.t_order_pack.Rows[i][5].ToString().Equals(s1))
                    {
                        flag = false;
                        MessageBox.Show("כבר קיים");
                    }
                }
            }

            if (flag)
            {

                t_order_packBindingSource1.EndEdit();
                this.t_order_packTableAdapter.Update(this.phonesSAGIVDataSet.t_order_pack);
                MessageBox.Show("הזמנת חבילה עברה בהצלחה");


            }
            else
                MessageBox.Show("לא חוקי");


        }

        private void id_clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = id_clientComboBox.Text;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_client.Rows.Count; i++)
                if (this.phonesSAGIVDataSet.t_client.Rows[i][0].Equals(s))
                    label1.Text = this.phonesSAGIVDataSet.t_client.Rows[i][1].ToString();

        }

        private void id_wComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = id_wComboBox.Text;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_worker.Rows.Count; i++)
                if (this.phonesSAGIVDataSet.t_worker.Rows[i][0].Equals(s))
                    label8.Text = this.phonesSAGIVDataSet.t_worker.Rows[i][1].ToString();

        }

        private void id_packComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = id_packComboBox.Text;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_pack.Rows.Count; i++)
                if (this.phonesSAGIVDataSet.t_pack.Rows[i][0].Equals(s))
                    label6.Text = this.phonesSAGIVDataSet.t_pack.Rows[i][1].ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            t_order_packBindingSource1.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t_order_packBindingSource1.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t_order_packBindingSource1.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t_order_packBindingSource1.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.phonesSAGIVDataSet.t_pack);
            dv.RowFilter = string.Format("name_pack Like '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.t_order_packTableAdapter.Fill(this.phonesSAGIVDataSet.t_order_pack);
            t_order_packDataGridView.Refresh();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("דוח הזמנת חבילות", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(200, 100));
            e.Graphics.DrawLine(p, new Point(200, 150), new Point(530, 150));

            int i = 0, j;
            int x = 100, y = 200;
            int w = 100, h = 30;
            while (i < phonesSAGIVDataSet.t_order_pack.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(phonesSAGIVDataSet.t_order_pack.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < phonesSAGIVDataSet.t_order_pack.Rows.Count)
            {
                x = 100;
                y += 30;
                w = 100;
                h = 30;
                j = 0;
                while (j < phonesSAGIVDataSet.t_order_pack.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(phonesSAGIVDataSet.t_order_pack.Rows[i][j].ToString(), new Font("Ariel", 7, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x = x + 100;
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

        private void button11_Click(object sender, EventArgs e)
        {
            searchBillPack f15 = new searchBillPack();
            f15.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            chartpack f115 = new chartpack();
            f115.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
