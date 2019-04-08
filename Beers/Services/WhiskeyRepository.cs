using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinks.Models;

namespace Drinks.Services
{
    public class WhiskeyRepository : IWhiskeyData
    {
        private DrinksDbContext _context;

        public WhiskeyRepository(DrinksDbContext context)
        {
            _context = context;
        }

        public Whiskey Add(Whiskey newWhiskey)
        {
            _context.Whiskies.Add(newWhiskey);
            _context.SaveChanges();

            return newWhiskey;
        }

        public Whiskey Get(int id)
        {
            return _context.Whiskies.FirstOrDefault(whiskey => whiskey.Id == id);
        }

        public IEnumerable<Whiskey> GetAll()
        {
            return _context.Whiskies;
        }
    }
}
