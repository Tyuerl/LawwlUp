using LawwlUp.Data;
using LawwlUp.Interfaces;
using LawwlUp.Models;
using Microsoft.EntityFrameworkCore;

namespace LawwlUp.Repository
{
    public class TestRepository : ITestRepository
    {

        ApplicationDbContext _context;
        public TestRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Save()
        {
            return (_context.SaveChanges()) > 0;
        }

        public bool Add(Test Test)
        {
            _context.Add(Test);
            return Save();
        }

        public bool Delete(Test Test)
        {
            _context.Remove(Test);
            return Save();
        }
        public bool Update(Test Test)
        {
            _context.Update(Test);
            return Save();
        }


        public async Task<IEnumerable<Test>> GetAll()
        {
            return await _context.Tests.ToListAsync();
        }

        public async Task<Test?> GetByIdAsync(int id)
        {
            return await _context.Tests.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<int> GetCountAsync()
        {
            return await _context.Tests.CountAsync();
        }
        public async Task<IEnumerable<Test>> GetTestsByCountAsync()
        {
            return await _context.Tests.OrderBy(x => x.CountQuestions).ToListAsync();
        }

        public async Task<IEnumerable<Test>> GetTestsByPointAsync()
        {
            return await _context.Tests.OrderBy(x => x.Point).ToListAsync();
        }

        public async Task<IEnumerable<Test>> GetTestsByTitleAsync()
        {
            return await _context.Tests.OrderBy(x => x.Title).ToListAsync();
        }
    }
}
