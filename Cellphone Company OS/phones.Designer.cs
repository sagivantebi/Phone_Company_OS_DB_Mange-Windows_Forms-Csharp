namespace SaGiVproject
{
    partial class phones
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
            System.Windows.Forms.Label id_pLabel;
            System.Windows.Forms.Label yaz_pLabel;
            System.Windows.Forms.Label type_pLabel;
            System.Windows.Forms.Label color_pLabel;
            System.Windows.Forms.Label information_pLabel;
            System.Windows.Forms.Label year_pLabel;
            System.Windows.Forms.Label amount_pLabel;
            System.Windows.Forms.Label price_pLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(phones));
            this.phonesSAGIVDataSet = new SaGiVproject.phonesSAGIVDataSet();
            this.t_phonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_phonesTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.t_phonesTableAdapter();
            this.tableAdapterManager = new SaGiVproject.phonesSAGIVDataSetTableAdapters.TableAdapterManager();
            this.t_typesTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.t_typesTableAdapter();
            this.t_yazTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.t_yazTableAdapter();
            this.t_phonesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pTextBox = new System.Windows.Forms.TextBox();
            this.yaz_pComboBox = new System.Windows.Forms.ComboBox();
            this.tyazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_pComboBox = new System.Windows.Forms.ComboBox();
            this.ttypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.color_pTextBox = new System.Windows.Forms.TextBox();
            this.information_pTextBox = new System.Windows.Forms.TextBox();
            this.year_pTextBox = new System.Windows.Forms.TextBox();
            this.amount_pTextBox = new System.Windows.Forms.TextBox();
            this.price_pTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            id_pLabel = new System.Windows.Forms.Label();
            yaz_pLabel = new System.Windows.Forms.Label();
            type_pLabel = new System.Windows.Forms.Label();
            color_pLabel = new System.Windows.Forms.Label();
            information_pLabel = new System.Windows.Forms.Label();
            year_pLabel = new System.Windows.Forms.Label();
            amount_pLabel = new System.Windows.Forms.Label();
            price_pLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_phonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_phonesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tyazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_pLabel
            // 
            id_pLabel.AutoSize = true;
            id_pLabel.Location = new System.Drawing.Point(570, 51);
            id_pLabel.Name = "id_pLabel";
            id_pLabel.Size = new System.Drawing.Size(73, 13);
            id_pLabel.TabIndex = 2;
            id_pLabel.Text = ":מקט פלאפון";
            // 
            // yaz_pLabel
            // 
            yaz_pLabel.AutoSize = true;
            yaz_pLabel.Location = new System.Drawing.Point(570, 77);
            yaz_pLabel.Name = "yaz_pLabel";
            yaz_pLabel.Size = new System.Drawing.Size(75, 13);
            yaz_pLabel.TabIndex = 4;
            yaz_pLabel.Text = ":יצרן פלאפון";
            // 
            // type_pLabel
            // 
            type_pLabel.AutoSize = true;
            type_pLabel.Location = new System.Drawing.Point(570, 104);
            type_pLabel.Name = "type_pLabel";
            type_pLabel.Size = new System.Drawing.Size(70, 13);
            type_pLabel.TabIndex = 6;
            type_pLabel.Text = ":סוג פלאפון";
            // 
            // color_pLabel
            // 
            color_pLabel.AutoSize = true;
            color_pLabel.Location = new System.Drawing.Point(570, 131);
            color_pLabel.Name = "color_pLabel";
            color_pLabel.Size = new System.Drawing.Size(31, 13);
            color_pLabel.TabIndex = 8;
            color_pLabel.Text = ":צבע";
            // 
            // information_pLabel
            // 
            information_pLabel.AutoSize = true;
            information_pLabel.Location = new System.Drawing.Point(82, 31);
            information_pLabel.Name = "information_pLabel";
            information_pLabel.Size = new System.Drawing.Size(97, 13);
            information_pLabel.TabIndex = 10;
            information_pLabel.Text = ":מידע על המכשיר";
            // 
            // year_pLabel
            // 
            year_pLabel.AutoSize = true;
            year_pLabel.Location = new System.Drawing.Point(361, 58);
            year_pLabel.Name = "year_pLabel";
            year_pLabel.Size = new System.Drawing.Size(59, 13);
            year_pLabel.TabIndex = 12;
            year_pLabel.Text = ":שנת יצוא";
            // 
            // amount_pLabel
            // 
            amount_pLabel.AutoSize = true;
            amount_pLabel.Location = new System.Drawing.Point(361, 84);
            amount_pLabel.Name = "amount_pLabel";
            amount_pLabel.Size = new System.Drawing.Size(73, 13);
            amount_pLabel.TabIndex = 14;
            amount_pLabel.Text = ":כמות במלאי";
            // 
            // price_pLabel
            // 
            price_pLabel.AutoSize = true;
            price_pLabel.Location = new System.Drawing.Point(361, 110);
            price_pLabel.Name = "price_pLabel";
            price_pLabel.Size = new System.Drawing.Size(76, 13);
            price_pLabel.TabIndex = 16;
            price_pLabel.Text = ":מחיר ליחידה";
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
            this.tableAdapterManager.t_sapakTableAdapter = null;
            this.tableAdapterManager.t_takalaTableAdapter = null;
            this.tableAdapterManager.t_typesTableAdapter = this.t_typesTableAdapter;
            this.tableAdapterManager.t_workerTableAdapter = null;
            this.tableAdapterManager.t_yazTableAdapter = this.t_yazTableAdapter;
            this.tableAdapterManager.UpdateOrder = SaGiVproject.phonesSAGIVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_typesTableAdapter
            // 
            this.t_typesTableAdapter.ClearBeforeFill = true;
            // 
            // t_yazTableAdapter
            // 
            this.t_yazTableAdapter.ClearBeforeFill = true;
            // 
            // t_phonesDataGridView
            // 
            this.t_phonesDataGridView.AutoGenerateColumns = false;
            this.t_phonesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_phonesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.t_phonesDataGridView.DataSource = this.t_phonesBindingSource;
            this.t_phonesDataGridView.Enabled = false;
            this.t_phonesDataGridView.Location = new System.Drawing.Point(34, 179);
            this.t_phonesDataGridView.Name = "t_phonesDataGridView";
            this.t_phonesDataGridView.Size = new System.Drawing.Size(846, 220);
            this.t_phonesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_p";
            this.dataGridViewTextBoxColumn1.HeaderText = "מקט פלאפון";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "yaz_p";
            this.dataGridViewTextBoxColumn2.HeaderText = "יצרן";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "type_p";
            this.dataGridViewTextBoxColumn3.HeaderText = "סוג";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "color_p";
            this.dataGridViewTextBoxColumn4.HeaderText = "צבע";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "information_p";
            this.dataGridViewTextBoxColumn5.HeaderText = "מידע";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "year_p";
            this.dataGridViewTextBoxColumn6.HeaderText = "שנת הוצאה";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "amount_p";
            this.dataGridViewTextBoxColumn7.HeaderText = "כמות";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "price_p";
            this.dataGridViewTextBoxColumn8.HeaderText = "מחיר";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // id_pTextBox
            // 
            this.id_pTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_phonesBindingSource, "id_p", true));
            this.id_pTextBox.Enabled = false;
            this.id_pTextBox.Location = new System.Drawing.Point(443, 51);
            this.id_pTextBox.Name = "id_pTextBox";
            this.id_pTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_pTextBox.TabIndex = 3;
            // 
            // yaz_pComboBox
            // 
            this.yaz_pComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_phonesBindingSource, "yaz_p", true));
            this.yaz_pComboBox.DataSource = this.tyazBindingSource;
            this.yaz_pComboBox.DisplayMember = "yaz_p";
            this.yaz_pComboBox.Enabled = false;
            this.yaz_pComboBox.FormattingEnabled = true;
            this.yaz_pComboBox.Location = new System.Drawing.Point(443, 77);
            this.yaz_pComboBox.Name = "yaz_pComboBox";
            this.yaz_pComboBox.Size = new System.Drawing.Size(121, 21);
            this.yaz_pComboBox.TabIndex = 5;
            this.yaz_pComboBox.ValueMember = "yaz_p";
            // 
            // tyazBindingSource
            // 
            this.tyazBindingSource.DataMember = "t_yaz";
            this.tyazBindingSource.DataSource = this.phonesSAGIVDataSet;
            // 
            // type_pComboBox
            // 
            this.type_pComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_phonesBindingSource, "type_p", true));
            this.type_pComboBox.DataSource = this.ttypesBindingSource;
            this.type_pComboBox.DisplayMember = "type_p";
            this.type_pComboBox.Enabled = false;
            this.type_pComboBox.FormattingEnabled = true;
            this.type_pComboBox.Location = new System.Drawing.Point(443, 104);
            this.type_pComboBox.Name = "type_pComboBox";
            this.type_pComboBox.Size = new System.Drawing.Size(121, 21);
            this.type_pComboBox.TabIndex = 7;
            this.type_pComboBox.ValueMember = "type_p";
            // 
            // ttypesBindingSource
            // 
            this.ttypesBindingSource.DataMember = "t_types";
            this.ttypesBindingSource.DataSource = this.phonesSAGIVDataSet;
            // 
            // color_pTextBox
            // 
            this.color_pTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_phonesBindingSource, "color_p", true));
            this.color_pTextBox.Location = new System.Drawing.Point(443, 131);
            this.color_pTextBox.Name = "color_pTextBox";
            this.color_pTextBox.Size = new System.Drawing.Size(121, 20);
            this.color_pTextBox.TabIndex = 9;
            this.color_pTextBox.TextChanged += new System.EventHandler(this.color_pTextBox_TextChanged);
            this.color_pTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.color_pTextBox_KeyPress);
            // 
            // information_pTextBox
            // 
            this.information_pTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_phonesBindingSource, "information_p", true));
            this.information_pTextBox.Location = new System.Drawing.Point(58, 51);
            this.information_pTextBox.Multiline = true;
            this.information_pTextBox.Name = "information_pTextBox";
            this.information_pTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.information_pTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.information_pTextBox.Size = new System.Drawing.Size(121, 100);
            this.information_pTextBox.TabIndex = 11;
            // 
            // year_pTextBox
            // 
            this.year_pTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_phonesBindingSource, "year_p", true));
            this.year_pTextBox.Location = new System.Drawing.Point(234, 58);
            this.year_pTextBox.Name = "year_pTextBox";
            this.year_pTextBox.Size = new System.Drawing.Size(121, 20);
            this.year_pTextBox.TabIndex = 13;
            this.year_pTextBox.TextChanged += new System.EventHandler(this.year_pTextBox_TextChanged);
            // 
            // amount_pTextBox
            // 
            this.amount_pTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_phonesBindingSource, "amount_p", true));
            this.amount_pTextBox.Location = new System.Drawing.Point(234, 84);
            this.amount_pTextBox.Name = "amount_pTextBox";
            this.amount_pTextBox.Size = new System.Drawing.Size(121, 20);
            this.amount_pTextBox.TabIndex = 15;
            this.amount_pTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_pTextBox_KeyPress);
            // 
            // price_pTextBox
            // 
            this.price_pTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_phonesBindingSource, "price_p", true));
            this.price_pTextBox.Location = new System.Drawing.Point(234, 110);
            this.price_pTextBox.Name = "price_pTextBox";
            this.price_pTextBox.Size = new System.Drawing.Size(121, 20);
            this.price_pTextBox.TabIndex = 17;
            this.price_pTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_pTextBox_KeyPress);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(820, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "אחרון";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(820, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "קודם";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(820, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "הבא";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "ראשון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(734, 81);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 37;
            this.button8.Text = "עדכון";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(692, 52);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 36;
            this.button7.Text = "שמירה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(653, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 35;
            this.button6.Text = "רענון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(692, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "חדש";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(280, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "עובד";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(664, 140);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(135, 23);
            this.button10.TabIndex = 103;
            this.button10.Text = "הדפס דוח פלאפנוים";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(664, 111);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(135, 23);
            this.button9.TabIndex = 102;
            this.button9.Text = "הצג דוח פלאפונים";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
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
            // phones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaGiVproject.Properties.Resources.cool_background;
            this.ClientSize = new System.Drawing.Size(947, 425);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_pLabel);
            this.Controls.Add(this.id_pTextBox);
            this.Controls.Add(yaz_pLabel);
            this.Controls.Add(this.yaz_pComboBox);
            this.Controls.Add(type_pLabel);
            this.Controls.Add(this.type_pComboBox);
            this.Controls.Add(color_pLabel);
            this.Controls.Add(this.color_pTextBox);
            this.Controls.Add(information_pLabel);
            this.Controls.Add(this.information_pTextBox);
            this.Controls.Add(year_pLabel);
            this.Controls.Add(this.year_pTextBox);
            this.Controls.Add(amount_pLabel);
            this.Controls.Add(this.amount_pTextBox);
            this.Controls.Add(price_pLabel);
            this.Controls.Add(this.price_pTextBox);
            this.Controls.Add(this.t_phonesDataGridView);
            this.Name = "phones";
            this.Text = "phones";
            this.Load += new System.EventHandler(this.phones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_phonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_phonesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tyazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private phonesSAGIVDataSet phonesSAGIVDataSet;
        private System.Windows.Forms.BindingSource t_phonesBindingSource;
        private phonesSAGIVDataSetTableAdapters.t_phonesTableAdapter t_phonesTableAdapter;
        private phonesSAGIVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView t_phonesDataGridView;
        private phonesSAGIVDataSetTableAdapters.t_yazTableAdapter t_yazTableAdapter;
        private System.Windows.Forms.TextBox id_pTextBox;
        private System.Windows.Forms.ComboBox yaz_pComboBox;
        private System.Windows.Forms.ComboBox type_pComboBox;
        private System.Windows.Forms.TextBox color_pTextBox;
        private System.Windows.Forms.TextBox information_pTextBox;
        private System.Windows.Forms.TextBox year_pTextBox;
        private System.Windows.Forms.TextBox amount_pTextBox;
        private System.Windows.Forms.TextBox price_pTextBox;
        private System.Windows.Forms.BindingSource tyazBindingSource;
        private phonesSAGIVDataSetTableAdapters.t_typesTableAdapter t_typesTableAdapter;
        private System.Windows.Forms.BindingSource ttypesBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}