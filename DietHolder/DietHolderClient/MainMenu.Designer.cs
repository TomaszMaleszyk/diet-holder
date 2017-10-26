namespace DietHolderClient
{
    partial class MainMenu
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
            this.panel_mainPanel = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_moviePlayer = new System.Windows.Forms.Button();
            this.btn_dietStatistics = new System.Windows.Forms.Button();
            this.btn_calculateDailyCaloricIntake = new System.Windows.Forms.Button();
            this.btn_calculateDailyCaloricNeeds = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_mainPanel
            // 
            this.panel_mainPanel.Location = new System.Drawing.Point(218, 12);
            this.panel_mainPanel.Name = "panel_mainPanel";
            this.panel_mainPanel.Size = new System.Drawing.Size(999, 502);
            this.panel_mainPanel.TabIndex = 3;
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.btn_moviePlayer);
            this.panel_menu.Controls.Add(this.btn_dietStatistics);
            this.panel_menu.Controls.Add(this.btn_calculateDailyCaloricIntake);
            this.panel_menu.Controls.Add(this.btn_calculateDailyCaloricNeeds);
            this.panel_menu.Location = new System.Drawing.Point(12, 12);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(200, 502);
            this.panel_menu.TabIndex = 2;
            // 
            // btn_moviePlayer
            // 
            this.btn_moviePlayer.Location = new System.Drawing.Point(23, 273);
            this.btn_moviePlayer.Name = "btn_moviePlayer";
            this.btn_moviePlayer.Size = new System.Drawing.Size(138, 77);
            this.btn_moviePlayer.TabIndex = 3;
            this.btn_moviePlayer.Text = "Dawka wiedzy i motywacji";
            this.btn_moviePlayer.UseVisualStyleBackColor = true;
            this.btn_moviePlayer.Click += new System.EventHandler(this.btn_moviePlayer_Click);
            // 
            // btn_dietStatistics
            // 
            this.btn_dietStatistics.Location = new System.Drawing.Point(23, 190);
            this.btn_dietStatistics.Name = "btn_dietStatistics";
            this.btn_dietStatistics.Size = new System.Drawing.Size(138, 77);
            this.btn_dietStatistics.TabIndex = 2;
            this.btn_dietStatistics.Text = "Statystyka diety";
            this.btn_dietStatistics.UseVisualStyleBackColor = true;
            this.btn_dietStatistics.Click += new System.EventHandler(this.btn_dietStatistics_Click);
            // 
            // btn_calculateDailyCaloricIntake
            // 
            this.btn_calculateDailyCaloricIntake.Location = new System.Drawing.Point(23, 107);
            this.btn_calculateDailyCaloricIntake.Name = "btn_calculateDailyCaloricIntake";
            this.btn_calculateDailyCaloricIntake.Size = new System.Drawing.Size(138, 77);
            this.btn_calculateDailyCaloricIntake.TabIndex = 1;
            this.btn_calculateDailyCaloricIntake.Text = "Oblicz ilosc spozytych kalorii";
            this.btn_calculateDailyCaloricIntake.UseVisualStyleBackColor = true;
            this.btn_calculateDailyCaloricIntake.Click += new System.EventHandler(this.btn_calculateDailyCaloricIntake_Click);
            // 
            // btn_calculateDailyCaloricNeeds
            // 
            this.btn_calculateDailyCaloricNeeds.Location = new System.Drawing.Point(23, 24);
            this.btn_calculateDailyCaloricNeeds.Name = "btn_calculateDailyCaloricNeeds";
            this.btn_calculateDailyCaloricNeeds.Size = new System.Drawing.Size(138, 77);
            this.btn_calculateDailyCaloricNeeds.TabIndex = 0;
            this.btn_calculateDailyCaloricNeeds.Text = "Oblicz zapotrzebowanie kaloryczne";
            this.btn_calculateDailyCaloricNeeds.UseVisualStyleBackColor = true;
            this.btn_calculateDailyCaloricNeeds.Click += new System.EventHandler(this.btn_calculateDailyCaloricNeeds_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 522);
            this.Controls.Add(this.panel_mainPanel);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "DietHolder";
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_mainPanel;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_moviePlayer;
        private System.Windows.Forms.Button btn_dietStatistics;
        private System.Windows.Forms.Button btn_calculateDailyCaloricIntake;
        private System.Windows.Forms.Button btn_calculateDailyCaloricNeeds;
    }
}