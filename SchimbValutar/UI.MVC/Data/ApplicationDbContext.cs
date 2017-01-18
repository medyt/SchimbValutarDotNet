using Domain_Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UI.MVC.Models;

namespace UI.MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Casier> Casier { get; set; }

        public DbSet<Card> Card { get; set; }

        public DbSet<Client> Client { get; set; }

        public DbSet<Curs> Curs { get; set; }

        public DbSet<Operatie> Operatie { get; set; }

        public DbSet<Tara> Tara { get; set; }

        public DbSet<Valuta> Valuta { get; set; }

        public DbSet<Tranzactie> Tranzactii { get; set; }

        public DbSet<CursValutar> CursValutar { get; set; }
    }
}
