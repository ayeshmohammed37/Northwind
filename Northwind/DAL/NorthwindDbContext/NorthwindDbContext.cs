using Microsoft.EntityFrameworkCore;

namespace Northwind.DAL.NorthwindDbContext
{
    public class NorthwindDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False;Trust Server Certificate = True");
        }
    }
}
