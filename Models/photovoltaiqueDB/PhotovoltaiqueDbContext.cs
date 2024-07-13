using Microsoft.EntityFrameworkCore;
using webdev_consultationPhotovoltaique.Models.photovoltaiqueDB;

namespace webdev_consultationPhotovoltaique.Models.photovoltaiqueDB
{
    public class PhotovoltaiqueDbContext : DbContext
    {
        public PhotovoltaiqueDbContext(DbContextOptions<PhotovoltaiqueDbContext> options)
            : base(options)
        {

        }
        public DbSet<Entreprise> Entreprises { get; set; } = null!;
        public DbSet<produit> produits { get; set; } = null!;
       
        public DbSet<Service> Services { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Admin> Admin { get; set; } = default!;
    }
}
