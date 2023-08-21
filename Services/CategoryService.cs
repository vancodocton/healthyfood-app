using asp_dotnet_core_healthyfood_app.Data;
using asp_dotnet_core_healthyfood_app.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace asp_dotnet_core_healthyfood_app.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CategoryService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<CategoryModel>> GetAllAsync()
        {
            var categories = await _context.Categories!.ToListAsync();
            return _mapper.Map<List<CategoryModel>>(categories);
        }

        public async Task<CategoryModel> GetByIdAsync(int id)
        {
            var category = await _context.Categories!.FindAsync(id);
            return _mapper.Map<CategoryModel>(category);
        }

        public async Task CreateAsync(CategoryModel category)
        {
            var newCatogory = _mapper.Map<Category>(category);
            newCatogory.CategoryType = null!;

            _context.Categories!.Add(newCatogory);
            await _context.SaveChangesAsync();
            _context?.Dispose();
        }

        public async Task UpdateAsync(CategoryModel category)
        {
            var updateCategory = _mapper.Map<Category>(category);

            _context.Categories!.Update(updateCategory);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deleteCategory = _context.Categories!.Find(id);
            if(deleteCategory != null)
            {
                _context.Categories!.Remove(deleteCategory);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            if (await _context.Categories!.FindAsync(id) != null)
            {
                return true;
            }
            return false;
        }
    }
}
