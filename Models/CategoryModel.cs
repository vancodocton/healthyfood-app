using System.ComponentModel.DataAnnotations;

namespace asp_dotnet_core_healthyfood_app.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public CategoryTypeModel? CategoryType { get; set; }
    }
}
