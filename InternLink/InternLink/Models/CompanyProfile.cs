using InternLink.Data;
using Microsoft.AspNetCore.Identity;

namespace InternLink.Models;

public class CompanyProfile
{
    public int Id { get; set; }
    
    public string IdentityUserId { get; set; } // Foreign Key to IdentityUser
    public ApplicationUser User { get; set; }

    public string CompanyName { get; set; }
    public string Industry { get; set; }
    public string WebsiteUrl { get; set; }
}