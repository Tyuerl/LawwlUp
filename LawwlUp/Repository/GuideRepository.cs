using LawwlUp.Data;
using LawwlUp.Interfaces;
using LawwlUp.Models;
using Microsoft.EntityFrameworkCore;

namespace LawwlUp.Repository
{
    public class GuideRepository : IGuideRepository
    {
        ApplicationDbContext _context;
        public GuideRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Save()
        {
            return (_context.SaveChanges()) > 0;
        }

        public bool Add(Guide guide)
        {
            _context.Add(guide);
            return Save();
        }

        public bool Delete(Guide guide)
        {
            _context.Remove(guide);
            return Save();
        }
        public bool Update(Guide guide)
        {
            _context.Update(guide);
            return Save();
        }

        public async Task<IEnumerable<Guide>> GetAll()
        {
            return await _context.Guides.ToListAsync();
        }

        public async Task<Guide?> GetByIdAsync(int id)
        {
            return await _context.Guides.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<int> GetCountAsync()
        {
            return await _context.Guides.CountAsync();
        }
    }
}
