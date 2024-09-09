using Microsoft.EntityFrameworkCore;

namespace myBackend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

         public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Puedes eliminar esta línea si estás configurando el DbContext en `Program.cs`
            optionsBuilder.UseSqlite("Data Source=myDatabase.db");
        }
    }
}
