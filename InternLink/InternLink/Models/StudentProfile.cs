using System.ComponentModel.DataAnnotations.Schema;
using InternLink.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace InternLink.Models;

public class StudentProfile
{
    public int Id { get; set; }
    [Required]
    [ForeignKey(nameof(User))]
    public string UserId { get; set; }
    public ApplicationUser? User { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName  { get; set; }
    public string Description  { get; set; }
    [Required]
    public string Study { get; set; }
    [Required]
    public string ResumeUrl { get; set; }
    public string ProfilePhotoUrl { get; set; }

}   