using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_dotnet_core_healthyfood_app.Data
{

    [Table("Categories")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; } = null!;

        [StringLength(100)]
        public string? Description { get; set; }

        public int CategoryTypeId { get; set; }
        public CategoryType CategoryType { get; set; } = null!;
    }
}
