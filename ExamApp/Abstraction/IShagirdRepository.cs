using ExamApp.Entities;

namespace ExamApp.Abstraction;

public interface IShagirdRepository
{
    Task<List<Shagird>> FetchAllAsync();

    Task<Shagird> FetchAsync(decimal nomre);

    Task<int> CreateAsync(Shagird ders);

    Task<int> UpdateAsync(Shagird ders);

    Task<int> DeleteAsync(Shagird ders);
}
