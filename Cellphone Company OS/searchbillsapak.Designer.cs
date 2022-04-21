namespace SaGiVproject
{
    partial class searchbillsapak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchbillsapak));
            this.phonesSAGIVDataSet = new SaGiVproject.phonesSAGIVDataSet();
            this.t_phonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_phonesTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.t_phonesTableAdapter();
            this.tableAdapterManager = new SaGiVproject.phonesSAGIVDataSetTableAdapters.TableAdapterManager();
            this.t_sapakTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.t_sapakTableAdapter();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id_pComboBox = new System.Windows.Forms.ComboBox();
            this.t_sapakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_sapakComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.q_BILLSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.q_BILLSTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.Q_BILLSTableAdapter();
            this.q_BILLSDataGridView = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_phonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_sapakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_BILLSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_BILLSDataGridView)).BeginInit();
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
            this.tableAdapterManager.t_clientTableAdapter = null;
            this.tableAdapterManager.t_order_fixTableAdapter = null;
            this.tableAdapterManager.t_order_packTableAdapter = null;
            this.tableAdapterManager.t_packTableAdapter = null;
            this.tableAdapterManager.t_phonesTableAdapter = this.t_phonesTableAdapter;
            this.tableAdapterManager.t_sapakTableAdapter = this.t_sapakTableAdapter;
            this.tableAdapterManager.t_takalaTableAdapter = null;
            this.tableAdapterManager.t_typesTableAdapter = null;
            this.tableAdapterManager.t_workerTableAdapter = null;
            this.tableAdapterManager.t_yazTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SaGiVproject.phonesSAGIVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_sapakTableAdapter
            // 
            this.t_sapakTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(65, 61);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(168, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "חפש לפי תאריך";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "חפש לפי שם ספק";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "חפש לפי שם מוצר";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_pComboBox
            // 
            this.id_pComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_phonesBindingSource, "id_p", true));
            this.id_pComboBox.DataSource = this.t_phonesBindingSource;
            this.id_pComboBox.DisplayMember = "type_p";
            this.id_pComboBox.FormattingEnabled = true;
            this.id_pComboBox.Location = new System.Drawing.Point(489, 37);
            this.id_pComboBox.Name = "id_pComboBox";
            this.id_pComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_pComboBox.TabIndex = 26;
            this.id_pComboBox.ValueMember = "id_p";
            // 
            // t_sapakBindingSource
            // 
            this.t_sapakBindingSource.DataMember = "t_sapak";
            this.t_sapakBindingSource.DataSource = this.phonesSAGIVDataSet;
            // 
            // id_sapakComboBox
            // 
            this.id_sapakComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_sapakBindingSource, "id_sapak", true));
            this.id_sapakComboBox.DataSource = this.t_sapakBindingSource;
            this.id_sapakComboBox.DisplayMember = "name_s";
            this.id_sapakComboBox.FormattingEnabled = true;
            this.id_sapakComboBox.Location = new System.Drawing.Point(489, 61);
            this.id_sapakComboBox.Name = "id_sapakComboBox";
            this.id_sapakComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_sapakComboBox.TabIndex = 36;
            this.id_sapakComboBox.ValueMember = "id_sapak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 37;
            // 
            // q_BILLSBindingSource
            // 
            this.q_BILLSBindingSource.DataSource = this.phonesSAGIVDataSet;
            this.q_BILLSBindingSource.Position = 0;
            // 
            // q_BILLSTableAdapter
            // 
            this.q_BILLSTableAdapter.ClearBeforeFill = true;
            // 
            // q_BILLSDataGridView
            // 
            this.q_BILLSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.q_BILLSDataGridView.Location = new System.Drawing.Point(9, 103);
            this.q_BILLSDataGridView.Name = "q_BILLSDataGridView";
            this.q_BILLSDataGridView.Size = new System.Drawing.Size(738, 220);
            this.q_BILLSDataGridView.TabIndex = 37;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 50);
            this.button3.TabIndex = 135;
            this.button3.Text = "הצג דוח חשובוניות מספק";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(292, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 50);
            this.button5.TabIndex = 136;
            this.button5.Text = "הדפס דוח";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // searchbillsapak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaGiVproject.Properties.Resources.recycled_texture_background_by_sandeep_m_on_deviantart;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.q_BILLSDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_sapakComboBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_pComboBox);
            this.Name = "searchbillsapak";
            this.Text = "searchbillsapak";
            this.Load += new System.EventHandler(this.searchbillsapak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_phonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_sapakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_BILLSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_BILLSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private phonesSAGIVDataSet phonesSAGIVDataSet;
        private System.Windows.Forms.BindingSource t_phonesBindingSource;
        private phonesSAGIVDataSetTableAdapters.t_phonesTableAdapter t_phonesTableAdapter;
        private phonesSAGIVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private phonesSAGIVDataSetTableAdapters.t_sapakTableAdapter t_sapakTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox id_pComboBox;
        private System.Windows.Forms.BindingSource t_sapakBindingSource;
        private System.Windows.Forms.ComboBox id_sapakComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource q_BILLSBindingSource;
        private phonesSAGIVDataSetTableAdapters.Q_BILLSTableAdapter q_BILLSTableAdapter;
        private System.Windows.Forms.DataGridView q_BILLSDataGridView;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;

    }
}