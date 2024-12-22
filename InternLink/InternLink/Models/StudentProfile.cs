using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InternLink.Data;

namespace InternLink.Models;

public class StudentProfile
{
    public int Id { get; set; }
    [Required]
    [ForeignKey(nameof(User))]
    public string UserId { get; set; }
    public string UserName { get; set; }
    public ApplicationUser? User { get; set; }
    public string FirstName { get; set; }
    public string LastName  { get; set; }
    public string Description  { get; set; }
    public string Study { get; set; }
    public string ResumeUrl { get; set; }
    public string ProfilePhotoUrl { get; set; }

}   