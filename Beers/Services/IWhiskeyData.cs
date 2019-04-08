using Drinks.Models;
using System.Collections.Generic;

namespace Drinks.Services
{
    public interface IWhiskeyData
    {
        IEnumerable<Whiskey> GetAll();
        Whiskey Get(int id);
        Whiskey Add(Whiskey newWhiskey);
    }
}
