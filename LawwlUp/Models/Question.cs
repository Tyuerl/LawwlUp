using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LawwlUp.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Title{ get; set; }
        public string Answer { get; set; }
        
        [ForeignKey("Test")]
        public int TestId { get; set; }
        public Test ?Test { get; set; }
    }
}
