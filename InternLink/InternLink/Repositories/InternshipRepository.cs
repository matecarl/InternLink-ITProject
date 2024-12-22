using InternLink.Data;
using InternLink.Interfaces;
using InternLink.Models;
using Microsoft.EntityFrameworkCore;

namespace InternLink.Repositories;

public class InternshipRepository : IInternshipRepository
{
    private readonly ApplicationDbContext _context;

    public InternshipRepository(IDbContextFactory<ApplicationDbContext> factory)
    {
        _context = factory.CreateDbContext();
    }

    public async Task<List<Internship>> GetAllAsync()
    {
        var internships = await _context.Internships.ToListAsync();
        return internships;
    }

    public async Task<Internship> GetByIdAsync(int id)
    {
        var internship = await _context.Internships
            .FirstOrDefaultAsync(x => x.Id == id);
        return internship;
    }

    public async Task<List<Internship>> GetAllByUserIdAsync(string userId)
    {
        var internships = await _context.Internships
            .Where(x => x.UserId == userId)
            .ToListAsync();
        return internships;

    }

    public async Task AddAsync(Internship internship)
    {
        _context.Internships.Add(internship);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Internship internship, int id)
    {
        var updatedInternship = await _context.Internships
            .FirstOrDefaultAsync(x => x.Id == id);
        if (updatedInternship == null)
        {
            return;
        }
        
        updatedInternship.Title = internship.Title;
        updatedInternship.Description = internship.Description;
        updatedInternship.Location = internship.Location;
        updatedInternship.RemoteLevel = internship.RemoteLevel;
        updatedInternship.MinDuration = internship.MinDuration;
        updatedInternship.UpdatedAt = DateTime.Now;
        
        _context.Internships.Update(updatedInternship);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Internship internship)
    {
        _context.Internships.Remove(internship);
        await _context.SaveChangesAsync();
    }
    
}