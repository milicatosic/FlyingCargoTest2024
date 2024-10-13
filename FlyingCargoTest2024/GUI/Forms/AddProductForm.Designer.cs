
namespace GUI
{
    partial class AddProductForm
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
            textBoxProductName = new TextBox();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            textBoxStockQuantity = new TextBox();
            labelStockQuantity = new Label();
            buttonCreateProduct = new Button();
            SuspendLayout();
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(67, 44);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(104, 20);
            labelProductName.TabIndex = 0;
            labelProductName.Text = "Product Name";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(210, 41);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(125, 27);
            textBoxProductName.TabIndex = 1;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(67, 95);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(41, 20);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(210, 92);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 27);
            textBoxPrice.TabIndex = 3;
            textBoxPrice.KeyPress += textBoxPrice_KeyPress;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(210, 140);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(125, 27);
            textBoxDescription.TabIndex = 5;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(67, 143);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "Description";
            // 
            // textBoxStockQuantity
            // 
            textBoxStockQuantity.Location = new Point(210, 193);
            textBoxStockQuantity.Name = "textBoxStockQuantity";
            textBoxStockQuantity.Size = new Size(125, 27);
            textBoxStockQuantity.TabIndex = 7;
            textBoxStockQuantity.KeyPress += textBoxStockQuantity_KeyPress;
            // 
            // labelStockQuantity
            // 
            labelStockQuantity.AutoSize = true;
            labelStockQuantity.Location = new Point(67, 196);
            labelStockQuantity.Name = "labelStockQuantity";
            labelStockQuantity.Size = new Size(65, 20);
            labelStockQuantity.TabIndex = 6;
            labelStockQuantity.Text = "Quantity";
            labelStockQuantity.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonCreateProduct
            // 
            buttonCreateProduct.Location = new Point(131, 281);
            buttonCreateProduct.Name = "buttonCreateProduct";
            buttonCreateProduct.Size = new Size(94, 29);
            buttonCreateProduct.TabIndex = 8;
            buttonCreateProduct.Text = "Create";
            buttonCreateProduct.UseVisualStyleBackColor = true;
            buttonCreateProduct.Click += buttonCreateProduct_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 339);
            Controls.Add(buttonCreateProduct);
            Controls.Add(textBoxStockQuantity);
            Controls.Add(labelStockQuantity);
            Controls.Add(textBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(textBoxProductName);
            Controls.Add(labelProductName);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProductName;
        private TextBox textBoxProductName;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private TextBox textBoxDescription;
        private Label labelDescription;
        private TextBox textBoxStockQuantity;
        private Label labelStockQuantity;
        private Button buttonCreateProduct;
    }
}