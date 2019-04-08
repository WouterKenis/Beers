using Drinks.Models;
using System.ComponentModel.DataAnnotations;

namespace Drinks.ViewModels
{
    public class BeerEditModel
    {
        [Required]
        public string Name { get; set; }
        public BeerType Type { get; set; }
    }
}
