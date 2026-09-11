using FourthGroup_1.Models;
using Microsoft.EntityFrameworkCore;

namespace FourthGroup_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
   
 
