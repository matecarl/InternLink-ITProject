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

    [Required(ErrorMessage = "Provide your first name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Provide your last name")]
    public string LastName  { get; set; }

    [Required(ErrorMessage = "Provide a description")]
    public string Description  { get; set; }

    [Required(ErrorMessage = "Provide your Study")]
    public string Study { get; set; }

    public string ResumeUrl { get; set; }
    public string ProfilePhotoUrl { get; set; }

}   