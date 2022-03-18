using ERPService.Models;
using Microsoft.EntityFrameworkCore;

namespace ERPService.Data
{
    public class DbContextERPService:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost,1433; Database=ERP; User ID=sa; Password=1q2w3e4r@#$; Trusted_Connection=False; TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }

    }
}
