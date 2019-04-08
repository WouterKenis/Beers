using Drinks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks.Services
{
    public class InMemoryBeerData : IBeerData
    {

        List<Beer> _beers;

        public InMemoryBeerData()
        {
            _beers = new List<Beer>
            {
                new Beer { Id = 1, Name = "Duvel" },
                new Beer { Id = 2, Name = "Jupiler" },
                new Beer { Id = 3, Name = "Corsendonck" },
                new Beer { Id = 4, Name = "Westmalle" }
            };
        }

        public IEnumerable<Beer> GetAll()
        {
            return _beers;
        }

        public Beer Get(int id)
        {
            return _beers.FirstOrDefault(beer => beer.Id == id);
        }

        public Beer Add(Beer newBeer)
        {
            newBeer.Id = _beers.Max(beer => beer.Id) + 1;
            _beers.Add(newBeer);

            return newBeer;
        }
    }
}
