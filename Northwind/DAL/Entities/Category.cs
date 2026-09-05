using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.DAL.Entities
{
    [Table("Categories")]
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        [Required, MaxLength(15)]
        public string CategoryName { get; set; }
        [Column(TypeName ="ntext")]
        public string? Description { get; set; }
        [Column(TypeName ="image")]
        public byte[]? Picture { get; set; }

        // Navigation Properties
        public virtual ICollection<Product> Products { get; set; }
    }
}
