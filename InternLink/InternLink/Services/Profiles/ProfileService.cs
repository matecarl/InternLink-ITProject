using InternLink.Data;
using InternLink.Models;
using Microsoft.EntityFrameworkCore;

namespace InternLink.Services.Profiles;

public class ProfileService : IProfileService
{
    private readonly ApplicationDbContext _context;

    public ProfileService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<StudentProfile> GetStudentProfileAsync(string userId)
    {
        return await _context.StudentProfiles.FirstOrDefaultAsync(s => s.UserId == userId);
    }

    public async Task UpdateStudentProfileAsync(StudentProfile profile)
    {
        var existingProfile = await _context.StudentProfiles.FirstOrDefaultAsync(s => s.UserId == profile.UserId);
        if (existingProfile != null)
        {
            _context.Entry(existingProfile).CurrentValues.SetValues(profile);
        }
        else
        {
            _context.StudentProfiles.Add(profile);
        }
        await _context.SaveChangesAsync();
    }

    public async Task<CompanyProfile> GetCompanyProfileAsync(string userId)
    {
        return await _context.CompanyProfiles.FirstOrDefaultAsync(c => c.UserId == userId);
    }

    public async Task UpdateCompanyProfileAsync(CompanyProfile profile)
    {
        var existingProfile = await _context.CompanyProfiles.FirstOrDefaultAsync(c => c.UserId == profile.UserId);
        if (existingProfile != null)
        {
            _context.Entry(existingProfile).CurrentValues.SetValues(profile);
        }
        else
        {
            _context.CompanyProfiles.Add(profile);
        }
        await _context.SaveChangesAsync();
    }

    //to make sure that the company profile service is used to fetch the list of companies
    public async Task<List<CompanyProfile>> GetAllCompaniesAsync()
    {
        return await _context.CompanyProfiles.ToListAsync();
    }
}
