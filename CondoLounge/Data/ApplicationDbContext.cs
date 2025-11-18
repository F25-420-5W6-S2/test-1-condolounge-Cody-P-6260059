using CondoLounge.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CondoLounge.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Condo> Condo { get; set; }
        public DbSet<Building> Building { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Building>()
                .HasMany(b => b.Condos)
                .WithOne(c => c.Building)
                .HasForeignKey(c => c.CondoNumber);


            modelBuilder.Entity<Condo>()
                .HasMany(c => c.Users)
                .WithMany(u => u.Condos);

        }
    }
}
