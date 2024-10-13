using GUI.DTOs;
using System.Net.Http.Json;

namespace GUI
{
    public partial class AddProductForm : Form
    {
        private readonly HttpClient _httpClient;
        private string apiUrl = "https://localhost:44342/api/Product";
        public event EventHandler ProductAdded;

        public AddProductForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            var newProduct = new ProductDto
            {
                ProductName = textBoxProductName.Text,
                Price = decimal.Parse(textBoxPrice.Text),
                Description = textBoxDescription.Text,
                StockQuantity = int.Parse(textBoxStockQuantity.Text),
                CreatedAt = DateTime.Now
            };

            var response = await _httpClient.PostAsJsonAsync(apiUrl, newProduct);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product added successfully!");
                ProductAdded?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error adding product: " + response.ReasonPhrase);
            }
        }
        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ako nije broj i nije pritisnuta taster 'Backspace', spreči unos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Spreči unos više od jednog decimalnog broja
            }
        }


        private void textBoxStockQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
