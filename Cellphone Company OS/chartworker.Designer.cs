namespace SaGiVproject
{
    partial class chartworker
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chartworker));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.qBestWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonesSAGIVDataSet = new SaGiVproject.phonesSAGIVDataSet();
            this.qֹ_BestWTableAdapter = new SaGiVproject.phonesSAGIVDataSetTableAdapters.Qֹ_BestWTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qBestWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "שמות העובדים";
            chartArea1.AxisY.Title = "כמות מכירות";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.qBestWBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-3, -2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "w_name";
            series1.YValueMembers = "Countמתוךid_bill";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(613, 452);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "מכירות פלאפונים פר עובד";
            title1.Name = "Title1";
            title1.Text = "מכירות פלאפונים פר עובד";
            this.chart1.Titles.Add(title1);
            this.chart1.Visible = false;
            // 
            // qBestWBindingSource
            // 
            this.qBestWBindingSource.DataMember = "Qֹ_BestW";
            this.qBestWBindingSource.DataSource = this.phonesSAGIVDataSet;
            // 
            // phonesSAGIVDataSet
            // 
            this.phonesSAGIVDataSet.DataSetName = "phonesSAGIVDataSet";
            this.phonesSAGIVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qֹ_BestWTableAdapter
            // 
            this.qֹ_BestWTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 84);
            this.button1.TabIndex = 1;
            this.button1.Text = "הצג גרף";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(663, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 84);
            this.button2.TabIndex = 2;
            this.button2.Text = "דוח מכירות פלאפונים פר עובד";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(663, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 84);
            this.button3.TabIndex = 3;
            this.button3.Text = "הדפס דוח";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // chartworker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "chartworker";
            this.Text = "chartworker";
            this.Load += new System.EventHandler(this.chartworker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qBestWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesSAGIVDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private phonesSAGIVDataSet phonesSAGIVDataSet;
        private System.Windows.Forms.BindingSource qBestWBindingSource;
        private phonesSAGIVDataSetTableAdapters.Qֹ_BestWTableAdapter qֹ_BestWTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}