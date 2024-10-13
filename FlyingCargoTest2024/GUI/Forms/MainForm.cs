using GUI.DTOs;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace GUI
{
    public partial class MainForm : Form
    {
        private readonly HttpClient _httpClient;
        private string apiUrl = "https://localhost:44342/api/Product";
        public MainForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            InitializeProductColumns();
            await LoadProductsAsync();
        }

        private void InitializeProductColumns()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.AllowUserToAddRows = false; //onemogucavanje prikaza praznog reda
            dataGridViewProducts.Columns.Clear();

            var productIdColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductId",
                HeaderText = "Id",
                Name = "ProductId"
            };
            dataGridViewProducts.Columns.Add(productIdColumn);

            var productNameColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Product Name",
                Name = "ProductName"
            };
            dataGridViewProducts.Columns.Add(productNameColumn);

            var priceColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price",
                Name = "Price"
            };
            dataGridViewProducts.Columns.Add(priceColumn);

            var descriptionColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description",
                Name = "Description"
            };
            dataGridViewProducts.Columns.Add(descriptionColumn);

            var stockQuantityColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StockQuantity",
                HeaderText = "Stock Quantity",
                Name = "StockQuantity"
            };
            dataGridViewProducts.Columns.Add(stockQuantityColumn);

            var createdAtColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                HeaderText = "Creation Date",
                Name = "CreatedAt"
            };
            dataGridViewProducts.Columns.Add(createdAtColumn);

            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Name = "Delete"
            };
            dataGridViewProducts.Columns.Add(deleteButtonColumn);

            var updateButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Update",
                Text = "Update",
                UseColumnTextForButtonValue = true,
                Name = "Update"
            };

            dataGridViewProducts.Columns.Add(updateButtonColumn);

            dataGridViewProducts.Columns["ProductId"].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewProducts.Columns["ProductName"].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewProducts.Columns["Price"].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewProducts.Columns["Description"].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewProducts.Columns["StockQuantity"].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewProducts.Columns["CreatedAt"].SortMode = DataGridViewColumnSortMode.Automatic;

            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
            dataGridViewProducts.ColumnHeaderMouseClick += dataGridViewProducts_ColumnHeaderMouseClick;
        }

        private async Task LoadProductsAsync()
        {
            try
            {
                var products = await _httpClient.GetFromJsonAsync<List<ProductDto>>(apiUrl);
                dataGridViewProducts.Rows.Clear();

                foreach (var product in products)
                {
                    dataGridViewProducts.Rows.Add(product.ProductId, product.ProductName, product.Price, product.Description, product.StockQuantity, product.CreatedAt);
                }
                //dataGridViewProducts.DataSource = products;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }
        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == dataGridViewProducts.Columns["Delete"].Index)
            {
                var productId = (int)dataGridViewProducts.Rows[e.RowIndex].Cells["ProductId"].Value;
                DeleteProduct(productId);
            }
            else if (e.ColumnIndex == dataGridViewProducts.Columns["Update"].Index)
            {
                var productId = (int)dataGridViewProducts.Rows[e.RowIndex].Cells["ProductId"].Value;
                UpdateProduct(productId);
            }
        }
        private async void DeleteProduct(int productId)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{apiUrl}/{productId}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Product deleted successfully.");
                    await LoadProductsAsync();  // Refresh the list
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}");
            }
        }

        private async void UpdateProduct(int productId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{apiUrl}/{productId}");
                if (response.IsSuccessStatusCode)
                {
                    var productJson = await response.Content.ReadAsStringAsync();
                    var product = JsonConvert.DeserializeObject<ProductDto>(productJson);
                    var updateProductForm = new UpdateProductForm(product);
                    updateProductForm.ProductUpdated += UpdateProductForm_ProductUpdated;
                    updateProductForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error retrieving product data: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
           
        private void CreateButton_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            addProductForm.ProductAdded += AddProductForm_ProductAdded;
            addProductForm.ShowDialog();
        }
        private async void AddProductForm_ProductAdded(object sender, EventArgs e)
        {
            // Osvježavanje glavne tabele
            LoadProductsAsync();
        }
        private async void UpdateProductForm_ProductUpdated(object sender, EventArgs e)
        {
            // Osvježavanje glavne tabele
            LoadProductsAsync();
        }

        private void dataGridViewProducts_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataGridViewProducts.Columns[e.ColumnIndex].Name;
        }
    }
}
