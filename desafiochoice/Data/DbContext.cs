using desafiochoice.Model;
using Microsoft.EntityFrameworkCore;

namespace desafiochoice.Data
{
    public class DesafioDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        
        public DbSet<Job> Jobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseInMemoryDatabase(databaseName: "desafio-nome");
    }
}