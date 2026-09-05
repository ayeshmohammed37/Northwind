using Microsoft.EntityFrameworkCore;
using Northwind.DAL.Entities;

namespace Northwind.DAL.NorthwindDbContext
{
    public class NorthwindDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False;Trust Server Certificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().Property(o => o.OrderID).UseIdentityColumn(seed: 10248, increment: 1);
        }
    }
}
