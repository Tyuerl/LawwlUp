using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LawwlUp.Models
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CountQuestions { get; set; }
        public int Point { get; set; }

    }
}
