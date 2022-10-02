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
        public string Title { get; set; }

        [Required]
        [MaxLength(5000)]
        public string Content { get; set; } = string.Empty;

        [MaxLength(50)]
        public string TitleColor { get; set; } = "black";
        


        public int CalcLength() => Content.Split(" ").Length;
        
            
        
    }
}

    