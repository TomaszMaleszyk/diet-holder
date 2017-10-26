namespace DietHolderClient.UserComponents
{
    partial class UcDietStatistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chPie_DistributionOfIntakedCalorc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_caloricToEat = new System.Windows.Forms.Panel();
            this.lb_calorifyRemainedToEatValue = new System.Windows.Forms.Label();
            this.lb_caloricRemainedToEat = new System.Windows.Forms.Label();
            this.panel_caloricEatenInformation = new System.Windows.Forms.Panel();
            this.lb_calorifyEatenValue = new System.Windows.Forms.Label();
            this.lb_txtCaloricEaten = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chPie_DistributionOfIntakedCalorc)).BeginInit();
            this.panel_caloricToEat.SuspendLayout();
            this.panel_caloricEatenInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // chPie_DistributionOfIntakedCalorc
            // 
            this.chPie_DistributionOfIntakedCalorc.BackColor = System.Drawing.SystemColors.Control;
            this.chPie_DistributionOfIntakedCalorc.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chPie_DistributionOfIntakedCalorc.BorderSkin.BackImageTransparentColor = System.Drawing.Color.White;
            this.chPie_DistributionOfIntakedCalorc.BorderSkin.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chPie_DistributionOfIntakedCalorc.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 5;
            legend1.Name = "Legend1";
            this.chPie_DistributionOfIntakedCalorc.Legends.Add(legend1);
            this.chPie_DistributionOfIntakedCalorc.Location = new System.Drawing.Point(3, 12);
            this.chPie_DistributionOfIntakedCalorc.Name = "chPie_DistributionOfIntakedCalorc";
            this.chPie_DistributionOfIntakedCalorc.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chPie_DistributionOfIntakedCalorc.Series.Add(series1);
            this.chPie_DistributionOfIntakedCalorc.Size = new System.Drawing.Size(602, 336);
            this.chPie_DistributionOfIntakedCalorc.TabIndex = 2;
            this.chPie_DistributionOfIntakedCalorc.Click += new System.EventHandler(this.chPie_DistributionOfIntakedCalorc_Click);
            // 
            // panel_caloricToEat
            // 
            this.panel_caloricToEat.Controls.Add(this.lb_calorifyRemainedToEatValue);
            this.panel_caloricToEat.Controls.Add(this.lb_caloricRemainedToEat);
            this.panel_caloricToEat.Location = new System.Drawing.Point(25, 419);
            this.panel_caloricToEat.Name = "panel_caloricToEat";
            this.panel_caloricToEat.Size = new System.Drawing.Size(580, 59);
            this.panel_caloricToEat.TabIndex = 5;
            // 
            // lb_calorifyRemainedToEatValue
            // 
            this.lb_calorifyRemainedToEatValue.AutoSize = true;
            this.lb_calorifyRemainedToEatValue.Location = new System.Drawing.Point(16, 30);
            this.lb_calorifyRemainedToEatValue.Name = "lb_calorifyRemainedToEatValue";
            this.lb_calorifyRemainedToEatValue.Size = new System.Drawing.Size(46, 17);
            this.lb_calorifyRemainedToEatValue.TabIndex = 1;
            this.lb_calorifyRemainedToEatValue.Text = "label3";
            // 
            // lb_caloricRemainedToEat
            // 
            this.lb_caloricRemainedToEat.AutoSize = true;
            this.lb_caloricRemainedToEat.Location = new System.Drawing.Point(16, 13);
            this.lb_caloricRemainedToEat.Name = "lb_caloricRemainedToEat";
            this.lb_caloricRemainedToEat.Size = new System.Drawing.Size(154, 17);
            this.lb_caloricRemainedToEat.TabIndex = 0;
            this.lb_caloricRemainedToEat.Text = "Do spożycia pozostało:";
            // 
            // panel_caloricEatenInformation
            // 
            this.panel_caloricEatenInformation.Controls.Add(this.lb_calorifyEatenValue);
            this.panel_caloricEatenInformation.Controls.Add(this.lb_txtCaloricEaten);
            this.panel_caloricEatenInformation.Location = new System.Drawing.Point(25, 354);
            this.panel_caloricEatenInformation.Name = "panel_caloricEatenInformation";
            this.panel_caloricEatenInformation.Size = new System.Drawing.Size(580, 59);
            this.panel_caloricEatenInformation.TabIndex = 4;
            // 
            // lb_calorifyEatenValue
            // 
            this.lb_calorifyEatenValue.AutoSize = true;
            this.lb_calorifyEatenValue.Location = new System.Drawing.Point(16, 30);
            this.lb_calorifyEatenValue.Name = "lb_calorifyEatenValue";
            this.lb_calorifyEatenValue.Size = new System.Drawing.Size(46, 17);
            this.lb_calorifyEatenValue.TabIndex = 1;
            this.lb_calorifyEatenValue.Text = "label2";
            // 
            // lb_txtCaloricEaten
            // 
            this.lb_txtCaloricEaten.AutoSize = true;
            this.lb_txtCaloricEaten.Location = new System.Drawing.Point(16, 13);
            this.lb_txtCaloricEaten.Name = "lb_txtCaloricEaten";
            this.lb_txtCaloricEaten.Size = new System.Drawing.Size(134, 17);
            this.lb_txtCaloricEaten.TabIndex = 0;
            this.lb_txtCaloricEaten.Text = "Do tej pory spozyto:";
            // 
            // UcDietStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_caloricToEat);
            this.Controls.Add(this.panel_caloricEatenInformation);
            this.Controls.Add(this.chPie_DistributionOfIntakedCalorc);
            this.Name = "UcDietStatistics";
            this.Size = new System.Drawing.Size(630, 505);
            ((System.ComponentModel.ISupportInitialize)(this.chPie_DistributionOfIntakedCalorc)).EndInit();
            this.panel_caloricToEat.ResumeLayout(false);
            this.panel_caloricToEat.PerformLayout();
            this.panel_caloricEatenInformation.ResumeLayout(false);
            this.panel_caloricEatenInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chPie_DistributionOfIntakedCalorc;
        private System.Windows.Forms.Panel panel_caloricToEat;
        private System.Windows.Forms.Label lb_calorifyRemainedToEatValue;
        private System.Windows.Forms.Label lb_caloricRemainedToEat;
        private System.Windows.Forms.Panel panel_caloricEatenInformation;
        private System.Windows.Forms.Label lb_calorifyEatenValue;
        private System.Windows.Forms.Label lb_txtCaloricEaten;
    }
}
