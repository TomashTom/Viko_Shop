using System.Net.Http.Json;
using Viko_Shop.Shared;

namespace Viko_Shop.Client.Service.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action Onchange;

        public List<Product> Products { get ; set; } = new List<Product>();

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadProducts(string categoryUrl = null)
        {
            if(categoryUrl == null)
            {
                Products = await _http.GetFromJsonAsync<List<Product>>("api/Product");
                
            }
            else
            {
                Products = await _http.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
            }
            
            Onchange.Invoke();
        }

        public async Task <Product> GetProduct(int id)
        {
            return await _http.GetFromJsonAsync<Product>($"api/Product/{id}");
        }

       
    }
}
