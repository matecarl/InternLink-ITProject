using System.ComponentModel.DataAnnotations.Schema;
using InternLink.Data;

namespace InternLink.Models;

public class Swipe
{
    public int Id { get; set; }

    public bool IsAccepted { get; set; } // true = Accept, false = Reject
    
    public bool IsInactive { get; set; } // Hide inactive swipes, a swipe turns inactive when it has been accepted or rejected by the company
    
    public DateTime SwipedAt { get; set; }

    [ForeignKey(nameof(Internship))]
    public int InternshipId { get; set; }
    public Internship? Internship { get; set; }
    
    [ForeignKey(nameof(User))]
    public string UserId { get; set; }
    public ApplicationUser? User { get; set; }
    
    public int StudentProfileId { get; set; }
    public StudentProfile? StudentProfile { get; set; }
    
}