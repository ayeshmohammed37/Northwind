using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.DAL.Entities
{
    [Table("Products")]
    public class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        
        [Required, MaxLength(40)]
        public string ProductName { get; set; }
        
        [ForeignKey("Supplier")]
        public int? SupplierID { get; set; }
        
        [ForeignKey("Category")]
        public int? CategoryID { get; set; }
        
        [MaxLength(20)]
        public string? QuantityPerUnit { get; set; }
        
        [Column(TypeName ="money")]
        public double? UnitPrice { get; set; }
        
        public short? UnitsInStock { get; set; }
        
        public short? UnitsOnOrder { get; set; }
        
        public short? ReorderLevel { get; set; }
        
        public bool Discontinued { get; set; }

        // Navigation Properies
        public virtual Supplier? Supplier { get; set; }

        public virtual Category? Category { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
