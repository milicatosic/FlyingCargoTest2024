namespace GUI
{
    partial class UpdateProductForm
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
            labelProductName = new Label();
            labelPrice = new Label();
            labelDescription = new Label();
            labelStockQuantity = new Label();
            textBoxProductName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxDescription = new TextBox();
            textBoxStockQuantity = new TextBox();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(37, 34);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(104, 20);
            labelProductName.TabIndex = 0;
            labelProductName.Text = "Product Name";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(37, 87);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(41, 20);
            labelPrice.TabIndex = 1;
            labelPrice.Text = "Price";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(37, 142);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Description";
            // 
            // labelStockQuantity
            // 
            labelStockQuantity.AutoSize = true;
            labelStockQuantity.Location = new Point(37, 191);
            labelStockQuantity.Name = "labelStockQuantity";
            labelStockQuantity.Size = new Size(105, 20);
            labelStockQuantity.TabIndex = 3;
            labelStockQuantity.Text = "Stock Quantity";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(187, 31);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(125, 27);
            textBoxProductName.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(187, 84);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 27);
            textBoxPrice.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(187, 139);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(125, 27);
            textBoxDescription.TabIndex = 6;
            // 
            // textBoxStockQuantity
            // 
            textBoxStockQuantity.Location = new Point(187, 188);
            textBoxStockQuantity.Name = "textBoxStockQuantity";
            textBoxStockQuantity.Size = new Size(125, 27);
            textBoxStockQuantity.TabIndex = 7;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(119, 264);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 8;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdateProduct_Click;
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 340);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxStockQuantity);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxProductName);
            Controls.Add(labelStockQuantity);
            Controls.Add(labelDescription);
            Controls.Add(labelPrice);
            Controls.Add(labelProductName);
            Name = "UpdateProductForm";
            Text = "UpdateProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProductName;
        private Label labelPrice;
        private Label labelDescription;
        private Label labelStockQuantity;
        private TextBox textBoxProductName;
        private TextBox textBoxPrice;
        private TextBox textBoxDescription;
        private TextBox textBoxStockQuantity;
        private Button buttonUpdate;
    }
}