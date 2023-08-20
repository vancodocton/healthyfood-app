using asp_dotnet_core_healthyfood_app.Data;
using asp_dotnet_core_healthyfood_app.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace asp_dotnet_core_healthyfood_app.Services
{
    public class CategoryTypeService : ICategoryTypeService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CategoryTypeService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<CategoryTypeModel>> GetAllAsync()
        {
            var categoryTypes = await _context.CategoryTypes!.ToListAsync();

            return _mapper.Map<List<CategoryTypeModel>>(categoryTypes);
        }
    }
}
