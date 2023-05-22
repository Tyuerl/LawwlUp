using LawwlUp.Models;

namespace LawwlUp.Interfaces
{
    public interface ITestRepository
    {
        Task<IEnumerable<Test>> GetAll();
        Task<Test?> GetByIdAsync(int id);
        Task<IEnumerable<Test>> GetTestsByTitleAsync();
        Task<IEnumerable<Test>> GetTestsByCountAsync();
        Task<IEnumerable<Test>> GetTestsByPointAsync();

        Task<int> GetCountAsync();
        bool Add(Test Test);
        bool Update(Test Test);
        bool Delete(Test Test);
        bool Save();
    }

}
