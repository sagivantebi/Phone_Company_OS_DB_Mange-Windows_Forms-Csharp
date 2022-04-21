namespace SaGiVproject
{
    partial class Phone_sold
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phone_sold));
            this.phonesSAGIVDataSet = new SaGiVproject.phonesSAGIVDataSet();
            this.q_Num_soldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.q_Num_soldTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.Q_Num_soldTableAdapter();
            this.tableAdapterManager = new SaGiVproject.phonesSAGIVDataSetTableAdapters.TableAdapterManager();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_Num_soldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // phonesSAGIVDataSet
            // 
            this.phonesSAGIVDataSet.DataSetName = "phonesSAGIVDataSet";
            this.phonesSAGIVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // q_Num_soldBindingSource
            // 
            this.q_Num_soldBindingSource.DataMember = "Q_Num_sold";
            this.q_Num_soldBindingSource.DataSource = this.phonesSAGIVDataSet;
            // 
            // q_Num_soldTableAdapter
            // 
            this.q_Num_soldTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.t_takalaTableAdapter = null;
            this.tableAdapterManager.t_typesTableAdapter = null;
            this.tableAdapterManager.t_workerTableAdapter = null;
            this.tableAdapterManager.t_yazTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SaGiVproject.phonesSAGIVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chart1
            // 
            chartArea2.AxisX.Title = "שם מוצר";
            chartArea2.AxisY.Title = "כמות מכשירים";
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.q_Num_soldBindingSource;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(-6, -1);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Num_sold";
            series2.XValueMember = "type_p";
            series2.YValueMembers = "Num_sold";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(479, 448);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "סך מכירות לכל מוצר";
            this.chart1.Titles.Add(title2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 83);
            this.button1.TabIndex = 3;
            this.button1.Text = "הצג תרשים";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 83);
            this.button2.TabIndex = 4;
            this.button2.Text = "דוח מכירות פלאפונים";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 83);
            this.button3.TabIndex = 5;
            this.button3.Text = "הדפס דוח מכירות פלאפונים";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Phone_sold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 449);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Phone_sold";
            this.Text = "Phone_sold";
            this.Load += new System.EventHandler(this.Phone_sold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q_Num_soldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private phonesSAGIVDataSet phonesSAGIVDataSet;
        private System.Windows.Forms.BindingSource q_Num_soldBindingSource;
        private phonesSAGIVDataSetTableAdapters.Q_Num_soldTableAdapter q_Num_soldTableAdapter;
        private phonesSAGIVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button3;
    }
}