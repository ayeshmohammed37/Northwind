using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.DAL.Entities
{
    [Table("Products")]
    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [ForeignKey("Supplier")]
        public int? SupplierID { get; set; }
        [ForeignKey("Category")]
        public int? CategoryID { get; set; }
        public string? QuantityPerUnit { get; set; }
        public double? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        // Navigation Properies
        public virtual Supplier Supplier { get; set; }
        public virtual Category Category { get; set; }
    }
}
