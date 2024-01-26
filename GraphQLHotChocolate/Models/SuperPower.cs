using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraphQLHotChocolate.Models
{
    public class SuperPower
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The superpower is required")]
        public string Superpower { get; set; }
        public string Description { get; set; }

        [ForeignKey("SuperheroId")]
        public Guid SuperheroId { get; set; }
        public SuperHero Superhero { get; set; }    
    }
}
