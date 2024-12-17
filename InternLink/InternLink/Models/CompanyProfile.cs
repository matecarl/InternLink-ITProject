using System.ComponentModel.DataAnnotations.Schema;
using InternLink.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace InternLink.Models;

public class CompanyProfile
{
    public int Id { get; set; }
    [Required]
    [ForeignKey(nameof(User))]
    public string UserId { get; set; }
    public ApplicationUser? User { get; set; }
    [Required]
    public string CompanyName { get; set; }
    [Required]
    public string Industry { get; set; }
    public string WebsiteUrl { get; set; }

}