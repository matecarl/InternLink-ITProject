using System.ComponentModel.DataAnnotations;

namespace InternLink.Enums;

public enum RemoteLevel
{
    [Display(Name="On site")]
    OnSite,       // Internship requires physical presence at the company's location.
    
    [Display(Name="Remote")]
    Remote,       // Fully remote; can work from anywhere.
    
    [Display(Name="Hybrid")]
    Hybrid,       // Combination of remote and on-site work.
    
    [Display(Name="Partially Remote")]
    PartiallyRemote, // Mostly remote but requires occasional on-site presence.
    
    [Display(Name="Flexible")]
    Flexible      // Flexible arrangement based on agreement between company and student.
}