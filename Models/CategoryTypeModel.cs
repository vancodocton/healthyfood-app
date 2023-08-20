namespace asp_dotnet_core_healthyfood_app.Models
{
    public class CategoryTypeModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<CategoryModel>? Categories { get; set; }
    }
}
