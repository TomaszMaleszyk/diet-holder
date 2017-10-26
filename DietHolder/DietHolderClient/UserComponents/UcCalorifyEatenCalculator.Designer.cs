namespace DietHolderClient.UserComponents
{
    partial class UcCalorifyEatenCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCalorifyEatenCalculator));
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.datagv_searchResults = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.datagv_eatenProducts = new System.Windows.Forms.DataGridView();
            this.panel_calorifyTables = new System.Windows.Forms.Panel();
            this.lb_statementCaloriesEaten = new System.Windows.Forms.Label();
            this.datagv_eatenCalorify = new System.Windows.Forms.DataGridView();
            this.tb_nameOfProductToSearch = new System.Windows.Forms.TextBox();
            this.panel_searchData = new System.Windows.Forms.Panel();
            this.numUD_productWeight = new System.Windows.Forms.NumericUpDown();
            this.cb_productChoice = new System.Windows.Forms.ComboBox();
            this.gb_deleteProductData = new System.Windows.Forms.GroupBox();
            this.cb_productToDelete = new System.Windows.Forms.ComboBox();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_searchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_eatenProducts)).BeginInit();
            this.panel_calorifyTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_eatenCalorify)).BeginInit();
            this.panel_searchData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_productWeight)).BeginInit();
            this.gb_deleteProductData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(311, 9);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(105, 58);
            this.btn_addProduct.TabIndex = 0;
            this.btn_addProduct.Text = "Dodaj produkt";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // datagv_searchResults
            // 
            this.datagv_searchResults.AllowUserToAddRows = false;
            this.datagv_searchResults.AllowUserToDeleteRows = false;
            this.datagv_searchResults.AllowUserToResizeColumns = false;
            this.datagv_searchResults.AllowUserToResizeRows = false;
            this.datagv_searchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_searchResults.Location = new System.Drawing.Point(462, 12);
            this.datagv_searchResults.Name = "datagv_searchResults";
            this.datagv_searchResults.ReadOnly = true;
            this.datagv_searchResults.RowHeadersWidth = 40;
            this.datagv_searchResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagv_searchResults.RowTemplate.Height = 24;
            this.datagv_searchResults.Size = new System.Drawing.Size(518, 472);
            this.datagv_searchResults.TabIndex = 9;
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(272, 8);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(33, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // datagv_eatenProducts
            // 
            this.datagv_eatenProducts.AllowUserToAddRows = false;
            this.datagv_eatenProducts.AllowUserToDeleteRows = false;
            this.datagv_eatenProducts.AllowUserToResizeColumns = false;
            this.datagv_eatenProducts.AllowUserToResizeRows = false;
            this.datagv_eatenProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagv_eatenProducts.ColumnHeadersHeight = 22;
            this.datagv_eatenProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagv_eatenProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.datagv_eatenProducts.Location = new System.Drawing.Point(3, 3);
            this.datagv_eatenProducts.Name = "datagv_eatenProducts";
            this.datagv_eatenProducts.ReadOnly = true;
            this.datagv_eatenProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagv_eatenProducts.RowTemplate.Height = 20;
            this.datagv_eatenProducts.RowTemplate.ReadOnly = true;
            this.datagv_eatenProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datagv_eatenProducts.Size = new System.Drawing.Size(413, 202);
            this.datagv_eatenProducts.TabIndex = 5;
            // 
            // panel_calorifyTables
            // 
            this.panel_calorifyTables.Controls.Add(this.lb_statementCaloriesEaten);
            this.panel_calorifyTables.Controls.Add(this.datagv_eatenCalorify);
            this.panel_calorifyTables.Controls.Add(this.datagv_eatenProducts);
            this.panel_calorifyTables.Location = new System.Drawing.Point(6, 176);
            this.panel_calorifyTables.Name = "panel_calorifyTables";
            this.panel_calorifyTables.Size = new System.Drawing.Size(423, 308);
            this.panel_calorifyTables.TabIndex = 10;
            // 
            // lb_statementCaloriesEaten
            // 
            this.lb_statementCaloriesEaten.AutoSize = true;
            this.lb_statementCaloriesEaten.Location = new System.Drawing.Point(10, 208);
            this.lb_statementCaloriesEaten.Name = "lb_statementCaloriesEaten";
            this.lb_statementCaloriesEaten.Size = new System.Drawing.Size(299, 17);
            this.lb_statementCaloriesEaten.TabIndex = 7;
            this.lb_statementCaloriesEaten.Text = "Suma spożytych makroskładników oraz kalorii:";
            // 
            // datagv_eatenCalorify
            // 
            this.datagv_eatenCalorify.AllowUserToAddRows = false;
            this.datagv_eatenCalorify.AllowUserToDeleteRows = false;
            this.datagv_eatenCalorify.AllowUserToResizeColumns = false;
            this.datagv_eatenCalorify.AllowUserToResizeRows = false;
            this.datagv_eatenCalorify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_eatenCalorify.Location = new System.Drawing.Point(3, 245);
            this.datagv_eatenCalorify.Name = "datagv_eatenCalorify";
            this.datagv_eatenCalorify.ReadOnly = true;
            this.datagv_eatenCalorify.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagv_eatenCalorify.RowTemplate.Height = 24;
            this.datagv_eatenCalorify.Size = new System.Drawing.Size(413, 60);
            this.datagv_eatenCalorify.TabIndex = 6;
            // 
            // tb_nameOfProductToSearch
            // 
            this.tb_nameOfProductToSearch.Location = new System.Drawing.Point(3, 8);
            this.tb_nameOfProductToSearch.Name = "tb_nameOfProductToSearch";
            this.tb_nameOfProductToSearch.Size = new System.Drawing.Size(263, 22);
            this.tb_nameOfProductToSearch.TabIndex = 3;
            // 
            // panel_searchData
            // 
            this.panel_searchData.Controls.Add(this.numUD_productWeight);
            this.panel_searchData.Controls.Add(this.cb_productChoice);
            this.panel_searchData.Controls.Add(this.tb_nameOfProductToSearch);
            this.panel_searchData.Controls.Add(this.btn_search);
            this.panel_searchData.Controls.Add(this.btn_addProduct);
            this.panel_searchData.Location = new System.Drawing.Point(3, 12);
            this.panel_searchData.Name = "panel_searchData";
            this.panel_searchData.Size = new System.Drawing.Size(426, 82);
            this.panel_searchData.TabIndex = 11;
            // 
            // numUD_productWeight
            // 
            this.numUD_productWeight.Location = new System.Drawing.Point(230, 45);
            this.numUD_productWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUD_productWeight.Name = "numUD_productWeight";
            this.numUD_productWeight.Size = new System.Drawing.Size(75, 22);
            this.numUD_productWeight.TabIndex = 6;
            // 
            // cb_productChoice
            // 
            this.cb_productChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_productChoice.FormattingEnabled = true;
            this.cb_productChoice.Location = new System.Drawing.Point(3, 43);
            this.cb_productChoice.Name = "cb_productChoice";
            this.cb_productChoice.Size = new System.Drawing.Size(221, 24);
            this.cb_productChoice.TabIndex = 5;
            // 
            // gb_deleteProductData
            // 
            this.gb_deleteProductData.Controls.Add(this.cb_productToDelete);
            this.gb_deleteProductData.Controls.Add(this.btn_deleteProduct);
            this.gb_deleteProductData.Location = new System.Drawing.Point(3, 100);
            this.gb_deleteProductData.Name = "gb_deleteProductData";
            this.gb_deleteProductData.Size = new System.Drawing.Size(426, 70);
            this.gb_deleteProductData.TabIndex = 12;
            this.gb_deleteProductData.TabStop = false;
            this.gb_deleteProductData.Text = "Usuń produkt";
            // 
            // cb_productToDelete
            // 
            this.cb_productToDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_productToDelete.FormattingEnabled = true;
            this.cb_productToDelete.Location = new System.Drawing.Point(6, 21);
            this.cb_productToDelete.Name = "cb_productToDelete";
            this.cb_productToDelete.Size = new System.Drawing.Size(218, 24);
            this.cb_productToDelete.TabIndex = 7;
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Location = new System.Drawing.Point(230, 11);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(186, 43);
            this.btn_deleteProduct.TabIndex = 6;
            this.btn_deleteProduct.Text = "Usuń produkt";
            this.btn_deleteProduct.UseVisualStyleBackColor = true;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // UcCalorifyEatenCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datagv_searchResults);
            this.Controls.Add(this.panel_calorifyTables);
            this.Controls.Add(this.panel_searchData);
            this.Controls.Add(this.gb_deleteProductData);
            this.Name = "UcCalorifyEatenCalculator";
            this.Size = new System.Drawing.Size(986, 503);
            ((System.ComponentModel.ISupportInitialize)(this.datagv_searchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_eatenProducts)).EndInit();
            this.panel_calorifyTables.ResumeLayout(false);
            this.panel_calorifyTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_eatenCalorify)).EndInit();
            this.panel_searchData.ResumeLayout(false);
            this.panel_searchData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_productWeight)).EndInit();
            this.gb_deleteProductData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.DataGridView datagv_searchResults;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView datagv_eatenProducts;
        private System.Windows.Forms.Panel panel_calorifyTables;
        private System.Windows.Forms.Label lb_statementCaloriesEaten;
        private System.Windows.Forms.DataGridView datagv_eatenCalorify;
        private System.Windows.Forms.TextBox tb_nameOfProductToSearch;
        private System.Windows.Forms.Panel panel_searchData;
        private System.Windows.Forms.NumericUpDown numUD_productWeight;
        private System.Windows.Forms.ComboBox cb_productChoice;
        private System.Windows.Forms.GroupBox gb_deleteProductData;
        private System.Windows.Forms.ComboBox cb_productToDelete;
        private System.Windows.Forms.Button btn_deleteProduct;
    }
}
