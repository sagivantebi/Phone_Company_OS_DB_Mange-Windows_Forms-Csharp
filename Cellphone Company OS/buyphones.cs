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
    public partial class buyphones : Form
    {
        
        public buyphones()
        {
            InitializeComponent();
        }

        private void buyphones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_bill_down' table. You can move, or remove it, as needed.
            this.t_bill_downTableAdapter1.Fill(this.phonesSAGIVDataSet.t_bill_down);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_phones' table. You can move, or remove it, as needed.
            this.t_phonesTableAdapter1.Fill(this.phonesSAGIVDataSet.t_phones);
           
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_client' table. You can move, or remove it, as needed.
            this.t_clientTableAdapter1.Fill(this.phonesSAGIVDataSet.t_client);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_worker' table. You can move, or remove it, as needed.
            this.t_workerTableAdapter1.Fill(this.phonesSAGIVDataSet.t_worker);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_bill_head' table. You can move, or remove it, as needed.
            this.t_bill_headTableAdapter.Fill(this.phonesSAGIVDataSet.t_bill_head);






            bill_dateDateTimePicker.Value = DateTime.Today;
            label1.Text = "";
            label2.Text = "";
            label4.Text = "";
            label6.Text = "";
        }

        private void id_phoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            t_bill_downBindingSource.AddNew();
            id_billTextBox.Text = id_billTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t_bill_downBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t_bill_downBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t_bill_downBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t_bill_downBindingSource.MoveLast();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            t_bill_headBindingSource.MoveFirst();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            t_bill_headBindingSource.MoveNext();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            t_bill_headBindingSource.MovePrevious();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            t_bill_headBindingSource.MoveLast();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            t_bill_headBindingSource.AddNew();
            int max = 0, num;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_bill_head.Rows.Count; i++)
            {
                num = int.Parse(this.phonesSAGIVDataSet.t_bill_head.Rows[i][0].ToString());
                if (num > max)
                    max = num;
            }
            max++;
            id_billTextBox1.Text = max.ToString();
            label1.Text = "";
            label2.Text = "";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            bool flag = true;

            if (w_idComboBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(w_idComboBox, "חובה לבחור עובד");
            }
            else
            {
                flag = true;
                errorProvider1.SetError(w_idComboBox, "");

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

            if (bill_dateDateTimePicker.Value.ToShortDateString() != DateTime.Today.ToShortDateString())
            {
                flag = false;
                errorProvider1.SetError(bill_dateDateTimePicker, "תאריך לא תקין");
            }
            else
            {
                flag = true;
                errorProvider1.SetError(bill_dateDateTimePicker, "");

            }
            if (flag)
            {

                t_bill_headBindingSource.EndEdit();
                this.t_bill_headTableAdapter.Update(this.phonesSAGIVDataSet.t_bill_head);
                MessageBox.Show("חשבונית נקלטה בהצלחה");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.phonesSAGIVDataSet.t_phones);
            dv.RowFilter = string.Format("yaz_p  Like '%{0}%' or type_p Like '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;
        }

        private void id_billTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_phoneComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            t_bill_downBindingSource.AddNew();
            id_billTextBox.Text = id_billTextBox1.Text;
            bill_dateDateTimePicker.Value = DateTime.Today;

            label4.Text = "";
            label6.Text = "";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            t_bill_downBindingSource.MoveFirst();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            t_bill_downBindingSource.MoveNext();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            t_bill_downBindingSource.MovePrevious();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            t_bill_downBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool flag = true;

            if (id_phoneComboBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(id_phoneComboBox, "חובה לבחור פלאפון");
            }
            else
            {
                flag = true;
                errorProvider1.SetError(id_phoneComboBox, "");

            }
            int k = int.Parse(amountTextBox.Text);
            int k1 = int.Parse(label3.Text);
            if (k <= 0 || k > k1)
            {
                flag = false;
                MessageBox.Show("כמות לא תקינה");
                errorProvider1.SetError(amountTextBox, "חובה לבחור פלאפון");
            }
            else
            {
                errorProvider1.SetError(amountTextBox, "");
                flag = true;

            }



            if (flag)
            {
                t_bill_downBindingSource.EndEdit();
                t_bill_downTableAdapter1.Update(this.phonesSAGIVDataSet.t_bill_down);
                MessageBox.Show("חשבונית נקלטה בהצלחה");
            }
            else
                MessageBox.Show("טופס לא תקין");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string s = id_phoneComboBox.Text;
            double p = 0;
            int a = int.Parse(amountTextBox.Text);
            for (int i = 0; i < this.phonesSAGIVDataSet.t_phones.Rows.Count; i++)
            {
                if (this.phonesSAGIVDataSet.t_phones.Rows[i][0].Equals(s))
                    p = double.Parse(this.phonesSAGIVDataSet.t_phones.Rows[i][7].ToString());

            }
            priceTextBox.Text = (p * a).ToString();

        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '8') || (e.KeyChar == 8)))
            {
                e.Handled = true;
                MessageBox.Show("ספרות בלבד ,וכמות הזמנה עד 8 פלאפונים");
            }
        }

        private void w_idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = w_idComboBox.Text;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_worker.Rows.Count; i++)
                if (this.phonesSAGIVDataSet.t_worker.Rows[i][0].Equals(s))
                    label2.Text = this.phonesSAGIVDataSet.t_worker.Rows[i][1].ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s1 = t_bill_downDataGridView.CurrentRow.Cells[1].Value.ToString();
            int num = int.Parse(t_bill_downDataGridView.CurrentRow.Cells[2].Value.ToString());
            int num2, total_num = 0;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_phones.Rows.Count; i++)
            {
                if (this.phonesSAGIVDataSet.t_phones.Rows[i][0].Equals(s1))
                {
                    num2 = int.Parse(this.phonesSAGIVDataSet.t_phones.Rows[i][6].ToString());
                    total_num = num2 - num;
                    DialogResult d = MessageBox.Show("אתה עומד לעדכן נתונים, האם אתה בטוח?", "אזהרה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        this.phonesSAGIVDataSet.t_phones.Rows[i][6] = total_num;
                        this.t_phonesTableAdapter1.Update(this.phonesSAGIVDataSet.t_phones);
                    }



                }


            }

        }

        private void id_billTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.t_bill_downTableAdapter1.Fill(this.phonesSAGIVDataSet.t_bill_down);
            dataGridView1.Refresh();
        }

        private void id_billTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = id_clientComboBox.Text;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_client.Rows.Count; i++)
                if (this.phonesSAGIVDataSet.t_client.Rows[i][0].Equals(s))
                    label1.Text = this.phonesSAGIVDataSet.t_client.Rows[i][1].ToString();
        }

        private void id_phoneComboBox_SelectedIndexChanged_2(object sender, EventArgs e)
        {

            string s = id_phoneComboBox.Text;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_phones.Rows.Count; i++)
                if (this.phonesSAGIVDataSet.t_phones.Rows[i][0].Equals(s))
                {
                    label4.Text = this.phonesSAGIVDataSet.t_phones.Rows[i][1].ToString() + "  " + this.phonesSAGIVDataSet.t_phones.Rows[i][2].ToString();
                    label6.Text = "כמות במלאי: ";
                    label3.Text = this.phonesSAGIVDataSet.t_phones.Rows[i][6].ToString();
                }
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        public string mlai { get; set; }

        public int m { get; set; }

        private void button18_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult p = printDialog1.ShowDialog();
            if (p.Equals(DialogResult.OK))
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("דוח חשבונית הזמנת פלאפון", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(200, 100));
            e.Graphics.DrawLine(p, new Point(200, 150), new Point(710, 150));

            e.Graphics.DrawString(id_billTextBox1.Text+ ":מקט חשבונית", new Font("Ariel", 12, FontStyle.Bold), Brushes.Black, new Point(600, 185));
            e.Graphics.DrawString(w_idComboBox.Text + " :תעודת זהות עובד", new Font("Ariel", 12, FontStyle.Bold), Brushes.Black, new Point(536, 210));
            e.Graphics.DrawString(bill_dateDateTimePicker.Text + " :תאריך חשבונית", new Font("Ariel", 12, FontStyle.Bold), Brushes.Black, new Point(510, 235));
            e.Graphics.DrawString(" תז לקוח: "+id_clientComboBox.Text, new Font("Ariel", 12, FontStyle.Bold), Brushes.Black, new Point(510, 260));

            int i = 0, j;
            int x = 70, y = 250;
            int w = t_bill_downDataGridView.Columns[0].Width, h = t_bill_downDataGridView.Rows[0].Height;
  
            while (i < t_bill_downDataGridView.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y, t_bill_downDataGridView.Columns[0].Width, t_bill_downDataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(t_bill_downDataGridView.Columns[i].HeaderText.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 100;
            }
            i = 0;
            while (i < t_bill_downDataGridView.Rows.Count - 1)
            {
                x = 70; y += 30;
                w = 100; h = 30;
                j = 0;
                while (j < t_bill_downDataGridView.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(t_bill_downDataGridView.Rows[i].Cells[j].FormattedValue.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x += 100;
                }
                i++;
            }

            int Abc = int.Parse(t_bill_downDataGridView.Rows.Count.ToString());
            e.Graphics.DrawString(Abc-1 + "   :סך הזמנות פלאפונים", new Font("Ariel", 15, FontStyle.Bold), Brushes.Black, new Point(200, y + 50));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Phone_sold f = new Phone_sold();
            f.Show();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            searchbill1 f1 = new searchbill1();
            f1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            chartMOSTexpansive f56 = new chartMOSTexpansive();
            f56.Show();
        }

    

       

        }
}
