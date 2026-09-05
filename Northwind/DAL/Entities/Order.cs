using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.DAL.Entities
{
    [Table("Orders")]
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public int OrderID { get; set; }

        [Column(TypeName ="nchar(5)"), StringLength(5)]
        [ForeignKey("Customer")]
        public string? CustomerID { get; set; }
        
        [ForeignKey("Employee")]
        public int? EmployeeID { get; set; }
        
        public DateTime? OrderDate { get; set; }
        
        public DateTime? RequiredDate { get; set; }
        
        public DateTime? ShippedDate { get; set; }
        
        [ForeignKey("Shipper")]
        public int? ShipVia { get; set; }
        
        [Column(TypeName ="money")]
        public decimal? Freight { get; set; }
        
        [MaxLength(40)]
        public string? ShipName { get; set; }
        
        [MaxLength(60)]
        public string? ShipAddress { get; set; }
        
        [MaxLength(15)]
        public string? ShipCity { get; set; }
        
        [MaxLength(15)]
        public string? ShipRegion { get; set; }
        
        [MaxLength(10)]
        public string? ShipPostalCode { get; set; }

        [MaxLength(15)]
        public string? ShipCountry { get; set; }

        // Navigation Properties
        public virtual Customer? Customer { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual Shipper? Shipper { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
