using GUI.DTOs;
using System.Net.Http.Json;

namespace GUI
{
    public partial class UpdateProductForm : Form
    {
        private readonly HttpClient _httpClient;
        public event EventHandler ProductUpdated;
        private string apiUrl = "https://localhost:44342/api/Product";
        private int productId;

        public UpdateProductForm(ProductDto product)
        {
            InitializeComponent();
            if (product != null)
            {
                productId = product.ProductId;
                textBoxProductName.Text = product.ProductName;
                textBoxPrice.Text = product.Price.ToString();
                textBoxDescription.Text = product.Description;
                textBoxStockQuantity.Text = product.StockQuantity.ToString();
            }

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            _httpClient = new HttpClient();
        }

        private async void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out string productName, out decimal price, out string description, out int stockQuantity))
            {
                var productDto = new ProductDto
                {
                    ProductId = productId,
                    ProductName = productName,
                    Price = price,
                    Description = description,
                    StockQuantity = stockQuantity
                };

                var response = await _httpClient.PutAsJsonAsync($"{apiUrl}/{productId}", productDto);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Product updated successfully!");
                    ProductUpdated?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error updating product: " + response.ReasonPhrase);
                }
            }
        }

        private bool ValidateInput(out string productName, out decimal price, out string description, out int stockQuantity)
        {
            productName = textBoxProductName.Text;
            price = decimal.Parse(textBoxPrice.Text);
            description = textBoxDescription.Text;
            stockQuantity = int.Parse(textBoxStockQuantity.Text);
            return true;
        }

    }
}
