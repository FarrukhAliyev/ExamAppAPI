using ExamApp.Entities;

namespace ExamApp.Abstraction;

public interface IDersRepository
{
    Task<List<Ders>> FetchAllAsync();

    Task<Ders> FetchAsync(string kod);

    Task<int> CreateAsync(Ders ders);

    Task<int> UpdateAsync(Ders ders);

    Task<int> DeleteAsync(Ders ders);
}
