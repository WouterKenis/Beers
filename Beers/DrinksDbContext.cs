using Drinks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks
{
    public class DrinksDbContext : DbContext
    {

        public DrinksDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Whiskey> Whiskies { get; set; }
        public DbSet<Beer> Beers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Beer>().HasData(
                new Beer { Id = 1, Name = "Duvel", Type = BeerType.Blonde },
                new Beer { Id = 2, Name = "Jupiler", Type = BeerType.Blonde },
                new Beer { Id = 3, Name = "Corsendonck", Type = BeerType.Dark },
                new Beer { Id = 4, Name = "Westmalle", Type = BeerType.Quadruple }
                );

            modelBuilder.Entity<Whiskey>().HasData(
                new Whiskey { Id = 1, Name = "Jack Daniel's", Type = WhiskeyType.SingleMalt },
                new Whiskey { Id = 2, Name = "Crown Royal", Type = WhiskeyType.GrainWhisky },
                new Whiskey { Id = 3, Name = "Jim Beam", Type = WhiskeyType.Scotch },
                new Whiskey { Id = 4, Name = "Jameson", Type = WhiskeyType.Scotch }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
