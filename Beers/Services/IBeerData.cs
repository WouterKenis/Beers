using Drinks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks.Services
{
    public interface IBeerData
    {
        IEnumerable<Beer> GetAll();
        Beer Get(int id);
        Beer Add(Beer newBeer);
    }
}
