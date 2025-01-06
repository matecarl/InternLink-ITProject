using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using InternLink.Data;
using InternLink.Enums;

namespace InternLink.Models;

public class Internship
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Provide a title")]
    [StringLength(100, ErrorMessage = "The title cannot exceed 100 characters.")] 
    public string Title { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "Provide a description")]
    [StringLength(2000, ErrorMessage = "The description cannot exceed 2000 characters.")]
    public string Description { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "Provide a location")]
    [StringLength(100, ErrorMessage = "The location cannot exceed 100 characters")]
    public string Location { get; set; } = String.Empty;
    
    [EnumDataType(typeof(RemoteLevel),ErrorMessage = "Provide a remote level")]
    public RemoteLevel RemoteLevel { get; set; }
    
    [Required(ErrorMessage = "Provide a minimum duration")]
    [Range(1, 12, ErrorMessage = "Duration must be between 1 and 12 months.")]
    public int MinDuration { get; set; } = 0;
    
    public DateTime PostedAt { get; set; } = DateTime.Now;
    
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    [ForeignKey(nameof(User))]
    public string UserId { get; set; }
    public ApplicationUser? User { get; set; }
    
    [ForeignKey(nameof(CompanyProfile))]
    public int CompanyId { get; set; }
    public CompanyProfile? CompanyProfile { get; set; }
    
    public ICollection<Swipe> Swipes { get; set; }

}