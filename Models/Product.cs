using System.ComponentModel.DataAnnotations;

namespace azure_db_web_app.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}
