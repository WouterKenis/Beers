using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinks.Models;

namespace Drinks.Services
{
    public class BeerRepository : IBeerData
    {
        private DrinksDbContext _context;

        public BeerRepository(DrinksDbContext context)
        {
            _context = context;
        }

        public Beer Add(Beer newBeer)
        {
            _context.Beers.Add(newBeer);
            _context.SaveChanges();

            return newBeer;

        }

        public Beer Get(int id)
        {
            return _context.Beers.FirstOrDefault(beer => beer.Id == id);
        }

        public IEnumerable<Beer> GetAll()
        {
            return _context.Beers;
        }
    }
}
