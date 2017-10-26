namespace DietHolderClient.UserComponents
{
    partial class UcVideoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcVideoPlayer));
            this.btn_previousMovie = new System.Windows.Forms.Button();
            this.btn_nextMovie = new System.Windows.Forms.Button();
            this.lb_statement = new System.Windows.Forms.Label();
            this.panel_videoPlayer = new System.Windows.Forms.Panel();
            this.videoPlayer = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.btn_switchChannel = new System.Windows.Forms.Button();
            this.panel_videoPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_previousMovie
            // 
            this.btn_previousMovie.Location = new System.Drawing.Point(-1, 100);
            this.btn_previousMovie.Name = "btn_previousMovie";
            this.btn_previousMovie.Size = new System.Drawing.Size(33, 95);
            this.btn_previousMovie.TabIndex = 8;
            this.btn_previousMovie.Text = "<<";
            this.btn_previousMovie.UseVisualStyleBackColor = true;
            this.btn_previousMovie.Click += new System.EventHandler(this.btn_previousMovie_Click);
            // 
            // btn_nextMovie
            // 
            this.btn_nextMovie.Location = new System.Drawing.Point(692, 100);
            this.btn_nextMovie.Name = "btn_nextMovie";
            this.btn_nextMovie.Size = new System.Drawing.Size(35, 95);
            this.btn_nextMovie.TabIndex = 7;
            this.btn_nextMovie.Text = ">>";
            this.btn_nextMovie.UseVisualStyleBackColor = true;
            this.btn_nextMovie.Click += new System.EventHandler(this.btn_nextMovie_Click);
            // 
            // lb_statement
            // 
            this.lb_statement.AutoSize = true;
            this.lb_statement.Location = new System.Drawing.Point(291, 372);
            this.lb_statement.Name = "lb_statement";
            this.lb_statement.Size = new System.Drawing.Size(164, 17);
            this.lb_statement.TabIndex = 11;
            this.lb_statement.Text = "Kliknij, aby zmienić kanał";
            // 
            // panel_videoPlayer
            // 
            this.panel_videoPlayer.Controls.Add(this.videoPlayer);
            this.panel_videoPlayer.Location = new System.Drawing.Point(58, 12);
            this.panel_videoPlayer.Name = "panel_videoPlayer";
            this.panel_videoPlayer.Size = new System.Drawing.Size(615, 345);
            this.panel_videoPlayer.TabIndex = 10;
            // 
            // videoPlayer
            // 
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(148, 88);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(240, 240);
            this.videoPlayer.TabIndex = 0;
            // 
            // btn_switchChannel
            // 
            this.btn_switchChannel.Location = new System.Drawing.Point(279, 392);
            this.btn_switchChannel.Name = "btn_switchChannel";
            this.btn_switchChannel.Size = new System.Drawing.Size(187, 32);
            this.btn_switchChannel.TabIndex = 9;
            this.btn_switchChannel.Text = "Motywacja";
            this.btn_switchChannel.UseVisualStyleBackColor = true;
            this.btn_switchChannel.Click += new System.EventHandler(this.btn_switchChannel_Click);
            // 
            // UcVideoPlayercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_previousMovie);
            this.Controls.Add(this.btn_nextMovie);
            this.Controls.Add(this.lb_statement);
            this.Controls.Add(this.panel_videoPlayer);
            this.Controls.Add(this.btn_switchChannel);
            this.Name = "UcVideoPlayercs";
            this.Size = new System.Drawing.Size(739, 440);
            this.panel_videoPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_previousMovie;
        private System.Windows.Forms.Button btn_nextMovie;
        private System.Windows.Forms.Label lb_statement;
        private System.Windows.Forms.Panel panel_videoPlayer;
        private System.Windows.Forms.Button btn_switchChannel;
        private AxShockwaveFlashObjects.AxShockwaveFlash videoPlayer;
    }
}
