using System.ComponentModel.DataAnnotations.Schema;
using InternLink.Data;

namespace InternLink.Models;

public class Swipe
{
    public int Id { get; set; }

    public bool Accepted { get; set; }
    
    [ForeignKey(nameof(Internship))]
    public int InternshipId { get; set; }
    public Internship? Internship { get; set; }
    
    public DateTime SwipedAt { get; set; }
    
    [ForeignKey(nameof(User))]
    public string UserId { get; set; }
    public ApplicationUser? User { get; set; }
    
}