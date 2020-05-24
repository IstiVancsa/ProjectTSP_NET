using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP.NET.CORE.UI.Models;
using MovieService;
using PhotoService;

namespace ASP.NET.CORE.UI.Controllers
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
            return View();
        }

        public async Task<IActionResult> Video()
        {
            MovieServiceClient client = new MovieServiceClient(MovieServiceClient.EndpointConfiguration.NetTcpBinding_IMovieService);
            VideoViewModel videoViewModel = new VideoViewModel { Videos = await client.GetAllAsync() };
            await client.CloseAsync();
            return View(videoViewModel);
        }

        public async Task<IActionResult> Photo()
        {
            PhotoServiceClient client = new PhotoServiceClient(PhotoServiceClient.EndpointConfiguration.NetTcpBinding_IPhotoService);
            PhotoViewModel photoViewModel = new PhotoViewModel { Photos = await client.GetAllAsync() };
            await client.CloseAsync();
            return View(photoViewModel);
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
