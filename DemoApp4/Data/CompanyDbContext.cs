using Microsoft.EntityFrameworkCore;

namespace DemoApp4.Data
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=localhost;Database=cdac;User=root;Password=root;";
                var serverVersion = new MySqlServerVersion(new Version(8, 0, 30)); 

                optionsBuilder.UseMySql(connectionString, serverVersion);
            }
        }
    }
}
