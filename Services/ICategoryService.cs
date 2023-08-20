using asp_dotnet_core_healthyfood_app.Models;

namespace asp_dotnet_core_healthyfood_app.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryModel>> GetAllAsync();
        Task<CategoryModel> GetByIdAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task CreateAsync(CategoryModel category);
        Task UpdateAsync(CategoryModel category);
        Task DeleteAsync(int id);
    }
}
