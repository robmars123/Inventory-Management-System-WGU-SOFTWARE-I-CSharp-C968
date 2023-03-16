namespace ClientApp.Products.AddProduct
{
    partial class AddProduct
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
            if (disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.searchBoxParts = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.partsTitle = new System.Windows.Forms.Label();
            this.productPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddPart = new System.Windows.Forms.Button();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxPriceCost = new System.Windows.Forms.TextBox();
            this.textBoxInventory = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelPriceCost = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelPartsAssociated = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataPartsCandidate = new System.Windows.Forms.DataGridView();
            this.productPartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataPartsAssociated = new System.Windows.Forms.DataGridView();
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productPartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPartsCandidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPartsAssociated)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddProduct.Location = new System.Drawing.Point(12, 14);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(117, 25);
            this.labelAddProduct.TabIndex = 0;
            this.labelAddProduct.Text = "Add Product";
            // 
            // searchBoxParts
            // 
            this.searchBoxParts.Location = new System.Drawing.Point(864, 26);
            this.searchBoxParts.Name = "searchBoxParts";
            this.searchBoxParts.Size = new System.Drawing.Size(154, 23);
            this.searchBoxParts.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(805, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // partsTitle
            // 
            this.partsTitle.AutoSize = true;
            this.partsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partsTitle.Location = new System.Drawing.Point(408, 51);
            this.partsTitle.Name = "partsTitle";
            this.partsTitle.Size = new System.Drawing.Size(171, 25);
            this.partsTitle.TabIndex = 6;
            this.partsTitle.Text = "All Candidate Parts";
            // 
            // productPartBindingSource
            // 
            this.productPartBindingSource.DataSource = typeof(DAL.Models.ProductPart);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(962, 301);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(56, 33);
            this.btnAddPart.TabIndex = 9;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(327, 311);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(75, 23);
            this.textBoxMin.TabIndex = 44;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(158, 309);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(70, 23);
            this.textBoxMax.TabIndex = 43;
            // 
            // textBoxPriceCost
            // 
            this.textBoxPriceCost.Location = new System.Drawing.Point(158, 276);
            this.textBoxPriceCost.Name = "textBoxPriceCost";
            this.textBoxPriceCost.Size = new System.Drawing.Size(127, 23);
            this.textBoxPriceCost.TabIndex = 42;
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.Location = new System.Drawing.Point(158, 243);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(127, 23);
            this.textBoxInventory.TabIndex = 41;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(158, 210);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(127, 23);
            this.textBoxName.TabIndex = 40;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(158, 177);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 39;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMin.Location = new System.Drawing.Point(273, 311);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(37, 21);
            this.labelMin.TabIndex = 38;
            this.labelMin.Text = "Min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMax.Location = new System.Drawing.Point(95, 307);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(39, 21);
            this.labelMax.TabIndex = 37;
            this.labelMax.Text = "Max";
            // 
            // labelPriceCost
            // 
            this.labelPriceCost.AutoSize = true;
            this.labelPriceCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceCost.Location = new System.Drawing.Point(85, 276);
            this.labelPriceCost.Name = "labelPriceCost";
            this.labelPriceCost.Size = new System.Drawing.Size(44, 21);
            this.labelPriceCost.TabIndex = 36;
            this.labelPriceCost.Text = "Price";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInventory.Location = new System.Drawing.Point(58, 241);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(76, 21);
            this.labelInventory.TabIndex = 35;
            this.labelInventory.Text = "Inventory";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(82, 208);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 21);
            this.labelName.TabIndex = 34;
            this.labelName.Text = "Name";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelId.Location = new System.Drawing.Point(109, 175);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(25, 21);
            this.labelId.TabIndex = 33;
            this.labelId.Text = "ID";
            // 
            // labelPartsAssociated
            // 
            this.labelPartsAssociated.AutoSize = true;
            this.labelPartsAssociated.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPartsAssociated.Location = new System.Drawing.Point(408, 348);
            this.labelPartsAssociated.Name = "labelPartsAssociated";
            this.labelPartsAssociated.Size = new System.Drawing.Size(295, 25);
            this.labelPartsAssociated.TabIndex = 46;
            this.labelPartsAssociated.Text = "Parts Associated with this Product";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(962, 603);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 33);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(962, 651);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 33);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(884, 651);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 33);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataPartsCandidate
            // 
            this.dataPartsCandidate.AutoGenerateColumns = false;
            this.dataPartsCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPartsCandidate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn});
            this.dataPartsCandidate.DataSource = this.productPartBindingSource;
            this.dataPartsCandidate.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataPartsCandidate.Location = new System.Drawing.Point(415, 79);
            this.dataPartsCandidate.Name = "dataPartsCandidate";
            this.dataPartsCandidate.RowHeadersVisible = false;
            this.dataPartsCandidate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataPartsCandidate.RowTemplate.Height = 25;
            this.dataPartsCandidate.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPartsCandidate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPartsCandidate.Size = new System.Drawing.Size(603, 197);
            this.dataPartsCandidate.TabIndex = 50;
            // 
            // productPartBindingSource1
            // 
            this.productPartBindingSource1.DataSource = typeof(DAL.Models.ProductPart);
            // 
            // dataPartsAssociated
            // 
            this.dataPartsAssociated.AutoGenerateColumns = false;
            this.dataPartsAssociated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPartsAssociated.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataPartsAssociated.DataSource = this.productPartBindingSource1;
            this.dataPartsAssociated.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataPartsAssociated.Location = new System.Drawing.Point(415, 376);
            this.dataPartsAssociated.Name = "dataPartsAssociated";
            this.dataPartsAssociated.RowHeadersVisible = false;
            this.dataPartsAssociated.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataPartsAssociated.RowTemplate.Height = 25;
            this.dataPartsAssociated.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPartsAssociated.Size = new System.Drawing.Size(603, 197);
            this.dataPartsAssociated.TabIndex = 51;
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
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PartID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PartID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "InStock";
            this.dataGridViewTextBoxColumn4.HeaderText = "InStock";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Min";
            this.dataGridViewTextBoxColumn5.HeaderText = "Min";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Max";
            this.dataGridViewTextBoxColumn6.HeaderText = "Max";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 711);
            this.Controls.Add(this.dataPartsAssociated);
            this.Controls.Add(this.dataPartsCandidate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelPartsAssociated);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxPriceCost);
            this.Controls.Add(this.textBoxInventory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPriceCost);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.searchBoxParts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.partsTitle);
            this.Controls.Add(this.labelAddProduct);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddProduct_FormClosed);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.Click += new System.EventHandler(this.AddProduct_Click);
            ((System.ComponentModel.ISupportInitialize)(this.productPartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPartsCandidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPartsAssociated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAddProduct;
        private TextBox searchBoxParts;
        private Button btnSearch;
        private Label partsTitle;
        private Button btnAddPart;
        private TextBox textBoxMin;
        private TextBox textBoxMax;
        private TextBox textBoxPriceCost;
        private TextBox textBoxInventory;
        private TextBox textBoxName;
        private TextBox textBoxID;
        private Label labelMin;
        private Label labelMax;
        private Label labelPriceCost;
        private Label labelInventory;
        private Label labelName;
        private Label labelId;
        private Label labelPartsAssociated;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnSave;
        private BindingSource productPartBindingSource;
        private DataGridView dataPartsCandidate;
        private BindingSource productPartBindingSource1;
        private DataGridView dataPartsAssociated;
        private DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}