using InternLink.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InternLink.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
     public DbSet<Internship> Internships { get; set; } = default!;
     public DbSet<StudentProfile> StudentProfiles { get; set; } = default;
     public DbSet<CompanyProfile> CompanyProfiles { get; set; } = default;
     public DbSet<Swipe> Swipes { get; set; } = default!;
     
     protected override void OnModelCreating(ModelBuilder modelBuilder)
     {
          base.OnModelCreating(modelBuilder);
     
          modelBuilder
               .Entity<Swipe>()
               .HasOne<ApplicationUser>(x => x.User)
               .WithMany()
               .OnDelete(DeleteBehavior.Restrict);
     
          modelBuilder
               .Entity<Swipe>()
               .HasOne<Internship>(x => x.Internship)
               .WithMany()
               .OnDelete(DeleteBehavior.Cascade);
          
          modelBuilder
               .Entity<Internship>()
               .HasOne<CompanyProfile>(x => x.CompanyProfile)
               .WithMany()
               .OnDelete(DeleteBehavior.Restrict);
     
     }
}