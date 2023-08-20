using asp_dotnet_core_healthyfood_app.Models;

namespace asp_dotnet_core_healthyfood_app.Services
{
    public interface ICategoryTypeService
    {
        Task<List<CategoryTypeModel>> GetAllAsync();
    }
}
