using LawwlUp.Models;
using Microsoft.EntityFrameworkCore;

namespace LawwlUp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
        public DbSet<PassedTest> PassedTests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Guide> Guides { get; set; }
    }
}
