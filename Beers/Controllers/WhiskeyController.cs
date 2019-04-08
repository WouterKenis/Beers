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
    public class WhiskeyController : Controller
    {
        private IWhiskeyData _whiskeyData;

        public WhiskeyController(IWhiskeyData whiskeyData)
        {
            _whiskeyData = whiskeyData;
        }

        public IActionResult Index()
        {
            var model = new WhiskeyIndexViewModel();

            model.Whiskies = _whiskeyData.GetAll();

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _whiskeyData.Get(id);

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
        public IActionResult Create(WhiskeyEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newWhiskey = new Whiskey();
                newWhiskey.Name = model.Name;
                newWhiskey.Type = model.Type;

                newWhiskey = _whiskeyData.Add(newWhiskey);

                return RedirectToAction("Details", new { Id = newWhiskey.Id });
            }
            else
            {
                return View();
            }
        }
    }
}
