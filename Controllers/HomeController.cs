using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Aollpo.Data;
using Aollpo.Models;

namespace Aollpo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly MvcMovieContext _Context;

        public HomeController(ILogger<HomeController> logger,MvcMovieContext context)
        {
            _logger = logger;
            _Context = context;
        }

        /// <summary>
        /// test
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> IndexAsync()
         {

            var movie = await _Context.Movie.FirstOrDefaultAsync(p => p.Id.ToString() == "1");

            return View(new Movie { Id=movie.Id});
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
