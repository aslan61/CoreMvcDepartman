using CoreMvcDepartman.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreMvcDepartman.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("server=DESKTOP-T8JNUES\\SQLEXPRESS;database=CoreMvcPersonel; integrated security=true;TrustServerCertificate=true;");
        }
        public DbSet<Birim> Birims { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
