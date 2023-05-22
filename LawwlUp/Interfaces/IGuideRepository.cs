using LawwlUp.Models;

namespace LawwlUp.Interfaces
{
    public interface IGuideRepository
    {
        Task<IEnumerable<Guide>> GetAll();
        Task<Guide?> GetByIdAsync(int id);
        Task<int> GetCountAsync();
        bool Add(Guide guide);
        bool Update(Guide guide);
        bool Delete(Guide guide);
        bool Save();
    }
}
