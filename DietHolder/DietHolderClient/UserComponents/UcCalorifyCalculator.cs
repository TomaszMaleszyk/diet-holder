using System;
using System.Globalization;
using System.Windows.Forms;

namespace DietHolderClient.UserComponents
{
    public partial class UcCalorifyCalculator : UserControl
    {
        public double PersonCaloriesToEatValue
        {
            set { lb_calorifyToEat.Text = value.ToString(CultureInfo.InvariantCulture); }
        }
        public double CarboValue
        {
            set { lb_carbohydrates.Text = value.ToString(CultureInfo.InvariantCulture); }
        }
        public double ProteinValue
        {
            set { lb_protein.Text = value.ToString(CultureInfo.InvariantCulture); }
        }
        public double FatValue
        {
            set { lb_fat.Text = value.ToString(CultureInfo.InvariantCulture); }
        }
        public int PersonHeight => int.Parse(txtbox_height.Text);
        public int PersonWeight => int.Parse(txtbox_weight.Text);
        public int PersonAge => int.Parse(txtbox_age.Text);
        public string PersonActivity => cb_activity.Text;
        public string PersonGoal => cb_goal.Text;
        public string PersonPosture => cb_posture.Text;
        public bool IsMan => rb_man.Checked;
        public bool IsWoman => rb_women.Checked;
        public event EventHandler CalculateNeededCalorify;
        private void btn_calculateCalorify_Click(object sender, EventArgs e)
        {
            CalculateNeededCalorify?.Invoke(this, e);
        }
        public UcCalorifyCalculator()
        {
            InitializeComponent();

            rb_man.Checked = true;
            cb_activity.SelectedIndex = 0;
            cb_goal.SelectedIndex = 0;
            cb_posture.SelectedIndex = 0;
        }
    }
}
