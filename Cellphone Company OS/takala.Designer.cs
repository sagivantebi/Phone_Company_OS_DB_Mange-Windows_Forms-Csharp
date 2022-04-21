namespace SaGiVproject
{
    partial class takala
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
            System.Windows.Forms.Label num_takLabel;
            System.Windows.Forms.Label tak_nameLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(takala));
            this.phonesSAGIVDataSet = new SaGiVproject.phonesSAGIVDataSet();
            this.t_takalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_takalaTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.t_takalaTableAdapter();
            this.tableAdapterManager = new SaGiVproject.phonesSAGIVDataSetTableAdapters.TableAdapterManager();
            this.num_takTextBox = new System.Windows.Forms.TextBox();
            this.tak_nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.t_takalaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            num_takLabel = new System.Windows.Forms.Label();
            tak_nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_takalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_takalaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // num_takLabel
            // 
            num_takLabel.AutoSize = true;
            num_takLabel.Location = new System.Drawing.Point(538, 35);
            num_takLabel.Name = "num_takLabel";
            num_takLabel.Size = new System.Drawing.Size(68, 13);
            num_takLabel.TabIndex = 1;
            num_takLabel.Text = ":מספר תקלה";
            // 
            // tak_nameLabel
            // 
            tak_nameLabel.AutoSize = true;
            tak_nameLabel.Location = new System.Drawing.Point(538, 61);
            tak_nameLabel.Name = "tak_nameLabel";
            tak_nameLabel.Size = new System.Drawing.Size(57, 13);
            tak_nameLabel.TabIndex = 3;
            tak_nameLabel.Text = ":שם תקלה";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(538, 87);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(35, 13);
            priceLabel.TabIndex = 5;
            priceLabel.Text = ":מחיר";
            // 
            // phonesSAGIVDataSet
            // 
            this.phonesSAGIVDataSet.DataSetName = "phonesSAGIVDataSet";
            this.phonesSAGIVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_takalaBindingSource
            // 
            this.t_takalaBindingSource.DataMember = "t_takala";
            this.t_takalaBindingSource.DataSource = this.phonesSAGIVDataSet;
            // 
            // t_takalaTableAdapter
            // 
            this.t_takalaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.t_phonesTableAdapter = null;
            this.tableAdapterManager.t_sapakTableAdapter = null;
            this.tableAdapterManager.t_takalaTableAdapter = this.t_takalaTableAdapter;
            this.tableAdapterManager.t_typesTableAdapter = null;
            this.tableAdapterManager.t_workerTableAdapter = null;
            this.tableAdapterManager.t_yazTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SaGiVproject.phonesSAGIVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // num_takTextBox
            // 
            this.num_takTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_takalaBindingSource, "num_tak", true));
            this.num_takTextBox.Enabled = false;
            this.num_takTextBox.Location = new System.Drawing.Point(432, 35);
            this.num_takTextBox.Name = "num_takTextBox";
            this.num_takTextBox.Size = new System.Drawing.Size(100, 20);
            this.num_takTextBox.TabIndex = 2;
            // 
            // tak_nameTextBox
            // 
            this.tak_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_takalaBindingSource, "tak_name", true));
            this.tak_nameTextBox.Location = new System.Drawing.Point(432, 61);
            this.tak_nameTextBox.Name = "tak_nameTextBox";
            this.tak_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.tak_nameTextBox.TabIndex = 4;
            this.tak_nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tak_nameTextBox_KeyPress);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_takalaBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(432, 87);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 6;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // t_takalaDataGridView
            // 
            this.t_takalaDataGridView.AutoGenerateColumns = false;
            this.t_takalaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_takalaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.t_takalaDataGridView.DataSource = this.t_takalaBindingSource;
            this.t_takalaDataGridView.Enabled = false;
            this.t_takalaDataGridView.Location = new System.Drawing.Point(12, 12);
            this.t_takalaDataGridView.Name = "t_takalaDataGridView";
            this.t_takalaDataGridView.Size = new System.Drawing.Size(333, 138);
            this.t_takalaDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "num_tak";
            this.dataGridViewTextBoxColumn1.HeaderText = "מספר תקלה";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tak_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "שם תקלה";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn3.HeaderText = "מחיר";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(200, 214);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 45;
            this.button8.Text = "עדכון";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(158, 185);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 44;
            this.button7.Text = "שמירה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(119, 214);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 43;
            this.button6.Text = "רענון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(158, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 42;
            this.button5.Text = "חדש";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "אחרון";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "קודם";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "הבא";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "ראשון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(291, 196);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(135, 23);
            this.button10.TabIndex = 101;
            this.button10.Text = "הדפס דוח ספקים";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(291, 167);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(135, 23);
            this.button9.TabIndex = 100;
            this.button9.Text = "הצג דוח ספקים";
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
            // takala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaGiVproject.Properties.Resources.cool_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 250);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_takalaDataGridView);
            this.Controls.Add(num_takLabel);
            this.Controls.Add(this.num_takTextBox);
            this.Controls.Add(tak_nameLabel);
            this.Controls.Add(this.tak_nameTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Name = "takala";
            this.Text = "takala";
            this.Load += new System.EventHandler(this.takala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_takalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_takalaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private phonesSAGIVDataSet phonesSAGIVDataSet;
        private System.Windows.Forms.BindingSource t_takalaBindingSource;
        private phonesSAGIVDataSetTableAdapters.t_takalaTableAdapter t_takalaTableAdapter;
        private phonesSAGIVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox num_takTextBox;
        private System.Windows.Forms.TextBox tak_nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DataGridView t_takalaDataGridView;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}