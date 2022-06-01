using Viko_Shop.Shared;

namespace Viko_Shop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category> {
                new Category { Id = 1, Name = "Caffes", Url = "caffes" },
                new Category { Id = 2, Name = "Bars", Url = "bars" },
                new Category { Id = 3, Name = "Pubs", Url = "pubs" },
                new Category { Id = 4, Name = "Entertainments", Url = "entertainments" }
                };
        public async Task<List<Category>> GetCategories()
        {
            
            return Categories;
        }

        public async  Task<Category> GetCategoryByUrl(string categoryUrl)
        {
           return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
