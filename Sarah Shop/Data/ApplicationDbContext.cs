using Microsoft.EntityFrameworkCore;

namespace Sarah_Shop.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=. ; database=SarahShopMVC ; TrustServerCertificate= True; Trusted_Connection=True ");
        }
    }
}
