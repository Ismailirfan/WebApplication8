
using Microsoft.EntityFrameworkCore;
using WebApplication8.Models;
namespace WebApplication8.Models
{
    public class DbemployeeContext:DbContext
    {
        public DbemployeeContext(DbContextOptions<DbemployeeContext> x) : base(x) { }
        public DbSet<employee> employees { get; set; }
        public DbSet<Salary> Salary { get; set; }
        public DbSet<Department> Department { get; set; }

    }
}
