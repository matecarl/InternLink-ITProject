using InternLink.Models;

namespace InternLink.Services.Profiles;

public interface IProfileService
{
    Task<StudentProfile> GetStudentProfileAsync(string userId);
    Task UpdateStudentProfileAsync(StudentProfile profile);
    Task<CompanyProfile> GetCompanyProfileAsync(string userId);
    Task UpdateCompanyProfileAsync(CompanyProfile profile);
}