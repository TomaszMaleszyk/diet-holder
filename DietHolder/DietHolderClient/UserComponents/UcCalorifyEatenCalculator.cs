using System;
using System.Drawing;
using System.Windows.Forms;

namespace DietHolderClient.UserComponents
{
    public partial class UcCalorifyEatenCalculator : UserControl
    {
        public object ProductTableSearchResults
        {
            get { return datagv_searchResults.DataSource; }
            set { datagv_searchResults.DataSource = value; }
        }
        public object ProductTableEatenProducts
        {
            get { return datagv_eatenProducts.DataSource; }
            set { datagv_eatenProducts.DataSource = value; }
        }
        public object ProductTableEatenCalorify
        {
            get { return datagv_eatenCalorify.DataSource; }
            set { datagv_eatenCalorify.DataSource = value; }
        }
        public string ProductNameToSearch
        {
            get { return tb_nameOfProductToSearch.Text; }
            set { tb_nameOfProductToSearch.Text = value; }
        }
        public string ProductToAdd
        {
            get { return cb_productChoice.Text; }
            set { cb_productChoice.Text = value; }
        }
        public string ProductToDelete
        {
            get { return cb_productToDelete.Text; }
            set { cb_productToDelete.Text = value; }
        }
        public string ProductWeight
        {
            get { return numUD_productWeight.Text; }
            set { numUD_productWeight.Text = value; }
        }
        public object ProductsList
        {
            get { return cb_productChoice.Items; }
            set { cb_productChoice.DataSource = value; }
        }
        public object AddedProductsList
        {
            get { return cb_productToDelete.Items; }
            set { cb_productToDelete.DataSource = value; }
        }
        public event EventHandler SearchProduct;
        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchProduct?.Invoke(this, e);
        }
        public event EventHandler AddProduct;
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            AddProduct?.Invoke(this, e);
        }
        public event EventHandler DeleteProduct;
        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct?.Invoke(this, e);
        }
        public UcCalorifyEatenCalculator()
        {
            InitializeComponent();

            datagv_searchResults.RowsDefaultCellStyle.BackColor = Color.Bisque;
            datagv_searchResults.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            datagv_searchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            datagv_eatenProducts.RowsDefaultCellStyle.BackColor = Color.Bisque;
            datagv_eatenProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            datagv_eatenProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            datagv_eatenCalorify.RowsDefaultCellStyle.BackColor = Color.Bisque;
            datagv_eatenCalorify.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            datagv_eatenCalorify.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
