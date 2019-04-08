using System.ComponentModel.DataAnnotations;

namespace Drinks.Models
{
    public class Beer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public BeerType Type { get; set; }
    }
}
