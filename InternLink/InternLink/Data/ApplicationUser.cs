using InternLink.Models;
using Microsoft.AspNetCore.Identity;

namespace InternLink.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public ICollection<Internship> Internships { get; }
}