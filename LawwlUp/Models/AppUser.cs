using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using LawwlUp.Data.Enums;

namespace LawwlUp.Models
{
    public class AppUser
    {
        [Key]
        public string Id { get; set; }
        public UserCategory UserCategory { get; set; }
        public ICollection<Test> Tests{get; set;}
        public ICollection<PassedTest> PassedTests { get; set; }
    }
}
