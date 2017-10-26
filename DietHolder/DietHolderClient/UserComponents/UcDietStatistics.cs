using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DietHolderClient.UserComponents
{
    public partial class UcDietStatistics : UserControl
    {
        public string RemainedCalorifyToEat
        {
            get { return lb_calorifyRemainedToEatValue.Text; }
            set { lb_calorifyRemainedToEatValue.Text = value; }
        }
        public string EatedCalorifyValue
        {
            get { return lb_calorifyEatenValue.Text; }
            set { lb_calorifyEatenValue.Text = value; }
        }
        private readonly double kcalFromCarbohydrates;
        private readonly double kcalFromProtein;
        private readonly double kcalFromFat;
        private readonly double caloriesRemainedToEat;
        public UcDietStatistics(double carbohydratesEaten, double proteinsEaten, double fatEaten, double caloriesRemainedToEat)
        {
            InitializeComponent();

            kcalFromCarbohydrates = carbohydratesEaten * 4;
            kcalFromProtein = proteinsEaten * 4;
            kcalFromFat = fatEaten * 9;
            this.caloriesRemainedToEat = caloriesRemainedToEat;

            SetDisplayedValueOfChart();
        }
        private void SetDisplayedValueOfChart()
        {
            double[] yValues = { kcalFromCarbohydrates, kcalFromProtein, kcalFromFat, caloriesRemainedToEat };
            string[] xValues = { "Węglowodany", "Białko", "Tłuszcze", "Pozostała pula do zagospodarowania" };

            chPie_DistributionOfIntakedCalorc.Series.Add("Makroskladniki");
            chPie_DistributionOfIntakedCalorc.Series["Makroskladniki"].Points.DataBindXY(xValues, yValues);

            chPie_DistributionOfIntakedCalorc.Series["Makroskladniki"].ChartType = SeriesChartType.Doughnut;
            chPie_DistributionOfIntakedCalorc.Series["Makroskladniki"]["PieLabelStyle"] = "Disabled";
            chPie_DistributionOfIntakedCalorc.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            chPie_DistributionOfIntakedCalorc.Legends[0].Enabled = true;

            chPie_DistributionOfIntakedCalorc.Series["Makroskladniki"].Points[0].Color = Color.RoyalBlue;
            chPie_DistributionOfIntakedCalorc.Series["Makroskladniki"].Points[1].Color = Color.Red;
            chPie_DistributionOfIntakedCalorc.Series["Makroskladniki"].Points[2].Color = Color.Orange;
            chPie_DistributionOfIntakedCalorc.Series["Makroskladniki"].Points[3].Color = Color.Gray;

            foreach(var dataPoint in chPie_DistributionOfIntakedCalorc.Series["Makroskladniki"].Points)
            {
                dataPoint.Label = "#PERCENT\n#VALX";
            }
        }

        private void chPie_DistributionOfIntakedCalorc_Click(object sender, System.EventArgs e)
        {

        }
    }
}
