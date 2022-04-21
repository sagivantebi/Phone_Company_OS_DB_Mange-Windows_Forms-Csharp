namespace SaGiVproject
{
    partial class searchBillPack
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id_pComboBox = new System.Windows.Forms.ComboBox();
            this.tpackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonesSAGIVDataSet = new SaGiVproject.phonesSAGIVDataSet();
            this.q_searchPACKbillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.q_searchPACKbillTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.Q_searchPACKbillTableAdapter();
            this.tableAdapterManager = new SaGiVproject.phonesSAGIVDataSetTableAdapters.TableAdapterManager();
            this.t_packTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.t_packTableAdapter();
            this.q_searchPACKbillDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tpackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_searchPACKbillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_searchPACKbillDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "חפש לפי מספר פלאפון";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "חפש לפי שם חבילה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_pComboBox
            // 
            this.id_pComboBox.DataSource = this.tpackBindingSource;
            this.id_pComboBox.DisplayMember = "name_pack";
            this.id_pComboBox.FormattingEnabled = true;
            this.id_pComboBox.Location = new System.Drawing.Point(70, 26);
            this.id_pComboBox.Name = "id_pComboBox";
            this.id_pComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_pComboBox.TabIndex = 26;
            this.id_pComboBox.ValueMember = "id_pack";
            this.id_pComboBox.SelectedIndexChanged += new System.EventHandler(this.id_pComboBox_SelectedIndexChanged);
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
            // q_searchPACKbillBindingSource
            // 
            this.q_searchPACKbillBindingSource.DataMember = "Q_searchPACKbill";
            this.q_searchPACKbillBindingSource.DataSource = this.phonesSAGIVDataSet;
            // 
            // q_searchPACKbillTableAdapter
            // 
            this.q_searchPACKbillTableAdapter.ClearBeforeFill = true;
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
            // t_packTableAdapter
            // 
            this.t_packTableAdapter.ClearBeforeFill = true;
            // 
            // q_searchPACKbillDataGridView
            // 
            this.q_searchPACKbillDataGridView.AutoGenerateColumns = false;
            this.q_searchPACKbillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.q_searchPACKbillDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.q_searchPACKbillDataGridView.DataSource = this.q_searchPACKbillBindingSource;
            this.q_searchPACKbillDataGridView.Location = new System.Drawing.Point(26, 102);
            this.q_searchPACKbillDataGridView.Name = "q_searchPACKbillDataGridView";
            this.q_searchPACKbillDataGridView.Size = new System.Drawing.Size(343, 266);
            this.q_searchPACKbillDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_order_pack";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_order_pack";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_pack";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_pack";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "phone_num";
            this.dataGridViewTextBoxColumn3.HeaderText = "phone_num";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(70, 52);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox1.TabIndex = 35;
            // 
            // searchBillPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaGiVproject.Properties.Resources.recycled_texture_background_by_sandeep_m_on_deviantart;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 380);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.q_searchPACKbillDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_pComboBox);
            this.Name = "searchBillPack";
            this.Text = "searchBillPack";
            this.Load += new System.EventHandler(this.searchBillPack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tpackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_searchPACKbillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_searchPACKbillDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox id_pComboBox;
        private phonesSAGIVDataSet phonesSAGIVDataSet;
        private System.Windows.Forms.BindingSource q_searchPACKbillBindingSource;
        private phonesSAGIVDataSetTableAdapters.Q_searchPACKbillTableAdapter q_searchPACKbillTableAdapter;
        private phonesSAGIVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView q_searchPACKbillDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private phonesSAGIVDataSetTableAdapters.t_packTableAdapter t_packTableAdapter;
        private System.Windows.Forms.BindingSource tpackBindingSource;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}