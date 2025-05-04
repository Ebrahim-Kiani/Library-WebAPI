using System.ComponentModel.DataAnnotations;
namespace api_practice.Models
{
    public class BooksForCreationDto
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Description { get; set; }

        public int AuthorId { get; set; }

        [MaxLength(13)]
        public string? ISBN { get; set; }

        [Range(0, 999999.99)]
        public decimal Price { get; set; }

        public DateTime PublishedDate { get; set; } = DateTime.UtcNow;

        [Required]
        public int CategoryId { get; set; }
    }
}