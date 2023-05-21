using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LawwlUp.Models
{
    public class PassedTest
    {
        [Key]
        public int Id { get; set; }

        public int Score { get; set; }
        public int Point { get; set; }
        public string ?Image { get; set; }
        
        [ForeignKey("Test")]
        public int TestId { get; set; }

        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
