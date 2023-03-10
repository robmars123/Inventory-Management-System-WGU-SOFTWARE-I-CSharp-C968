

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
            this.mainTitle = new System.Windows.Forms.Label();
            this.dataPartsGrid = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsTitle = new System.Windows.Forms.Label();
            this.searchParts = new System.Windows.Forms.Button();
            this.searchBoxParts = new System.Windows.Forms.TextBox();
            this.dataProductGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductGrid)).BeginInit();
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
            this.dataPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPartsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.PartName,
            this.Inventory,
            this.Price,
            this.Min,
            this.Max});
            this.dataPartsGrid.Location = new System.Drawing.Point(27, 123);
            this.dataPartsGrid.Name = "dataPartsGrid";
            this.dataPartsGrid.RowHeadersVisible = false;
            this.dataPartsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataPartsGrid.RowTemplate.Height = 25;
            this.dataPartsGrid.Size = new System.Drawing.Size(603, 292);
            this.dataPartsGrid.TabIndex = 1;
            // 
            // PartID
            // 
            this.PartID.HeaderText = "PartID";
            this.PartID.Name = "PartID";
            // 
            // PartName
            // 
            this.PartName.HeaderText = "Name";
            this.PartName.Name = "PartName";
            // 
            // Inventory
            // 
            this.Inventory.HeaderText = "Inventory";
            this.Inventory.Name = "Inventory";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Min
            // 
            this.Min.HeaderText = "Min";
            this.Min.Name = "Min";
            // 
            // Max
            // 
            this.Max.HeaderText = "Max";
            this.Max.Name = "Max";
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
            this.dataProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataProductGrid.Location = new System.Drawing.Point(702, 123);
            this.dataProductGrid.Name = "dataProductGrid";
            this.dataProductGrid.RowHeadersVisible = false;
            this.dataProductGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataProductGrid.RowTemplate.Height = 25;
            this.dataProductGrid.Size = new System.Drawing.Size(603, 292);
            this.dataProductGrid.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "PartID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Min";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Max";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // 
            // modifyPart
            // 
            this.modifyPart.Location = new System.Drawing.Point(505, 454);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(54, 34);
            this.modifyPart.TabIndex = 10;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(574, 454);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(56, 34);
            this.deletePart.TabIndex = 11;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
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
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(1110, 454);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(54, 34);
            this.addProduct.TabIndex = 12;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1249, 539);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(56, 33);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dataPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductGrid)).EndInit();
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label productTitle;
        private TextBox searchBoxProducts;
        private Button searchProduct;
        private Button addPart;
        private Button modifyPart;
        private Button deletePart;
        private Button deleteProduct;
        private Button modifyProduct;
        private Button addProduct;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn PartName;
        private DataGridViewTextBoxColumn Inventory;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Min;
        private DataGridViewTextBoxColumn Max;
        private Button exitBtn;
    }
}