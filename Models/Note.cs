using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NotesApp.Models
{
    public class Note
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Title { get; set; }

        [MaxLength(5000)]
        public string? Content { get; set; } = string.Empty;
        //[DisplayColumn()]
        public int NumOfWords { get; set; } = 0;

        public int CalcLength() => Content.Split(" ").Length;
        
            
        
    }
}

    