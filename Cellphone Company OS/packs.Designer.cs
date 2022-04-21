namespace SaGiVproject
{
    partial class packs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_packLabel;
            System.Windows.Forms.Label name_packLabel;
            System.Windows.Forms.Label price_packLabel;
            System.Windows.Forms.Label tokefLabel;
            System.Windows.Forms.Label num_callsLabel;
            System.Windows.Forms.Label num_smsLabel;
            System.Windows.Forms.Label num_internetLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(packs));
            this.tpackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonesSAGIVDataSet = new SaGiVproject.phonesSAGIVDataSet();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.t_packTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.t_packTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableAdapterManager = new SaGiVproject.phonesSAGIVDataSetTableAdapters.TableAdapterManager();
            this.id_packTextBox = new System.Windows.Forms.TextBox();
            this.name_packTextBox = new System.Windows.Forms.TextBox();
            this.price_packTextBox = new System.Windows.Forms.TextBox();
            this.tokefComboBox = new System.Windows.Forms.ComboBox();
            this.num_callsTextBox = new System.Windows.Forms.TextBox();
            this.num_smsTextBox = new System.Windows.Forms.TextBox();
            this.num_internetTextBox = new System.Windows.Forms.TextBox();
            this.t_packDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            id_packLabel = new System.Windows.Forms.Label();
            name_packLabel = new System.Windows.Forms.Label();
            price_packLabel = new System.Windows.Forms.Label();
            tokefLabel = new System.Windows.Forms.Label();
            num_callsLabel = new System.Windows.Forms.Label();
            num_smsLabel = new System.Windows.Forms.Label();
            num_internetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tpackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_packDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_packLabel
            // 
            id_packLabel.AutoSize = true;
            id_packLabel.Location = new System.Drawing.Point(384, 19);
            id_packLabel.Name = "id_packLabel";
            id_packLabel.Size = new System.Drawing.Size(67, 13);
            id_packLabel.TabIndex = 64;
            id_packLabel.Text = ":מקט חבילה";
            // 
            // name_packLabel
            // 
            name_packLabel.AutoSize = true;
            name_packLabel.Location = new System.Drawing.Point(384, 45);
            name_packLabel.Name = "name_packLabel";
            name_packLabel.Size = new System.Drawing.Size(62, 13);
            name_packLabel.TabIndex = 66;
            name_packLabel.Text = ":שם חבילה";
            // 
            // price_packLabel
            // 
            price_packLabel.AutoSize = true;
            price_packLabel.Location = new System.Drawing.Point(167, 98);
            price_packLabel.Name = "price_packLabel";
            price_packLabel.Size = new System.Drawing.Size(35, 13);
            price_packLabel.TabIndex = 68;
            price_packLabel.Text = ":מחיר";
            // 
            // tokefLabel
            // 
            tokefLabel.AutoSize = true;
            tokefLabel.Location = new System.Drawing.Point(384, 74);
            tokefLabel.Name = "tokefLabel";
            tokefLabel.Size = new System.Drawing.Size(36, 13);
            tokefLabel.TabIndex = 70;
            tokefLabel.Text = ":תוקף";
            // 
            // num_callsLabel
            // 
            num_callsLabel.AutoSize = true;
            num_callsLabel.Location = new System.Drawing.Point(165, 19);
            num_callsLabel.Name = "num_callsLabel";
            num_callsLabel.Size = new System.Drawing.Size(72, 13);
            num_callsLabel.TabIndex = 72;
            num_callsLabel.Text = ":כמות שיחות";
            // 
            // num_smsLabel
            // 
            num_smsLabel.AutoSize = true;
            num_smsLabel.Location = new System.Drawing.Point(165, 45);
            num_smsLabel.Name = "num_smsLabel";
            num_smsLabel.Size = new System.Drawing.Size(81, 13);
            num_smsLabel.TabIndex = 74;
            num_smsLabel.Text = ":כמות מסרונים";
            // 
            // num_internetLabel
            // 
            num_internetLabel.AutoSize = true;
            num_internetLabel.Location = new System.Drawing.Point(165, 71);
            num_internetLabel.Name = "num_internetLabel";
            num_internetLabel.Size = new System.Drawing.Size(73, 13);
            num_internetLabel.TabIndex = 76;
            num_internetLabel.Text = ":כמות גלישה";
            // 
            // tpackBindingSource
            // 
            this.tpackBindingSource.DataMember = "t_pack";
            this.tpackBindingSource.DataSource = this.phonesSAGIVDataSet;
            // 
            // phonesSAGIVDataSet
            // 
            this.phonesSAGIVDataSet.DataSetName = "phonesSAGIVDataSet";
            this.phonesSAGIVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(377, 269);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 64;
            this.button8.Text = "עדכון";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(219, 298);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 63;
            this.button7.Text = "שמירה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(268, 269);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 62;
            this.button6.Text = "רענון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(155, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 61;
            this.button5.Text = "חדש";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 60;
            this.button4.Text = "אחרון";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 59;
            this.button3.Text = "קודם";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 58;
            this.button2.Text = "הבא";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "ראשון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_packTableAdapter
            // 
            this.t_packTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.t_bill_downTableAdapter = null;
            this.tableAdapterManager.t_bill_headTableAdapter = null;
            this.tableAdapterManager.t_bill_sapakTableAdapter = null;
            this.tableAdapterManager.t_billdeat_sapakTableAdapter = null;
            this.tableAdapterManager.t_clientTableAdapter = null;
            this.tableAdapterManager.t_order_fixTableAdapter = null;
            this.tableAdapterManager.t_order_packTableAdapter = null;
            this.tableAdapterManager.t_packTableAdapter = this.t_packTableAdapter;
            this.tableAdapterManager.t_phonesTableAdapter = null;
            this.tableAdapterManager.t_sapakTableAdapter = null;
            this.tableAdapterManager.t_takalaTableAdapter = null;
            this.tableAdapterManager.t_typesTableAdapter = null;
            this.tableAdapterManager.t_workerTableAdapter = null;
            this.tableAdapterManager.t_yazTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SaGiVproject.phonesSAGIVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // id_packTextBox
            // 
            this.id_packTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tpackBindingSource, "id_pack", true));
            this.id_packTextBox.Enabled = false;
            this.id_packTextBox.Location = new System.Drawing.Point(255, 16);
            this.id_packTextBox.Name = "id_packTextBox";
            this.id_packTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_packTextBox.TabIndex = 65;
            // 
            // name_packTextBox
            // 
            this.name_packTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tpackBindingSource, "name_pack", true));
            this.name_packTextBox.Location = new System.Drawing.Point(255, 42);
            this.name_packTextBox.Name = "name_packTextBox";
            this.name_packTextBox.Size = new System.Drawing.Size(121, 20);
            this.name_packTextBox.TabIndex = 67;
            this.name_packTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_packTextBox_KeyPress);
            // 
            // price_packTextBox
            // 
            this.price_packTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tpackBindingSource, "price_pack", true));
            this.price_packTextBox.Location = new System.Drawing.Point(38, 95);
            this.price_packTextBox.Name = "price_packTextBox";
            this.price_packTextBox.Size = new System.Drawing.Size(121, 20);
            this.price_packTextBox.TabIndex = 69;
            // 
            // tokefComboBox
            // 
            this.tokefComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tpackBindingSource, "tokef", true));
            this.tokefComboBox.FormattingEnabled = true;
            this.tokefComboBox.Items.AddRange(new object[] {
            "חודש אחד",
            "שלושה חודשים",
            "חצי שנה",
            "תשעה חודשים",
            "שנה",
            "שנה וחצי",
            "שנתיים"});
            this.tokefComboBox.Location = new System.Drawing.Point(255, 71);
            this.tokefComboBox.Name = "tokefComboBox";
            this.tokefComboBox.Size = new System.Drawing.Size(121, 21);
            this.tokefComboBox.TabIndex = 71;
            // 
            // num_callsTextBox
            // 
            this.num_callsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tpackBindingSource, "num_calls", true));
            this.num_callsTextBox.Location = new System.Drawing.Point(38, 19);
            this.num_callsTextBox.Name = "num_callsTextBox";
            this.num_callsTextBox.Size = new System.Drawing.Size(121, 20);
            this.num_callsTextBox.TabIndex = 73;
            this.num_callsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_callsTextBox_KeyPress);
            // 
            // num_smsTextBox
            // 
            this.num_smsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tpackBindingSource, "num_sms", true));
            this.num_smsTextBox.Location = new System.Drawing.Point(38, 45);
            this.num_smsTextBox.Name = "num_smsTextBox";
            this.num_smsTextBox.Size = new System.Drawing.Size(121, 20);
            this.num_smsTextBox.TabIndex = 75;
            this.num_smsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_smsTextBox_KeyPress);
            // 
            // num_internetTextBox
            // 
            this.num_internetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tpackBindingSource, "num_internet", true));
            this.num_internetTextBox.Location = new System.Drawing.Point(38, 71);
            this.num_internetTextBox.Name = "num_internetTextBox";
            this.num_internetTextBox.Size = new System.Drawing.Size(121, 20);
            this.num_internetTextBox.TabIndex = 77;
            // 
            // t_packDataGridView
            // 
            this.t_packDataGridView.AutoGenerateColumns = false;
            this.t_packDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_packDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.t_packDataGridView.DataSource = this.tpackBindingSource;
            this.t_packDataGridView.Enabled = false;
            this.t_packDataGridView.Location = new System.Drawing.Point(10, 121);
            this.t_packDataGridView.Name = "t_packDataGridView";
            this.t_packDataGridView.Size = new System.Drawing.Size(744, 142);
            this.t_packDataGridView.TabIndex = 77;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_pack";
            this.dataGridViewTextBoxColumn1.HeaderText = "מקט חבילה";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_pack";
            this.dataGridViewTextBoxColumn2.HeaderText = "שם חבילה";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price_pack";
            this.dataGridViewTextBoxColumn3.HeaderText = "מחיר חבילה";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tokef";
            this.dataGridViewTextBoxColumn4.HeaderText = "תוקף";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "num_calls";
            this.dataGridViewTextBoxColumn5.HeaderText = "כמות שיחות";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "num_sms";
            this.dataGridViewTextBoxColumn6.HeaderText = "כמות מסרונים";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "num_internet";
            this.dataGridViewTextBoxColumn7.HeaderText = "כמות גלישה";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(608, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 94;
            this.label7.Text = "עובד";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(549, 298);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(135, 23);
            this.button10.TabIndex = 101;
            this.button10.Text = "הדפס דוח חבילות";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(549, 269);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(135, 23);
            this.button9.TabIndex = 100;
            this.button9.Text = "הצג דוח חבילות";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // packs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SaGiVproject.Properties.Resources.cool_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 340);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t_packDataGridView);
            this.Controls.Add(id_packLabel);
            this.Controls.Add(this.id_packTextBox);
            this.Controls.Add(name_packLabel);
            this.Controls.Add(this.name_packTextBox);
            this.Controls.Add(price_packLabel);
            this.Controls.Add(this.price_packTextBox);
            this.Controls.Add(tokefLabel);
            this.Controls.Add(this.tokefComboBox);
            this.Controls.Add(num_callsLabel);
            this.Controls.Add(this.num_callsTextBox);
            this.Controls.Add(num_smsLabel);
            this.Controls.Add(this.num_smsTextBox);
            this.Controls.Add(num_internetLabel);
            this.Controls.Add(this.num_internetTextBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "packs";
            this.Text = "טבלת חבילות";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tpackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_packDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private phonesSAGIVDataSet phonesSAGIVDataSet;
        private System.Windows.Forms.BindingSource tpackBindingSource;
        private phonesSAGIVDataSetTableAdapters.t_packTableAdapter t_packTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox id_packTextBox;
        private System.Windows.Forms.TextBox name_packTextBox;
        private System.Windows.Forms.TextBox price_packTextBox;
        private System.Windows.Forms.ComboBox tokefComboBox;
        private System.Windows.Forms.TextBox num_callsTextBox;
        private System.Windows.Forms.TextBox num_smsTextBox;
        private System.Windows.Forms.TextBox num_internetTextBox;
        private phonesSAGIVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView t_packDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}