using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.DAL.Entities
{
    [Table("Employees")]
    public class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
            DirectReports = new HashSet<Employee>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        [Required, MaxLength(20)]
        public string LastName { get; set; }
        
        [Required, MaxLength(10)]
        public string FirstName { get; set; }

        [MaxLength(30)]
        public string? Title { get; set; }

        [MaxLength(25)]
        public string? TitleOfCourtesy { get; set; }
        
        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        [MaxLength(60)]
        public string? Address { get; set; }

        [MaxLength(15)]
        public string? City { get; set; }

        [MaxLength(15)]
        public string? Region { get; set; }

        [MaxLength(10)]
        public string? PostalCode { get; set; }

        [MaxLength(15)]
        public string? Country { get; set; }

        [MaxLength(24)]
        public string? HomePhone { get; set; }

        [MaxLength(4)]
        public string? Extension { get; set; }

        [Column(TypeName ="image")]
        public byte[]? Photo { get; set; }

        [Column(TypeName = "ntext")]
        public string? Notes { get; set; }

        [ForeignKey("Manager")]
        public int? ReportsTo { get; set; }

        [MaxLength(225)]
        public string? PhotoPath { get; set; }

        // Navigation Properites
        public virtual Employee? Manager { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Employee> DirectReports { get; set; }

    }
}
