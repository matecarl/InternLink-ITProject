using InternLink.Models;

namespace InternLink.Interfaces;

public interface IInternshipRepository
{
    Task AddAsync(Internship internship);
    
    Task UpdateAsync(Internship internship, int internshipId);
    
    Task DeleteAsync(Internship internship);
    
    Task<List<Internship>> GetAllAsync();
    
    Task<Internship> GetByIdAsync(int internshipId);
    
    Task<List<Internship>> GetAllByUserIdAsync(string userId);
    
}