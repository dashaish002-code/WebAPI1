using Microsoft.EntityFrameworkCore;
using WebAPI1.Models;

namespace WebAPI1.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
