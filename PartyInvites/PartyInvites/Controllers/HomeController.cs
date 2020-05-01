using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Greeting = DateTime.Now.Hour <12 ? "Good Morning":"Good Afternoon";
            return View("MyView");
        }

        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RsvpForm(GuestResponse response)
        {
            Repository.AddResponse(response);

            ViewBag.respond = response.Attend == true ? "Thank You for accepting the invitation :) meet you at the party, " + response.Name:"Ohh, we will miss you at the party. Do let us know if you change your plans, " + response.Name;
            return View("ThankYou");
        }

        public IActionResult ListResponses()
        {
            //var attendees = Repository.Responses.Where(r => r.Attend == true);
            return View(Repository.Responses.Where(r => r.Attend == true));
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
