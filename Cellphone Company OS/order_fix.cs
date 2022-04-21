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
    public partial class order_fix : Form
    {
        public order_fix()
        {
            InitializeComponent();
        }

        private void t_order_fixBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_order_fixBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phonesSAGIVDataSet);

        }

        private void order_fix_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_takala' table. You can move, or remove it, as needed.
            this.t_takalaTableAdapter.Fill(this.phonesSAGIVDataSet.t_takala);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_worker' table. You can move, or remove it, as needed.
            this.t_workerTableAdapter.Fill(this.phonesSAGIVDataSet.t_worker);
           
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_client' table. You can move, or remove it, as needed.
            this.t_clientTableAdapter.Fill(this.phonesSAGIVDataSet.t_client);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_phones' table. You can move, or remove it, as needed.
            this.t_phonesTableAdapter.Fill(this.phonesSAGIVDataSet.t_phones);
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.t_order_fix' table. You can move, or remove it, as needed.
            this.t_order_fixTableAdapter.Fill(this.phonesSAGIVDataSet.t_order_fix);
            label1.Text = "";
            label2.Text = "";
            label4.Text = "";
            label3.Text = "";
    

        }

        private void button8_Click(object sender, EventArgs e)
        {
            t_order_fixBindingSource.AddNew();
            int max = 0, num;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_order_fix.Rows.Count; i++)
            {
                num = int.Parse(this.phonesSAGIVDataSet.t_order_fix.Rows[i][0].ToString());
                if (num > max)
                    max = num;
            }
            max++;
            id_order_fixTextBox.Text = max.ToString();
            label1.Text = "";
            label2.Text = "";
            label4.Text = "";
            label3.Text = "";
            if (sentCheckBox.Checked == false)
                date_takeDateTimePicker.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            t_order_fixBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t_order_fixBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t_order_fixBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t_order_fixBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
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


            if (id_pComboBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(id_pComboBox, "חובה לבחור סוג פלאפון");
            }
            else
            {
                flag = true;
                errorProvider1.SetError(id_pComboBox, "");

            }


      


            if (num_takComboBox.Text == "")
            {
                flag = false;
                errorProvider1.SetError(num_takComboBox, "חובה לבחור מספר תקלה");
            }
            else
            {
                flag = true;
                errorProvider1.SetError(num_takComboBox, "");

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

      
       
                if (flag)
                {

                    t_order_fixBindingSource.EndEdit();
                    this.t_order_fixTableAdapter.Update(this.phonesSAGIVDataSet.t_order_fix);
                    MessageBox.Show("נקלט בהצלחה");

                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.phonesSAGIVDataSet.t_phones);
            dv.RowFilter = string.Format("yaz_p  Like '%{0}%' or type_p Like '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.phonesSAGIVDataSet.t_takala);
            dv.RowFilter = string.Format("tak_name  Like '%{0}%'", textBox2.Text);
            dataGridView1.DataSource = dv;
        }

        private void id_pLabel_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.t_order_fixTableAdapter.Fill(this.phonesSAGIVDataSet.t_order_fix);
            t_order_fixDataGridView.Refresh();
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s = num_takComboBox.Text;
            int p = 0;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_takala.Rows.Count; i++)
            {
                if (this.phonesSAGIVDataSet.t_takala.Rows[i][0].Equals(s))
                    p = int.Parse(this.phonesSAGIVDataSet.t_takala.Rows[i][2].ToString());

            }
            priceTextBox.Text = p.ToString();

        }

        private void id_clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = id_clientComboBox.Text;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_client.Rows.Count; i++)
                if (this.phonesSAGIVDataSet.t_client.Rows[i][0].Equals(s))
                    label1.Text = this.phonesSAGIVDataSet.t_client.Rows[i][1].ToString();
        }

        private void w_idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = w_idComboBox.Text;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_worker.Rows.Count; i++)
                if (this.phonesSAGIVDataSet.t_worker.Rows[i][0].Equals(s))
                    label2.Text = this.phonesSAGIVDataSet.t_worker.Rows[i][1].ToString();
        }

        private void id_pComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = id_pComboBox.Text;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_phones.Rows.Count; i++)
                if (this.phonesSAGIVDataSet.t_phones.Rows[i][0].Equals(s))
                    label4.Text = this.phonesSAGIVDataSet.t_phones.Rows[i][1].ToString() + "  " + this.phonesSAGIVDataSet.t_phones.Rows[i][2].ToString();
        }

 

        private void num_takComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s =num_takComboBox.Text;
            for (int i = 0; i < this.phonesSAGIVDataSet.t_takala.Rows.Count; i++)
                if (this.phonesSAGIVDataSet.t_takala.Rows[i][0].Equals(s))
                    label3.Text = this.phonesSAGIVDataSet.t_takala.Rows[i][1].ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("דוח הזמנת תקונים", new Font("Ariel", 30, FontStyle.Bold), Brushes.Red, new Point(300, 100));
            e.Graphics.DrawLine(p, new Point(300, 150), new Point(650, 150));

            int i = 0, j;
            int x = 10, y = 200;
            int w = 75, h = 30;
            while (i < phonesSAGIVDataSet.t_order_fix.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));
                e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                e.Graphics.DrawString(phonesSAGIVDataSet.t_order_fix.Columns[i].ColumnName.ToString(), new Font("Ariel", 7, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                i++;
                x = x + 75;
            }
            i = 0;
            while (i < phonesSAGIVDataSet.t_order_fix.Rows.Count)
            {
                x = 10;
                y += 30;
                w = 75;
                h = 30;
                j = 0;
                while (j < phonesSAGIVDataSet.t_order_fix.Columns.Count)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, w, h));
                    e.Graphics.DrawString(phonesSAGIVDataSet.t_order_fix.Rows[i][j].ToString(), new Font("Ariel", 6, FontStyle.Regular), Brushes.Black, new Rectangle(x + 20, y, w, h));
                    j++;
                    x = x + 75;
                }
                i++;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult p = printDialog1.ShowDialog();
            if (p.Equals(DialogResult.OK))
                printDocument1.Print();
       
        }

        private void sentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
