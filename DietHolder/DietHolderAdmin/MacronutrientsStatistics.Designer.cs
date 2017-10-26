namespace DietHolderAdmin
{
    partial class MacronutrientsStatistics
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
            if(disposing && (components != null))
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btn_compareProducts = new System.Windows.Forms.Button();
            this.cb_chooseProducts = new System.Windows.Forms.ComboBox();
            this.ch_secondChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ch_firstChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ch_secondChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_firstChart)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_compareProducts
            // 
            this.btn_compareProducts.Location = new System.Drawing.Point(12, 68);
            this.btn_compareProducts.Name = "btn_compareProducts";
            this.btn_compareProducts.Size = new System.Drawing.Size(217, 66);
            this.btn_compareProducts.TabIndex = 4;
            this.btn_compareProducts.Text = "Dodaj produkt do porównania";
            this.btn_compareProducts.UseVisualStyleBackColor = true;
            this.btn_compareProducts.Click += new System.EventHandler(this.btn_compareProducts_Click);
            // 
            // cb_chooseProducts
            // 
            this.cb_chooseProducts.FormattingEnabled = true;
            this.cb_chooseProducts.Location = new System.Drawing.Point(12, 25);
            this.cb_chooseProducts.Name = "cb_chooseProducts";
            this.cb_chooseProducts.Size = new System.Drawing.Size(217, 24);
            this.cb_chooseProducts.TabIndex = 3;
            // 
            // ch_secondChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_secondChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_secondChart.Legends.Add(legend1);
            this.ch_secondChart.Location = new System.Drawing.Point(856, 25);
            this.ch_secondChart.Name = "ch_secondChart";
            this.ch_secondChart.Size = new System.Drawing.Size(595, 338);
            this.ch_secondChart.TabIndex = 6;
            // 
            // ch_firstChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ch_firstChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ch_firstChart.Legends.Add(legend2);
            this.ch_firstChart.Location = new System.Drawing.Point(245, 25);
            this.ch_firstChart.Name = "ch_firstChart";
            this.ch_firstChart.Size = new System.Drawing.Size(595, 338);
            this.ch_firstChart.TabIndex = 5;
            // 
            // MacronutrientsStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 396);
            this.Controls.Add(this.ch_secondChart);
            this.Controls.Add(this.ch_firstChart);
            this.Controls.Add(this.btn_compareProducts);
            this.Controls.Add(this.cb_chooseProducts);
            this.Name = "MacronutrientsStatistics";
            this.Text = "MacronutrientsStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.ch_secondChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_firstChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_compareProducts;
        private System.Windows.Forms.ComboBox cb_chooseProducts;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_secondChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_firstChart;
    }
}