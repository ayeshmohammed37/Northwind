using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.DAL.Entities
{
    [Table("Shippers")]
    public class Shipper
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShipperID { get; set; }

        [Required, MaxLength(40)]
        public string CompanyName { get; set; }

        [MaxLength(24)]
        public string? Phone { get; set; }

        // Navigation Properties
        public virtual ICollection<Order> Orders { get; set; }
    }
}
