using Microsoft.AspNetCore.Identity;

namespace InternLink.Models;

// Add profile data for application users by adding properties to the ApplicationUser class
public class StudentProfile
{
    public int id { get; set; }
    public string IdentityUserId { get; set; } // FK to associated identityUser
    public IdentityUser IdentityUser { get; set; }
    
    public string FirstName { get; set; } = string.Empty;
    public string LastName  { get; set; } = string.Empty;
    public string Description  { get; set; } = string.Empty;
    public string Study { get; set; } = string.Empty;
    public string ResumeUrl { get; set; } = string.Empty;
    public string ProfilePhotoUrl { get; set; } = string.Empty;
    
    // TO ADD: Tags
    
}