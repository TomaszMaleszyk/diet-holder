using System;
using System.Windows.Forms;

namespace DietHolderClient.UserComponents
{
    public partial class UcVideoPlayer : UserControl
    {
        public string MovieTitle
        {
            get { return videoPlayer.Movie; }
            set { videoPlayer.Movie = value; }
        }
        public string GetPositionOfSwitcher => btn_switchChannel.Text;
        public event EventHandler NextMovie;
        private void btn_nextMovie_Click(object sender, EventArgs e)
        {
            NextMovie?.Invoke(this, e);
        }
        public event EventHandler PreviousMovie;
        private void btn_previousMovie_Click(object sender, EventArgs e)
        {
            PreviousMovie?.Invoke(this, e);
        }
        public event EventHandler Switcher;
        private void btn_switchChannel_Click(object sender, EventArgs e)
        {
            Switcher?.Invoke(this, e);
            switch(btn_switchChannel.Text)
            {
                case @"Motywacja":
                    btn_switchChannel.Text = @"Nauka";
                    break;
                case @"Nauka":
                    btn_switchChannel.Text = @"Motywacja";
                    break;
            }
        }
        public UcVideoPlayer()
        {
            InitializeComponent();
            videoPlayer.Dock = DockStyle.Fill;
        }
    }
}
