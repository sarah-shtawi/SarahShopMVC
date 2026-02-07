using Microsoft.EntityFrameworkCore;
using Sarah_Shop.Models;

namespace Sarah_Shop.Data
{
    public class ApplicationDbContext : DbContext
    {

       public DbSet <Category> Categories {  get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //Production
          //  optionsBuilder.UseSqlServer("Server=db39518.public.databaseasp.net; Database=db39518; User Id=db39518; Password=Ah3#_5FxaY-6; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True");
          
            //Development
           optionsBuilder.UseSqlServer("server=.;database=SarahShopMVC;TrustServerCertificate= True;Trusted_Connection=True");
        }
    }
}
