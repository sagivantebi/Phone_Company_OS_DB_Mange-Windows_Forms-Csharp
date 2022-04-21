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
    public partial class startpage : Form
    {
        public startpage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool flag = false;
            string s1, s2;
            s1 = textBox1.Text.ToString();
            s2 = textBox2.Text.ToString();
            if (s1.Equals("admin1") && s2.Equals("111"))
            {
                flag = true;
                ttables ft = new ttables();
                ft.Show();
                this.Hide();
            }

            if (s1.Equals("admin2") && s2.Equals("222"))
            {
                flag = true;
                ttables2 ft2 = new ttables2();
                ft2.Show();
                this.Hide();
            }
           if(flag==false)
                MessageBox.Show("שם משתמש או סיסמא לא נכונים");



        }

        private void startpage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesSAGIVDataSet.Q_BILLS' table. You can move, or remove it, as needed.
            this.q_BILLSTableAdapter.Fill(this.phonesSAGIVDataSet.Q_BILLS);

        }
    }
}
