namespace ClientApp.AddPart
{
    partial class AddPart
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
            this.radioOutsourced = new System.Windows.Forms.RadioButton();
            this.radioInHouse = new System.Windows.Forms.RadioButton();
            this.addPartTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBoxMachineID = new System.Windows.Forms.TextBox();
            this.labelMachineID = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // radioOutsourced
            // 
            this.radioOutsourced.AutoSize = true;
            this.radioOutsourced.Location = new System.Drawing.Point(389, 15);
            this.radioOutsourced.Name = "radioOutsourced";
            this.radioOutsourced.Size = new System.Drawing.Size(87, 19);
            this.radioOutsourced.TabIndex = 5;
            this.radioOutsourced.TabStop = true;
            this.radioOutsourced.Text = "Outsourced";
            this.radioOutsourced.UseVisualStyleBackColor = true;
            this.radioOutsourced.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioInHouse
            // 
            this.radioInHouse.AutoSize = true;
            this.radioInHouse.Location = new System.Drawing.Point(278, 15);
            this.radioInHouse.Name = "radioInHouse";
            this.radioInHouse.Size = new System.Drawing.Size(74, 19);
            this.radioInHouse.TabIndex = 4;
            this.radioInHouse.TabStop = true;
            this.radioInHouse.Text = "In-House";
            this.radioInHouse.UseVisualStyleBackColor = true;
            this.radioInHouse.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // addPartTitle
            // 
            this.addPartTitle.AutoSize = true;
            this.addPartTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPartTitle.Location = new System.Drawing.Point(12, 9);
            this.addPartTitle.Name = "addPartTitle";
            this.addPartTitle.Size = new System.Drawing.Size(84, 25);
            this.addPartTitle.TabIndex = 3;
            this.addPartTitle.Text = "Add Part";
            this.addPartTitle.Click += new System.EventHandler(this.addPartTitle_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(413, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 33);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(352, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 33);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // textBoxMachineID
            // 
            this.textBoxMachineID.Location = new System.Drawing.Point(167, 231);
            this.textBoxMachineID.Name = "textBoxMachineID";
            this.textBoxMachineID.Size = new System.Drawing.Size(100, 23);
            this.textBoxMachineID.TabIndex = 32;
            // 
            // labelMachineID
            // 
            this.labelMachineID.AutoSize = true;
            this.labelMachineID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMachineID.Location = new System.Drawing.Point(55, 231);
            this.labelMachineID.Name = "labelMachineID";
            this.labelMachineID.Size = new System.Drawing.Size(88, 21);
            this.labelMachineID.TabIndex = 31;
            this.labelMachineID.Text = "Machine ID";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(365, 192);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 23);
            this.textBoxMin.TabIndex = 30;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(167, 192);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 23);
            this.textBoxMax.TabIndex = 29;
            // 
            // textBoxPriceCost
            // 
            this.textBoxPriceCost.Location = new System.Drawing.Point(167, 159);
            this.textBoxPriceCost.Name = "textBoxPriceCost";
            this.textBoxPriceCost.Size = new System.Drawing.Size(174, 23);
            this.textBoxPriceCost.TabIndex = 28;
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.Location = new System.Drawing.Point(167, 126);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(174, 23);
            this.textBoxInventory.TabIndex = 27;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(167, 93);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(174, 23);
            this.textBoxName.TabIndex = 26;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(167, 60);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 25;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMin.Location = new System.Drawing.Point(304, 190);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(37, 21);
            this.labelMin.TabIndex = 24;
            this.labelMin.Text = "Min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMax.Location = new System.Drawing.Point(104, 190);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(39, 21);
            this.labelMax.TabIndex = 23;
            this.labelMax.Text = "Max";
            // 
            // labelPriceCost
            // 
            this.labelPriceCost.AutoSize = true;
            this.labelPriceCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceCost.Location = new System.Drawing.Point(62, 159);
            this.labelPriceCost.Name = "labelPriceCost";
            this.labelPriceCost.Size = new System.Drawing.Size(81, 21);
            this.labelPriceCost.TabIndex = 22;
            this.labelPriceCost.Text = "Price/Cost";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInventory.Location = new System.Drawing.Point(67, 124);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(76, 21);
            this.labelInventory.TabIndex = 21;
            this.labelInventory.Text = "Inventory";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(91, 91);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 21);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Name";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelId.Location = new System.Drawing.Point(118, 58);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(25, 21);
            this.labelId.TabIndex = 19;
            this.labelId.Text = "ID";
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 364);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxMachineID);
            this.Controls.Add(this.labelMachineID);
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
            this.Controls.Add(this.radioOutsourced);
            this.Controls.Add(this.radioInHouse);
            this.Controls.Add(this.addPartTitle);
            this.Name = "AddPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioOutsourced;
        private RadioButton radioInHouse;
        private Label addPartTitle;
        private Button btnCancel;
        private Button btnSave;
        private TextBox textBoxMachineID;
        private Label labelMachineID;
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
    }
}