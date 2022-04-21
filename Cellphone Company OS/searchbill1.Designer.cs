namespace SaGiVproject
{
    partial class searchbill1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchbill1));
            this.phonesSAGIVDataSet = new SaGiVproject.phonesSAGIVDataSet();
            this.t_phonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_phonesTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.t_phonesTableAdapter();
            this.tableAdapterManager = new SaGiVproject.phonesSAGIVDataSetTableAdapters.TableAdapterManager();
            this.t_clientTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.t_clientTableAdapter();
            this.t_workerTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.t_workerTableAdapter();
            this.id_pComboBox = new System.Windows.Forms.ComboBox();
            this.t_clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_clientComboBox = new System.Windows.Forms.ComboBox();
            this.t_workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.w_idComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.q_BILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.q_BILLTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.Q_BILLTableAdapter();
            this.q_BILLDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.printDialog3 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog3 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_phonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_BILLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_BILLDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // phonesSAGIVDataSet
            // 
            this.phonesSAGIVDataSet.DataSetName = "phonesSAGIVDataSet";
            this.phonesSAGIVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_phonesBindingSource
            // 
            this.t_phonesBindingSource.DataMember = "t_phones";
            this.t_phonesBindingSource.DataSource = this.phonesSAGIVDataSet;
            // 
            // t_phonesTableAdapter
            // 
            this.t_phonesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.t_bill_downTableAdapter = null;
            this.tableAdapterManager.t_bill_headTableAdapter = null;
            this.tableAdapterManager.t_bill_sapakTableAdapter = null;
            this.tableAdapterManager.t_billdeat_sapakTableAdapter = null;
            this.tableAdapterManager.t_clientTableAdapter = this.t_clientTableAdapter;
            this.tableAdapterManager.t_order_fixTableAdapter = null;
            this.tableAdapterManager.t_order_packTableAdapter = null;
            this.tableAdapterManager.t_packTableAdapter = null;
            this.tableAdapterManager.t_phonesTableAdapter = this.t_phonesTableAdapter;
            this.tableAdapterManager.t_sapakTableAdapter = null;
            this.tableAdapterManager.t_takalaTableAdapter = null;
            this.tableAdapterManager.t_typesTableAdapter = null;
            this.tableAdapterManager.t_workerTableAdapter = this.t_workerTableAdapter;
            this.tableAdapterManager.t_yazTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SaGiVproject.phonesSAGIVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_clientTableAdapter
            // 
            this.t_clientTableAdapter.ClearBeforeFill = true;
            // 
            // t_workerTableAdapter
            // 
            this.t_workerTableAdapter.ClearBeforeFill = true;
            // 
            // id_pComboBox
            // 
            this.id_pComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_phonesBindingSource, "id_p", true));
            this.id_pComboBox.DataSource = this.t_phonesBindingSource;
            this.id_pComboBox.DisplayMember = "type_p";
            this.id_pComboBox.FormattingEnabled = true;
            this.id_pComboBox.Location = new System.Drawing.Point(492, 29);
            this.id_pComboBox.Name = "id_pComboBox";
            this.id_pComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_pComboBox.TabIndex = 2;
            this.id_pComboBox.ValueMember = "id_p";
            // 
            // t_clientBindingSource
            // 
            this.t_clientBindingSource.DataMember = "t_client";
            this.t_clientBindingSource.DataSource = this.phonesSAGIVDataSet;
            // 
            // id_clientComboBox
            // 
            this.id_clientComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_clientBindingSource, "id_client", true));
            this.id_clientComboBox.DataSource = this.t_clientBindingSource;
            this.id_clientComboBox.DisplayMember = "name_client";
            this.id_clientComboBox.FormattingEnabled = true;
            this.id_clientComboBox.Location = new System.Drawing.Point(492, 83);
            this.id_clientComboBox.Name = "id_clientComboBox";
            this.id_clientComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_clientComboBox.TabIndex = 4;
            this.id_clientComboBox.ValueMember = "id_client";
            // 
            // t_workerBindingSource
            // 
            this.t_workerBindingSource.DataMember = "t_worker";
            this.t_workerBindingSource.DataSource = this.phonesSAGIVDataSet;
            // 
            // w_idComboBox
            // 
            this.w_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_workerBindingSource, "w_id", true));
            this.w_idComboBox.DataSource = this.t_workerBindingSource;
            this.w_idComboBox.DisplayMember = "w_name";
            this.w_idComboBox.FormattingEnabled = true;
            this.w_idComboBox.Location = new System.Drawing.Point(492, 56);
            this.w_idComboBox.Name = "w_idComboBox";
            this.w_idComboBox.Size = new System.Drawing.Size(121, 21);
            this.w_idComboBox.TabIndex = 6;
            this.w_idComboBox.ValueMember = "w_id";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "חיפוש לפי שם לקוח";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "חפש לפי שם עובד";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "חפש לפי שם מוצר";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(124, 66);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(227, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "חפש לפי תאריך";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // q_BILLBindingSource
            // 
            this.q_BILLBindingSource.DataSource = this.phonesSAGIVDataSet;
            this.q_BILLBindingSource.Position = 0;
            // 
            // q_BILLTableAdapter
            // 
            this.q_BILLTableAdapter.ClearBeforeFill = true;
            // 
            // q_BILLDataGridView
            // 
            this.q_BILLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.q_BILLDataGridView.Location = new System.Drawing.Point(57, 145);
            this.q_BILLDataGridView.Name = "q_BILLDataGridView";
            this.q_BILLDataGridView.Size = new System.Drawing.Size(712, 220);
            this.q_BILLDataGridView.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 25;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(306, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 57);
            this.button5.TabIndex = 136;
            this.button5.Text = "הצג דוח חשבוניות עובד";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(306, 371);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 57);
            this.button6.TabIndex = 137;
            this.button6.Text = "הצג דוח חשבוניות של לקוח";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.printDocument2;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // printDialog2
            // 
            this.printDialog2.Document = this.printDocument2;
            this.printDialog2.UseEXDialog = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(306, 434);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 57);
            this.button7.TabIndex = 138;
            this.button7.Text = "הדפס דוח חשבוניות עובד";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(306, 434);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(164, 57);
            this.button8.TabIndex = 139;
            this.button8.Text = "הדפס דוח חשבוניות לקוח";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(306, 434);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(164, 57);
            this.button9.TabIndex = 141;
            this.button9.Text = "הדפס דוח חשבוניות מוצר";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(306, 371);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(164, 57);
            this.button10.TabIndex = 140;
            this.button10.Text = "הצג דוח חשבוניות מוצר";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // printDocument3
            // 
            this.printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument3_PrintPage);
            // 
            // printDialog3
            // 
            this.printDialog3.Document = this.printDocument3;
            this.printDialog3.UseEXDialog = true;
            // 
            // printPreviewDialog3
            // 
            this.printPreviewDialog3.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog3.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog3.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog3.Document = this.printDocument3;
            this.printPreviewDialog3.Enabled = true;
            this.printPreviewDialog3.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog3.Icon")));
            this.printPreviewDialog3.Name = "printPreviewDialog3";
            this.printPreviewDialog3.Visible = false;
            // 
            // searchbill1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaGiVproject.Properties.Resources.recycled_texture_background_by_sandeep_m_on_deviantart;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 519);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.q_BILLDataGridView);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.w_idComboBox);
            this.Controls.Add(this.id_clientComboBox);
            this.Controls.Add(this.id_pComboBox);
            this.Name = "searchbill1";
            this.Text = "searchbill1";
            this.Load += new System.EventHandler(this.searchbill1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_phonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_BILLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_BILLDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private phonesSAGIVDataSet phonesSAGIVDataSet;
        private System.Windows.Forms.BindingSource t_phonesBindingSource;
        private phonesSAGIVDataSetTableAdapters.t_phonesTableAdapter t_phonesTableAdapter;
        private phonesSAGIVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private phonesSAGIVDataSetTableAdapters.t_clientTableAdapter t_clientTableAdapter;
        private System.Windows.Forms.ComboBox id_pComboBox;
        private System.Windows.Forms.BindingSource t_clientBindingSource;
        private phonesSAGIVDataSetTableAdapters.t_workerTableAdapter t_workerTableAdapter;
        private System.Windows.Forms.ComboBox id_clientComboBox;
        private System.Windows.Forms.BindingSource t_workerBindingSource;
        private System.Windows.Forms.ComboBox w_idComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource q_BILLBindingSource;
        private phonesSAGIVDataSetTableAdapters.Q_BILLTableAdapter q_BILLTableAdapter;
        private System.Windows.Forms.DataGridView q_BILLDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private System.Windows.Forms.PrintDialog printDialog3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog3;
    }
}