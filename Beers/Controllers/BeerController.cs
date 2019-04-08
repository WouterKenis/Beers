using Drinks.Models;
using Drinks.Services;
using Drinks.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks.Controllers
{
    public class BeerController : Controller
    {
        private IBeerData _beerData;

        public BeerController(IBeerData beerData)
        {
            _beerData = beerData;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();

            model.Beers = _beerData.GetAll();

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _beerData.Get(id);

            if (model == null)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BeerEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newBeer = new Beer();
                newBeer.Name = model.Name;
                newBeer.Type = model.Type;

                newBeer = _beerData.Add(newBeer);

                return RedirectToAction("Details", new { Id = newBeer.Id });
            }
            else
            {
                return View();
            }
        }
    }
}
