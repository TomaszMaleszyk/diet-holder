namespace DietHolderAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_showAllDatabasePositions = new System.Windows.Forms.Button();
            this.numUD_fatValue = new System.Windows.Forms.NumericUpDown();
            this.numUD_carboValue = new System.Windows.Forms.NumericUpDown();
            this.numUD_proteinValue = new System.Windows.Forms.NumericUpDown();
            this.lb_chooseOption = new System.Windows.Forms.Label();
            this.cb_chooseOption = new System.Windows.Forms.ComboBox();
            this.btn_confirmOperation = new System.Windows.Forms.Button();
            this.lb_fat = new System.Windows.Forms.Label();
            this.lb_carbo = new System.Windows.Forms.Label();
            this.gb_findProduct = new System.Windows.Forms.GroupBox();
            this.btn_showProductChart = new System.Windows.Forms.Button();
            this.tb_productNameToSearch = new System.Windows.Forms.TextBox();
            this.btn_searchProduct = new System.Windows.Forms.Button();
            this.dgv_databaseTable = new System.Windows.Forms.DataGridView();
            this.lb_protein = new System.Windows.Forms.Label();
            this.lb_macronutrientsContent = new System.Windows.Forms.Label();
            this.lb_productName = new System.Windows.Forms.Label();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.gb_addProduct = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_fatValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_carboValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_proteinValue)).BeginInit();
            this.gb_findProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_databaseTable)).BeginInit();
            this.gb_addProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_showAllDatabasePositions
            // 
            this.btn_showAllDatabasePositions.Location = new System.Drawing.Point(69, 86);
            this.btn_showAllDatabasePositions.Name = "btn_showAllDatabasePositions";
            this.btn_showAllDatabasePositions.Size = new System.Drawing.Size(252, 32);
            this.btn_showAllDatabasePositions.TabIndex = 7;
            this.btn_showAllDatabasePositions.Text = "Wyswietl całą bazę produktów";
            this.btn_showAllDatabasePositions.UseVisualStyleBackColor = true;
            this.btn_showAllDatabasePositions.Click += new System.EventHandler(this.btn_showAllDatabasePositions_Click);
            // 
            // numUD_fatValue
            // 
            this.numUD_fatValue.Location = new System.Drawing.Point(281, 138);
            this.numUD_fatValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numUD_fatValue.Name = "numUD_fatValue";
            this.numUD_fatValue.Size = new System.Drawing.Size(80, 22);
            this.numUD_fatValue.TabIndex = 12;
            // 
            // numUD_carboValue
            // 
            this.numUD_carboValue.Location = new System.Drawing.Point(155, 138);
            this.numUD_carboValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numUD_carboValue.Name = "numUD_carboValue";
            this.numUD_carboValue.Size = new System.Drawing.Size(80, 22);
            this.numUD_carboValue.TabIndex = 11;
            // 
            // numUD_proteinValue
            // 
            this.numUD_proteinValue.Location = new System.Drawing.Point(29, 138);
            this.numUD_proteinValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numUD_proteinValue.Name = "numUD_proteinValue";
            this.numUD_proteinValue.Size = new System.Drawing.Size(80, 22);
            this.numUD_proteinValue.TabIndex = 10;
            // 
            // lb_chooseOption
            // 
            this.lb_chooseOption.AutoSize = true;
            this.lb_chooseOption.Location = new System.Drawing.Point(66, 18);
            this.lb_chooseOption.Name = "lb_chooseOption";
            this.lb_chooseOption.Size = new System.Drawing.Size(97, 17);
            this.lb_chooseOption.TabIndex = 9;
            this.lb_chooseOption.Text = "Wybierz opcje";
            // 
            // cb_chooseOption
            // 
            this.cb_chooseOption.FormattingEnabled = true;
            this.cb_chooseOption.Items.AddRange(new object[] {
            "Dodaj produkt",
            "Usuń produkt",
            "Edytuj produkt"});
            this.cb_chooseOption.Location = new System.Drawing.Point(69, 46);
            this.cb_chooseOption.Name = "cb_chooseOption";
            this.cb_chooseOption.Size = new System.Drawing.Size(252, 24);
            this.cb_chooseOption.TabIndex = 5;
            this.cb_chooseOption.SelectedIndexChanged += new System.EventHandler(this.cb_chooseOption_SelectedIndexChanged);
            // 
            // btn_confirmOperation
            // 
            this.btn_confirmOperation.Location = new System.Drawing.Point(69, 192);
            this.btn_confirmOperation.Name = "btn_confirmOperation";
            this.btn_confirmOperation.Size = new System.Drawing.Size(252, 70);
            this.btn_confirmOperation.TabIndex = 3;
            this.btn_confirmOperation.Text = "Potwierdź operacje";
            this.btn_confirmOperation.UseVisualStyleBackColor = true;
            this.btn_confirmOperation.Click += new System.EventHandler(this.btn_confirmOperation_Click);
            // 
            // lb_fat
            // 
            this.lb_fat.AutoSize = true;
            this.lb_fat.Location = new System.Drawing.Point(278, 163);
            this.lb_fat.Name = "lb_fat";
            this.lb_fat.Size = new System.Drawing.Size(64, 17);
            this.lb_fat.TabIndex = 8;
            this.lb_fat.Text = "Tłuszcze";
            // 
            // lb_carbo
            // 
            this.lb_carbo.AutoSize = true;
            this.lb_carbo.Location = new System.Drawing.Point(152, 163);
            this.lb_carbo.Name = "lb_carbo";
            this.lb_carbo.Size = new System.Drawing.Size(96, 17);
            this.lb_carbo.TabIndex = 7;
            this.lb_carbo.Text = "Węglowodany";
            // 
            // gb_findProduct
            // 
            this.gb_findProduct.Controls.Add(this.btn_showProductChart);
            this.gb_findProduct.Controls.Add(this.btn_showAllDatabasePositions);
            this.gb_findProduct.Controls.Add(this.tb_productNameToSearch);
            this.gb_findProduct.Controls.Add(this.btn_searchProduct);
            this.gb_findProduct.Location = new System.Drawing.Point(12, 12);
            this.gb_findProduct.Name = "gb_findProduct";
            this.gb_findProduct.Size = new System.Drawing.Size(395, 124);
            this.gb_findProduct.TabIndex = 10;
            this.gb_findProduct.TabStop = false;
            // 
            // btn_showProductChart
            // 
            this.btn_showProductChart.Location = new System.Drawing.Point(69, 49);
            this.btn_showProductChart.Name = "btn_showProductChart";
            this.btn_showProductChart.Size = new System.Drawing.Size(252, 31);
            this.btn_showProductChart.TabIndex = 8;
            this.btn_showProductChart.Text = "Wykres";
            this.btn_showProductChart.UseVisualStyleBackColor = true;
            this.btn_showProductChart.Click += new System.EventHandler(this.btn_showProductChart_Click);
            // 
            // tb_productNameToSearch
            // 
            this.tb_productNameToSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_productNameToSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_productNameToSearch.Location = new System.Drawing.Point(69, 21);
            this.tb_productNameToSearch.Name = "tb_productNameToSearch";
            this.tb_productNameToSearch.Size = new System.Drawing.Size(202, 22);
            this.tb_productNameToSearch.TabIndex = 6;
            // 
            // btn_searchProduct
            // 
            this.btn_searchProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_searchProduct.Image")));
            this.btn_searchProduct.Location = new System.Drawing.Point(281, 21);
            this.btn_searchProduct.Name = "btn_searchProduct";
            this.btn_searchProduct.Size = new System.Drawing.Size(40, 22);
            this.btn_searchProduct.TabIndex = 5;
            this.btn_searchProduct.UseVisualStyleBackColor = true;
            this.btn_searchProduct.Click += new System.EventHandler(this.btn_searchProduct_Click);
            // 
            // dgv_databaseTable
            // 
            this.dgv_databaseTable.AllowUserToAddRows = false;
            this.dgv_databaseTable.AllowUserToDeleteRows = false;
            this.dgv_databaseTable.AllowUserToResizeColumns = false;
            this.dgv_databaseTable.AllowUserToResizeRows = false;
            this.dgv_databaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_databaseTable.Location = new System.Drawing.Point(436, 12);
            this.dgv_databaseTable.Name = "dgv_databaseTable";
            this.dgv_databaseTable.ReadOnly = true;
            this.dgv_databaseTable.RowTemplate.Height = 24;
            this.dgv_databaseTable.Size = new System.Drawing.Size(814, 332);
            this.dgv_databaseTable.TabIndex = 9;
            // 
            // lb_protein
            // 
            this.lb_protein.AutoSize = true;
            this.lb_protein.Location = new System.Drawing.Point(49, 163);
            this.lb_protein.Name = "lb_protein";
            this.lb_protein.Size = new System.Drawing.Size(46, 17);
            this.lb_protein.TabIndex = 1;
            this.lb_protein.Text = "Białko";
            // 
            // lb_macronutrientsContent
            // 
            this.lb_macronutrientsContent.AutoSize = true;
            this.lb_macronutrientsContent.Location = new System.Drawing.Point(115, 118);
            this.lb_macronutrientsContent.Name = "lb_macronutrientsContent";
            this.lb_macronutrientsContent.Size = new System.Drawing.Size(173, 17);
            this.lb_macronutrientsContent.TabIndex = 1;
            this.lb_macronutrientsContent.Text = "Zawartość w 100 gramach";
            // 
            // lb_productName
            // 
            this.lb_productName.AutoSize = true;
            this.lb_productName.Location = new System.Drawing.Point(66, 73);
            this.lb_productName.Name = "lb_productName";
            this.lb_productName.Size = new System.Drawing.Size(110, 17);
            this.lb_productName.TabIndex = 1;
            this.lb_productName.Text = "Nazwa produktu";
            // 
            // tb_productName
            // 
            this.tb_productName.Location = new System.Drawing.Point(69, 93);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(252, 22);
            this.tb_productName.TabIndex = 0;
            // 
            // gb_addProduct
            // 
            this.gb_addProduct.Controls.Add(this.numUD_fatValue);
            this.gb_addProduct.Controls.Add(this.numUD_carboValue);
            this.gb_addProduct.Controls.Add(this.numUD_proteinValue);
            this.gb_addProduct.Controls.Add(this.lb_chooseOption);
            this.gb_addProduct.Controls.Add(this.cb_chooseOption);
            this.gb_addProduct.Controls.Add(this.btn_confirmOperation);
            this.gb_addProduct.Controls.Add(this.lb_fat);
            this.gb_addProduct.Controls.Add(this.lb_carbo);
            this.gb_addProduct.Controls.Add(this.lb_protein);
            this.gb_addProduct.Controls.Add(this.lb_macronutrientsContent);
            this.gb_addProduct.Controls.Add(this.lb_productName);
            this.gb_addProduct.Controls.Add(this.tb_productName);
            this.gb_addProduct.Location = new System.Drawing.Point(12, 142);
            this.gb_addProduct.Name = "gb_addProduct";
            this.gb_addProduct.Size = new System.Drawing.Size(395, 268);
            this.gb_addProduct.TabIndex = 8;
            this.gb_addProduct.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 422);
            this.Controls.Add(this.gb_findProduct);
            this.Controls.Add(this.dgv_databaseTable);
            this.Controls.Add(this.gb_addProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "DietHolder manager";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_fatValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_carboValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_proteinValue)).EndInit();
            this.gb_findProduct.ResumeLayout(false);
            this.gb_findProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_databaseTable)).EndInit();
            this.gb_addProduct.ResumeLayout(false);
            this.gb_addProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_showAllDatabasePositions;
        private System.Windows.Forms.NumericUpDown numUD_fatValue;
        private System.Windows.Forms.NumericUpDown numUD_carboValue;
        private System.Windows.Forms.NumericUpDown numUD_proteinValue;
        private System.Windows.Forms.Label lb_chooseOption;
        private System.Windows.Forms.ComboBox cb_chooseOption;
        private System.Windows.Forms.Button btn_confirmOperation;
        private System.Windows.Forms.Label lb_fat;
        private System.Windows.Forms.Label lb_carbo;
        private System.Windows.Forms.GroupBox gb_findProduct;
        private System.Windows.Forms.Button btn_showProductChart;
        private System.Windows.Forms.TextBox tb_productNameToSearch;
        private System.Windows.Forms.Button btn_searchProduct;
        private System.Windows.Forms.DataGridView dgv_databaseTable;
        private System.Windows.Forms.Label lb_protein;
        private System.Windows.Forms.Label lb_macronutrientsContent;
        private System.Windows.Forms.Label lb_productName;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.GroupBox gb_addProduct;
    }
}

