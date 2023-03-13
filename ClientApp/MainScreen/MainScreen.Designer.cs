

namespace ClientApp
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTitle = new System.Windows.Forms.Label();
            this.dataPartsGrid = new System.Windows.Forms.DataGridView();
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTitle = new System.Windows.Forms.Label();
            this.searchParts = new System.Windows.Forms.Button();
            this.searchBoxParts = new System.Windows.Forms.TextBox();
            this.dataProductGrid = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTitle = new System.Windows.Forms.Label();
            this.searchBoxProducts = new System.Windows.Forms.TextBox();
            this.searchProduct = new System.Windows.Forms.Button();
            this.addPart = new System.Windows.Forms.Button();
            this.modifyPart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.inventoryDBContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDBContextBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDBContextBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBContextBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBContextBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainTitle.Location = new System.Drawing.Point(12, 9);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(271, 25);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Inventory Management System";
            // 
            // dataPartsGrid
            // 
            this.dataPartsGrid.AutoGenerateColumns = false;
            this.dataPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPartsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn});
            this.dataPartsGrid.DataSource = this.productPartBindingSource;
            this.dataPartsGrid.Location = new System.Drawing.Point(27, 123);
            this.dataPartsGrid.Name = "dataPartsGrid";
            this.dataPartsGrid.RowHeadersVisible = false;
            this.dataPartsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataPartsGrid.RowTemplate.Height = 25;
            this.dataPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPartsGrid.Size = new System.Drawing.Size(603, 292);
            this.dataPartsGrid.TabIndex = 1;

            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            // 
            // productPartBindingSource
            // 
            this.productPartBindingSource.DataSource = typeof(DAL.Models.ProductPart);
            // 
            // partsTitle
            // 
            this.partsTitle.AutoSize = true;
            this.partsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partsTitle.Location = new System.Drawing.Point(20, 95);
            this.partsTitle.Name = "partsTitle";
            this.partsTitle.Size = new System.Drawing.Size(53, 25);
            this.partsTitle.TabIndex = 2;
            this.partsTitle.Text = "Parts";
            // 
            // searchParts
            // 
            this.searchParts.Location = new System.Drawing.Point(417, 69);
            this.searchParts.Name = "searchParts";
            this.searchParts.Size = new System.Drawing.Size(53, 23);
            this.searchParts.TabIndex = 3;
            this.searchParts.Text = "Search";
            this.searchParts.UseVisualStyleBackColor = true;
            // 
            // searchBoxParts
            // 
            this.searchBoxParts.Location = new System.Drawing.Point(476, 70);
            this.searchBoxParts.Name = "searchBoxParts";
            this.searchBoxParts.Size = new System.Drawing.Size(154, 23);
            this.searchBoxParts.TabIndex = 4;
            // 
            // dataProductGrid
            // 
            this.dataProductGrid.AutoGenerateColumns = false;
            this.dataProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.inStockDataGridViewTextBoxColumn1,
            this.minDataGridViewTextBoxColumn1,
            this.maxDataGridViewTextBoxColumn1});
            this.dataProductGrid.DataSource = this.productBindingSource1;
            this.dataProductGrid.Location = new System.Drawing.Point(702, 123);
            this.dataProductGrid.Name = "dataProductGrid";
            this.dataProductGrid.RowHeadersVisible = false;
            this.dataProductGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataProductGrid.RowTemplate.Height = 25;
            this.dataProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProductGrid.Size = new System.Drawing.Size(603, 292);
            this.dataProductGrid.TabIndex = 5;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // inStockDataGridViewTextBoxColumn1
            // 
            this.inStockDataGridViewTextBoxColumn1.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn1.HeaderText = "InStock";
            this.inStockDataGridViewTextBoxColumn1.Name = "inStockDataGridViewTextBoxColumn1";
            // 
            // minDataGridViewTextBoxColumn1
            // 
            this.minDataGridViewTextBoxColumn1.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn1.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn1.Name = "minDataGridViewTextBoxColumn1";
            // 
            // maxDataGridViewTextBoxColumn1
            // 
            this.maxDataGridViewTextBoxColumn1.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn1.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn1.Name = "maxDataGridViewTextBoxColumn1";
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(DAL.Models.Product);
            // 
            // productTitle
            // 
            this.productTitle.AutoSize = true;
            this.productTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productTitle.Location = new System.Drawing.Point(695, 95);
            this.productTitle.Name = "productTitle";
            this.productTitle.Size = new System.Drawing.Size(86, 25);
            this.productTitle.TabIndex = 6;
            this.productTitle.Text = "Products";
            // 
            // searchBoxProducts
            // 
            this.searchBoxProducts.Location = new System.Drawing.Point(1151, 69);
            this.searchBoxProducts.Name = "searchBoxProducts";
            this.searchBoxProducts.Size = new System.Drawing.Size(154, 23);
            this.searchBoxProducts.TabIndex = 8;
            // 
            // searchProduct
            // 
            this.searchProduct.Location = new System.Drawing.Point(1092, 68);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(53, 23);
            this.searchProduct.TabIndex = 7;
            this.searchProduct.Text = "Search";
            this.searchProduct.UseVisualStyleBackColor = true;
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(435, 454);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(54, 34);
            this.addPart.TabIndex = 9;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // modifyPart
            // 
            this.modifyPart.Location = new System.Drawing.Point(505, 454);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(54, 34);
            this.modifyPart.TabIndex = 10;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            this.modifyPart.Click += new System.EventHandler(this.modifyPart_Click);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(574, 454);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(56, 34);
            this.deletePart.TabIndex = 11;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(1249, 454);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(56, 34);
            this.deleteProduct.TabIndex = 14;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(1180, 454);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(54, 34);
            this.modifyProduct.TabIndex = 13;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(1110, 454);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(54, 34);
            this.addProduct.TabIndex = 12;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1249, 539);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(56, 33);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // inventoryDBContextBindingSource
            // 
            this.inventoryDBContextBindingSource.DataSource = typeof(DAL.DataContext.InventoryDBContext);
            // 
            // inventoryDBContextBindingSource1
            // 
            this.inventoryDBContextBindingSource1.DataSource = typeof(DAL.DataContext.InventoryDBContext);
            // 
            // inventoryDBContextBindingSource2
            // 
            this.inventoryDBContextBindingSource2.DataSource = typeof(DAL.DataContext.InventoryDBContext);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DAL.Models.Product);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1332, 606);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.modifyProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.modifyPart);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.searchBoxProducts);
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.productTitle);
            this.Controls.Add(this.dataProductGrid);
            this.Controls.Add(this.searchBoxParts);
            this.Controls.Add(this.searchParts);
            this.Controls.Add(this.partsTitle);
            this.Controls.Add(this.dataPartsGrid);
            this.Controls.Add(this.mainTitle);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.Click += new System.EventHandler(this.MainScreen_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBContextBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBContextBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mainTitle;
        private DataGridView dataPartsGrid;
        private Label partsTitle;
        private Button searchParts;
        private TextBox searchBoxParts;
        private DataGridView dataProductGrid;
        private Label productTitle;
        private TextBox searchBoxProducts;
        private Button searchProduct;
        private Button addPart;
        private Button modifyPart;
        private Button deletePart;
        private Button deleteProduct;
        private Button modifyProduct;
        private Button addProduct;
        private Button exitBtn;
        private BindingSource inventoryDBContextBindingSource;
        private BindingSource inventoryDBContextBindingSource1;
        private BindingSource inventoryDBContextBindingSource2;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private BindingSource productPartBindingSource;
        private DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        private BindingSource productBindingSource1;
    }
}