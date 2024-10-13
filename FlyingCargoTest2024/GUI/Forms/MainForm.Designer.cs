namespace GUI
{
    partial class MainForm
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

        private DataGridView dataGridViewProducts;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn StockQuantity;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Update;
        private Label label1;

        private void InitializeComponent()
        {
            dataGridViewProducts = new DataGridView();
            label1 = new Label();
            CreateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(66, 94);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.RowTemplate.Height = 29;
            dataGridViewProducts.Size = new Size(1054, 441);
            dataGridViewProducts.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(66, 35);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 0;
            label1.Text = "Products Table View";
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(984, 35);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(136, 29);
            CreateButton.TabIndex = 2;
            CreateButton.Text = "Create Product";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 628);
            Controls.Add(CreateButton);
            Controls.Add(label1);
            Controls.Add(dataGridViewProducts);
            Name = "MainForm";
            Text = "FlyingCargo";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
        }

        private void AddDataGridViewColumns()
        {
            dataGridViewProducts.Columns.Add("ProductId", "Id");
            dataGridViewProducts.Columns.Add("ProductName", "Product Name");
            dataGridViewProducts.Columns.Add("Price", "Price");
            dataGridViewProducts.Columns.Add("Description", "Description");
            dataGridViewProducts.Columns.Add("StockQuantity", "Stock Quantity");
            dataGridViewProducts.Columns.Add("CreatedAt", "Creation Date");

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Name = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true; // Show button text
            dataGridViewProducts.Columns.Add(deleteColumn);

            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.HeaderText = "Update";
            updateColumn.Name = "Update";
            updateColumn.Text = "Update";
            updateColumn.UseColumnTextForButtonValue = true; // Show button text
            dataGridViewProducts.Columns.Add(updateColumn);
        }

        private Button CreateButton;
    }
}
