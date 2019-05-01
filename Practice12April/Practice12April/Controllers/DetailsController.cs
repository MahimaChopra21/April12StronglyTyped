using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practice12April.Models;

namespace Practice12April.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["firstName"] = "Mahima";
            ViewData["lastName"] = "Chopra";
            ViewData["City"] = "Jaipur";

            var count = ViewData.Count;

            var details = new Details
            {
                count = ViewData.Count,
                keys = ViewData.Keys.ToList(),
                values = ViewData.Values.ToList()
            };

            return View(details);
        }

        public IActionResult SportsList()
        {
            SportsData obj = new SportsData();
            
            List<SportsPersonData> sportPersonData=obj.getData();
            return View(sportPersonData);
        }
    }
}