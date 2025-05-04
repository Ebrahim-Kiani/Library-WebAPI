using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_practice.Entities
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Bio { get; set; }  // زندگینامه یا توضیح مختصر

        [MaxLength(100)]
        public string? Nationality { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public ICollection<Books> Books { get; set; } = new List<Books>();

        public Author() { }

        public Author(string fullName)
        {
            FullName = fullName;
        }
    }
}
