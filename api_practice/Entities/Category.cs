using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_practice.Entities
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //Empty constructor for EF Core adding seed data
        public Category() { }

        public Category(string name)
        { this.Name = name; }

        public ICollection<Books> Books{ get; set;} 
        = new List<Books>();

    }
}
