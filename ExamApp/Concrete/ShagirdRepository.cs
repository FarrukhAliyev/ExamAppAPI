using ExamApp.Abstraction;
using ExamApp.DAL;
using ExamApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamApp.Concrete;

public class ShagirdRepository : IShagirdRepository
{
    ExamAppDbContext _dbContext;

    public ShagirdRepository(ExamAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<List<Shagird>> FetchAllAsync()
    {
        return _dbContext.Shagird.AsNoTracking().ToListAsync();
    }

    public async Task<Shagird> FetchAsync(decimal nomre)
    {
        var obj = await _dbContext.Shagird.AsNoTracking().FirstOrDefaultAsync(d => d.Nomre == nomre);

        return obj;
    }

    public async Task<int> CreateAsync(Shagird ders)
    {
        await _dbContext.Shagird.AddAsync(ders);

        return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> UpdateAsync(Shagird ders)
    {
        _dbContext.Shagird.Update(ders);

        return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> DeleteAsync(Shagird ders)
    {
        _dbContext.Shagird.Remove(ders);

        return await _dbContext.SaveChangesAsync();
    }
}
