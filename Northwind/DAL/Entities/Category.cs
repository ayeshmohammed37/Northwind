using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.DAL.Entities
{
    [Table("Categories")]
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }

        // Navigation Properties
        public virtual ICollection<Product> Products { get; set; }
    }
}
