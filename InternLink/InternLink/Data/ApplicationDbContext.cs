using InternLink.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InternLink.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
     public DbSet<Internship> Internships { get; set; } = default!;
     public DbSet<StudentProfile> StudentProfiles { get; set; } = default;
     public DbSet<CompanyProfile> CompanyProfiles { get; set; } = default;
}