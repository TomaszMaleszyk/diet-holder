using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DietHolderAdmin.ServiceReferenceDatabaseManager;

namespace DietHolderAdmin
{
    public partial class MainMenu : Form
    {
        private readonly DatabaseManagerClient databaseManager;
        private delegate void FunctionHandler();
        private readonly Dictionary<Enum, Delegate> ordersToDatabaseDictionary;
        private enum Options
        {
            AddProduct = 0,
            EditProductData = 2,
            DeleteProduct = 1
        }
        public MainMenu()
        {
            InitializeComponent();
            databaseManager = new DatabaseManagerClient();

            ordersToDatabaseDictionary = CreateFunctionDictionary();

            tb_productNameToSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_productNameToSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb_productNameToSearch.AutoCompleteCustomSource = GetStringCollectionOfProductsNames();

            cb_chooseOption.SelectedIndex = 0;
        }
        private Dictionary<Enum, Delegate> CreateFunctionDictionary()
        {
            var events = new Dictionary<Enum, Delegate>();

            FunctionHandler eventHandler = AddProduct;
            events.Add(Options.AddProduct, eventHandler);
            eventHandler = EditProductData;
            events.Add(Options.EditProductData, eventHandler);
            eventHandler = DeleteProduct;
            events.Add(Options.DeleteProduct, eventHandler);

            return events;
        }
        private AutoCompleteStringCollection GetStringCollectionOfProductsNames()
        {
            var productList = new List<string>();
            var dataToInteract = new DataToInteractWithDatabase { ProductName = "" };
            var searchProductResult = databaseManager.SearchProduct(dataToInteract);

            for(int dataTableRows = 0; dataTableRows < searchProductResult.Rows.Count; dataTableRows++)
            {
                productList.Add(searchProductResult.Rows[dataTableRows][1].ToString());
            }

            var productNameCollection = new AutoCompleteStringCollection();

            foreach(var productName in productList)
                productNameCollection.Add(productName);

            return productNameCollection;
        }
        private void btn_searchProduct_Click(object sender, EventArgs e)
        {
            var dataToInteract = new DataToInteractWithDatabase();

            if(!IsStringCorrect(tb_productNameToSearch.Text))
            {
                return;
            }

            var productName = tb_productNameToSearch.Text;

            if(IsProductLocatedInDatabaseProducts(productName))
            {
                dataToInteract.ProductName = tb_productNameToSearch.Text;
                dgv_databaseTable.DataSource = databaseManager.SearchProduct(dataToInteract);
            }
        }
        private bool IsProductLocatedInDatabaseProducts(string productName)
        {
            var dataToInteract = new DataToInteractWithDatabase { ProductName = productName };
            DataTable searchResult = null;
            try
            {
                searchResult = databaseManager.SearchProduct(dataToInteract);
            }
            catch(Exception exception)
            {
                DataBaseAlert(exception);
            }

            if(searchResult == null)
            {
                return false;
            }
            return true;
        }
        private static void DataBaseAlert(Exception exception)
        {
            if(exception is ArgumentNullException)
            {
                MessageBox.Show(@"Proszę podać nazwę produktu, który znajduje się w bazie danych.",
                    @"Komunikat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(exception.ToString(),
                    @"Komunikat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        private void btn_showProductChart_Click(object sender, EventArgs e)
        {
            var dataToInteract = new DataToInteractWithDatabase();

            if(!IsStringCorrect(tb_productNameToSearch.Text))
            {
                return;
            }

            var productNameToSearch = tb_productNameToSearch.Text;

            try
            {
                dataToInteract.ProductName = productNameToSearch;
                databaseManager.SearchProduct(dataToInteract);
            }
            catch(Exception exception)
            {
                DataBaseAlert(exception);
                return;
            }

            var panelWartosciOdzywczych = new MacronutrientsStatistics(productNameToSearch);
            panelWartosciOdzywczych.Show();
        }
        private static bool IsStringCorrect(string productNameToSearch)
        {
            if(string.IsNullOrEmpty(productNameToSearch))
            {
                MessageBox.Show(@"Proszę wprowadzić poprawne dane.",
                    @"Komunikat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        private void btn_showAllDatabasePositions_Click(object sender, EventArgs e)
        {
            ShowAllProductsFromDatabase();
        }
        private void ShowAllProductsFromDatabase()
        {
            var dataToInteract = new DataToInteractWithDatabase { ProductName = "" };
            dgv_databaseTable.DataSource =
                databaseManager.SearchProduct(dataToInteract); //problem z getAllProducts
        }
        private void AddProduct()
        {
            Product product = null;

            try
            {
                if(!IsStringCorrect(tb_productName.Text))
                {
                    return;
                }
                product = new Product
                {
                    ProductName = tb_productName.Text,
                    ProductCarboValue = double.Parse(numUD_carboValue.Text),
                    ProductProteinValue = double.Parse(numUD_proteinValue.Text),
                    ProductFatValue = double.Parse(numUD_fatValue.Text)
                };
            }
            catch(Exception)
            {
                InsertProductValuesAlert();
            }

            if(product == null)
                return;

            databaseManager.InsertProduct(product);
        }
        private static void InsertProductValuesAlert()
        {
            MessageBox.Show(@"Proszę wprowadzić poprawne dane.",
                @"Komunikat",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
        private void ClearProductDataInputs()
        {
            tb_productName.Text = "";
            numUD_carboValue.Text = "";
            numUD_proteinValue.Text = "";
            numUD_fatValue.Text = "";

            numUD_carboValue.Value = 0;
            numUD_proteinValue.Value = 0;
            numUD_fatValue.Value = 0;
        }
        private void EditProductData()
        {
            Product product = null;

            try
            {
                if(!IsStringCorrect(tb_productName.Text))
                {
                    return;
                }
                product = new Product
                {
                    ProductName = tb_productName.Text,
                    ProductCarboValue = double.Parse(numUD_carboValue.Text),
                    ProductProteinValue = double.Parse(numUD_proteinValue.Text),
                    ProductFatValue = double.Parse(numUD_fatValue.Text)
                };
            }
            catch(Exception)
            {
                InsertProductValuesAlert();
            }

            if(product == null)
                return;

            databaseManager.UpdateProduct(product);
        }
        private void DeleteProduct()
        {
            var dataToInteract = new DataToInteractWithDatabase();

            if(!IsStringCorrect(tb_productName.Text))
            {
                return;
            }

            dataToInteract.ProductName = tb_productName.Text;
            databaseManager.DeleteProduct(dataToInteract);
        }
        private void btn_confirmOperation_Click(object sender, EventArgs e)
        {
            CompareChoosenOptionToOrdersToDatabase();

            ShowAllProductsFromDatabase();
            ClearProductDataInputs();
            tb_productNameToSearch.AutoCompleteCustomSource = GetStringCollectionOfProductsNames();
        }
        private void CompareChoosenOptionToOrdersToDatabase()
        {
            foreach(var pair in ordersToDatabaseDictionary)
            {
                var choosenOption = cb_chooseOption.SelectedIndex;
                var valueOfKey = pair.Key;
                var numericValueOfEnum = (int)(Options)Enum.Parse(typeof(Options), valueOfKey.ToString());

                if(choosenOption == numericValueOfEnum)
                    pair.Value.DynamicInvoke();
            }
        }
        private void cb_chooseOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cb_chooseOption.SelectedIndex)
            {
                case 0:
                    numUD_carboValue.Enabled = true;
                    numUD_proteinValue.Enabled = true;
                    numUD_fatValue.Enabled = true;
                    break;
                case 1:
                    numUD_carboValue.Enabled = false;
                    numUD_proteinValue.Enabled = false;
                    numUD_fatValue.Enabled = false;
                    break;
                case 2:
                    numUD_carboValue.Enabled = true;
                    numUD_proteinValue.Enabled = true;
                    numUD_fatValue.Enabled = true;
                    break;

            }
        }
    }
}