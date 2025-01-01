using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InternLink.Data;

namespace InternLink.Models;

public class CompanyProfile
{
    public int Id { get; set; }
    [Required]
    [ForeignKey(nameof(User))]
    public string UserId { get; set; }
    public ApplicationUser? User { get; set; }
    public string CompanyName { get; set; }
    
    [Required(ErrorMessage = "Provide a description")]
    public string Description { get; set; }
    public string? Location { get; set; }
    
    [Required(ErrorMessage = "Provide an industry")]
    public string Industry { get; set; }
    public string? WebsiteUrl { get; set; }

}