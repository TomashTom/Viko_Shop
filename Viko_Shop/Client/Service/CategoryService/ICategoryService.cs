using Viko_Shop.Shared;

namespace Viko_Shop.Client.Service.CategoryService
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }
        Task LoadCategories();

    }
}
