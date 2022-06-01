using Viko_Shop.Shared;

namespace Viko_Shop.Client.Service.ProductService
{
    public interface IProductService
    {
        event Action Onchange;
        List<Product> Products { get; set; }
        Task LoadProducts(string categoryUrl = null);
        Task <Product> GetProduct(int id);

    }
}
