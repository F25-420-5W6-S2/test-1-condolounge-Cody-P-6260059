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
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Building>()
                .HasMany(c => c.Condos)
                .WithOne(b => b.Building)
                .HasForeignKey(b => b.CondoNumber);


            modelBuilder.Entity<Condo>()
                .HasMany(c => c.Users)
                .WithMany(u => u.Condos);

        }
    }
}
