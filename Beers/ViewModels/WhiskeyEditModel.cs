using Drinks.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks.ViewModels
{
    public class WhiskeyEditModel
    {
        [Required]
        public string Name { get; set; }
        public WhiskeyType Type { get; set; }
    }
}
