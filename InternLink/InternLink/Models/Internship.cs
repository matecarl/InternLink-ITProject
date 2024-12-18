using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using InternLink.Data;

namespace InternLink.Models;

public class Internship
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Specify a title")]
    [StringLength(100, ErrorMessage = "The title cannot exceed 100 characters.")]
    public string Title { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "Specify a description")]
    [StringLength(2000, ErrorMessage = "The description cannot exceed 2000 characters.")]
    public string Description { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "Specify a location")]
    [StringLength(100, ErrorMessage = "The location cannot exceed 100 characters")]
    public string Location { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "Specify a remote level")]
    public RemoteLevel RemoteLevel { get; set; }
    
    [Required(ErrorMessage = "Specify a minimum duration")]
    [Range(1, 12, ErrorMessage = "Duration must be between 1 and 12 months.")]
    public int MinDuration { get; set; } = 0;
    
    public DateTime PostedAt { get; set; } = DateTime.Now;
    
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    [Required]
    [ForeignKey(nameof(User))]
    public string? UserId { get; set; }
    public ApplicationUser? User { get; set; }

}