﻿using Drinks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Beer> Beers { get; set; }
    }
}
