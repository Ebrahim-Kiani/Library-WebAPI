namespace api_practice.Models
{
    public class BooksDto
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? AuthorName { get; set; }

        public decimal Price { get; set; }

        public string? CategoryName { get; set; }
    }

}
