using System.ComponentModel.DataAnnotations;

namespace api_practice.Models
{
    public class CategoriesForCreations
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name should be less than 50 characters")]
        [MinLength(3, ErrorMessage = "Name should be more than 3 characters")]
        public string Name { get; set; } = string.Empty;


        public ICollection<BooksDto> Books { get; set; } = new List<BooksDto>();


    }
}
