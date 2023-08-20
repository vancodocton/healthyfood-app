using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_dotnet_core_healthyfood_app.Data
{
    [Table("CategoryTypes")]
    public class CategoryType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }
        public List<Category>? Categories { get; set; }
    }
}
