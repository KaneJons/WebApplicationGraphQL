using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationGraphQL.Models;
using WebApplicationGraphQL.ResponseTypes;

namespace WebApplicationGraphQL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QueryCharacter _queryCharacter;
        public HomeController(ILogger<HomeController> logger,QueryCharacter queryCharacter)
        {
            _logger = logger;
            _queryCharacter = queryCharacter;
        }

        public async Task<IActionResult> IndexAsync()
        {  
                var model = await _queryCharacter.GetAllQuers();

                int hour = DateTime.Now.Hour;
                ViewBag.Greeting = "";
                if (hour <= 11)
                {
                    ViewBag.Greeting = "Доброе утро";
                }
                else if (hour <= 17)
                {
                    ViewBag.Greeting = "Добрый день";
                }
                else
                {
                    ViewBag.Greeting = "Добрый вечер";
                }
                return View(model);
            
        }
        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
