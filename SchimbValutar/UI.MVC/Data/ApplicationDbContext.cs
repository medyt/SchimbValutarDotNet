using Domain_Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UI.MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Casier> Casier { get; set; }

        public DbSet<Card> Card { get; set; }

        public DbSet<Client> Client { get; set; }

        public DbSet<Curs> Curs { get; set; }

        public DbSet<Operatie> Operatie { get; set; }

        public DbSet<Tara> Tara { get; set; }

        public DbSet<Valuta> Valuta { get; set; }
    }
}
