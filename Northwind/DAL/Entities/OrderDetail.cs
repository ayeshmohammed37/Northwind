using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.DAL.Entities
{
    [Table("Order Details")]
    [PrimaryKey(nameof(OrderID), nameof(ProductID))]
    public class OrderDetail
    {
        [ForeignKey("Order")]
        public int OrderID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        [Column(TypeName ="real")]
        public float Discount { get; set; }

        // Navigation Properties
        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
