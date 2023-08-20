using asp_dotnet_core_healthyfood_app.Models;
using asp_dotnet_core_healthyfood_app.Services;
using Microsoft.AspNetCore.Mvc;

namespace asp_dotnet_core_healthyfood_app.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ICategoryTypeService _categoryTypeService;

        public CategoryController(ICategoryService categoryService, ICategoryTypeService categoryTypeService)
        {
            _categoryService = categoryService;
            _categoryTypeService = categoryTypeService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();
            ViewBag.CategoryTypes = await _categoryTypeService.GetAllAsync();
            return View(categories);
        }

        [HttpGet]
        public async Task<JsonResult> GetCategoriesAsync()
        {
            var categories = await _categoryService.GetAllAsync();
            Console.WriteLine(categories);
            return Json(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryModel model)
        {
            try
            {
                await _categoryService.CreateAsync(model);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
