using System.ComponentModel.DataAnnotations;
namespace webapp_razor.Models
{
    public class Category
    {
        [KeyAttribute]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}