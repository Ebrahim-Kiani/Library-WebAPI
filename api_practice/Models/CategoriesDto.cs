namespace api_practice.Models
{
    public class CategoriesDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        
        public ICollection<BooksDto> Books { get; set; } = new List<BooksDto>();


    }
}
