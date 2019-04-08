using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks.Models
{
    public class Whiskey
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public WhiskeyType Type { get; set; }
    }
}
