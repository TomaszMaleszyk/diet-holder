using System;
using System.Data;
using System.Windows.Forms;
using DietHolderAdmin.ServiceReferenceDatabaseManager;
using static System.Double;

namespace DietHolderAdmin
{
    public partial class MacronutrientsStatistics : Form
    {
        private readonly DatabaseManagerClient databaseManager;
        private int productCounter;
        public MacronutrientsStatistics(string productNameToSearch)
        {
            InitializeComponent();
            var productNameToCompare = productNameToSearch;

            databaseManager = new DatabaseManagerClient();
            productCounter = 0;

            UpdateComboBoxItems();
            cb_chooseProducts.SelectedIndex = 0;

            CompareProducts(productNameToCompare);
        }
        private void btn_compareProducts_Click(object sender, EventArgs e)
        {
            if(productCounter < 4)
            {
                CompareProducts(cb_chooseProducts.SelectedItem.ToString());

                var komunikat = $"Pozostała możliwość porównania jeszcze: {4 - productCounter} produktow. ";
                MessageBox.Show(komunikat);
            }
            else
            {
                MessageBox.Show(@"Liczba porównywanych produktow jest zbyt duża");
            }
        }
        private void UpdateComboBoxItems()
        {
            var interactWithDatabase = new DataToInteractWithDatabase { ProductName = "" };
            var dataTable = databaseManager.SearchProduct(interactWithDatabase);

            for(var dataTableRow = 0; dataTableRow < dataTable.Rows.Count; dataTableRow++)
            {
                var comboBoxNewItem = dataTable.Rows[dataTableRow][1].ToString();
                cb_chooseProducts.Items.Add(comboBoxNewItem);
            }
        }
        private void CompareProducts(string productToCompare)
        {
            if(IsProductLocatedOnChart(productToCompare))
            {
                ProductsIsOnChartAlert();
                return;
            }
            var productData = GetProductData(productToCompare);

            if (productData != null)
            {
                var legend = productData.Rows[0][1].ToString();

                var proteinValue = Parse(productData.Rows[0][2].ToString());
                var carboValue = Parse(productData.Rows[0][3].ToString());
                var fatValue = Parse(productData.Rows[0][4].ToString());
                var calorify = Parse(productData.Rows[0][5].ToString());

                ch_firstChart.Series.Add(legend);
                ch_secondChart.Series.Add(legend);

                ch_firstChart.Series[legend].Points.AddXY("Weglowodany (gram)", carboValue);
                ch_firstChart.Series[legend].Points.AddXY("Bialko", proteinValue);
                ch_firstChart.Series[legend].Points.AddXY("Tluszcze", fatValue);

                ch_secondChart.Series[legend].Points.AddXY("Kalorycznosc produktu (kcal)", calorify);
            }

            productCounter++;
        }
        private bool IsProductLocatedOnChart(string productToCompare)
        {
            for(var seriesIndex = 0; seriesIndex < ch_firstChart.Series.Count; seriesIndex++)
            {
                if(productToCompare == ch_firstChart.Series[seriesIndex].Name)
                {
                    return true;
                }
            }
            return false;
        }
        private static void ProductsIsOnChartAlert()
        {
            MessageBox.Show(@"Produkt znajduje się już na liście",
                @"Komunikat",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
        private DataTable GetProductData(string productToCompare)
        {
            var interactWithDatabase = new DataToInteractWithDatabase { ProductName = productToCompare };
            var searchResult = databaseManager.SearchProduct(interactWithDatabase);

            return searchResult;
        }
    }
}
