using System.ComponentModel.DataAnnotations.Schema;
using InternLink.Data;

namespace InternLink.Models;

public class Match
{
    public int Id { get; set; }

    [ForeignKey(nameof(Internship))]
    public int? InternshipId { get; set; }
    public Internship? Internship { get; set; }
    
    public string? UserId { get; set; } // Student Id
    
    public ApplicationUser? User { get; set; }
    
    public int StudentProfileId { get; set; }
    public StudentProfile? StudentProfile { get; set; }
    
    public DateTime MatchedAt { get; set; }

}