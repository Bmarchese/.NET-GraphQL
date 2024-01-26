using System.ComponentModel.DataAnnotations;

namespace GraphQLHotChocolate.Models
{
    public class SuperHero
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Height { get; set; }

        [UseSorting]
        public ICollection<SuperPower> Powers { get; set; }
        [UseSorting]
        public ICollection<Movie> Movies { get; set; }
    }
}
