using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Turbo.AZ_ONION__.Models;
using TurboAZ.DAL.Repository.Abstract;
using TurboAZ.Entity.Models;

namespace Turbo.AZ_ONION__.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITurbo _turbo;

        public HomeController(ILogger<HomeController> logger, ITurbo turbo)
        {
            _logger = logger;
            _turbo = turbo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetBrands()
        {
            var brands = _turbo.GetBrands();
            return Json(brands);
        }

        public JsonResult GetModels(int BrandId = 1)
        {
            var models = _turbo.GetModels(BrandId);
            return Json(models);
        }

        public JsonResult GetFuel()
        {
            var fuel = _turbo.GetFuel();
            return Json(fuel);
        }

        public JsonResult GetColors()
        {
            var colors = _turbo.GetColors();
            return Json(colors);
        }

        public JsonResult GetBodies()
        {
            var bodies = _turbo.GetBodies();
            return Json(bodies);
        }

        public JsonResult GetGearBoxes()
        {
            var gearBoxes = _turbo.GetGearBoxes();
            return Json(gearBoxes);
        }

        public JsonResult GetTransmissions()
        {
            var transmissions = _turbo.GeTransmissions();
            return Json(transmissions);
        }

        public JsonResult GetEngineVolumes()
        {
            var engineVolumes = _turbo.GetEngineVolumes();
            return Json(engineVolumes);
        }

        public JsonResult GetCities()
        {
            var cities = _turbo.GetCities();
            return Json(cities);
        }
        public JsonResult GetValutes()
        {
            var valutes = _turbo.GetValutes();
            return Json(valutes);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(int BrandId, Ad ads)
        {
            var readyAds = _turbo.Add(BrandId, ads);
            return View(readyAds);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}