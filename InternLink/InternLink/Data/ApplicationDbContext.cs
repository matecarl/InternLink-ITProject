using InternLink.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InternLink.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
     public DbSet<Internship> Internships { get; set; } = default!;
     public DbSet<StudentProfile> StudentProfiles { get; set; } = default!;
     public DbSet<CompanyProfile> CompanyProfiles { get; set; } = default!;
     public DbSet<Swipe> Swipes { get; set; } = default!;
     
     public DbSet<Match> Matches { get; set; } = default!;

     
     protected override void OnModelCreating(ModelBuilder modelBuilder)
     {
          base.OnModelCreating(modelBuilder);
          
          modelBuilder.Entity<Internship>()
               .HasMany(x => x.Swipes)
               .WithOne(x => x.Internship)
               .OnDelete(DeleteBehavior.Restrict);  // (first) Internship < Swipes
          
          // Swipe -> link to swiped user
          modelBuilder.Entity<Swipe>()
               .HasOne(x => x.User)
               .WithMany()
               .OnDelete(DeleteBehavior.Restrict);
          
          // Swipe -> link to attached Internship
          // modelBuilder.Entity<Swipe>()
          //      .HasOne(x => x.Internship)
          //      .WithMany(x => x.Swipes)
          //      .OnDelete(DeleteBehavior.Cascade);
          
          // Internship -> link to poster company profile
          modelBuilder.Entity<Internship>()
               .HasOne(x => x.CompanyProfile)
               .WithMany()
               .OnDelete(DeleteBehavior.Restrict);
          
     }
}