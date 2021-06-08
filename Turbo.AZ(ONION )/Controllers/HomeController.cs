using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Turbo.AZ_ONION__.Models;
using TurboAZ.DAL;
using TurboAZ.Entity.Models;

namespace Turbo.AZ_ONION__.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TurboDBContext _context;

        public HomeController(ILogger<HomeController> logger, TurboDBContext turboDbContext)
        {
            _logger = logger;
            _context = turboDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add(int BrandId)
        {
            List<Brand> brandlist = _context.Brands.OrderBy(i => i.BrandName).ToList();
            var brandsModel = from brand in brandlist
                              select new SelectListItem()
                              {
                                  Value = brand.BrandId.ToString(),
                                  Text = brand.BrandName
                              };
            ViewBag.Brands = new SelectList(_context.Brands.ToList(), "BrandId", "BrandName");
            ViewBag.Currency = new SelectList(_context.Valutes.ToList(), "ValuteId", "ValuteName");
            ViewBag.Color = new SelectList(_context.Colors.ToList(), "ColorId", "ColorName");
            ViewBag.Fuel = new SelectList(_context.Fuels.ToList(), "FuelId", "FuelName");
            ViewBag.Body = new SelectList(_context.Bodies, "BodyId", "BodyName");
            ViewBag.Transmission = new SelectList(_context.Transmissions.ToList(), "TransmissionId", "TransmissionName");
            ViewBag.GearBox = new SelectList(_context.GearBoxes.ToList(), "GearBoxId", "GearBoxName");
            ViewBag.City = new SelectList(_context.Cities.ToList(), "CityId", "CityName");
            ViewBag.EngineCap = new SelectList(_context.EngineVolumes.ToList(), "EngineVolumeId", "EngineVolumeName");
            return View();
        }

        public JsonResult ModelList(int BrandId)
        {
            List<Model> Models = _context.Models.Where(i => i.BrandId == BrandId).OrderBy(i => i.ModelName).ToList();
            List<SelectListItem> itemList = (from model in Models
                                             select new SelectListItem
                                             {
                                                 Value = model.ModelId.ToString(),
                                                 Text = model.ModelName
                                             }).ToList();
            return Json(itemList);
        }

        [HttpPost]
        public async Task<IActionResult> Add(int? BrandId, Ad ads)
        {
            List<Brand> brands = _context.Brands.OrderBy(i => i.BrandName).ToList();
            var brandModel = (from brand in brands
                              select new SelectListItem
                              {
                                  Value = brand.BrandId.ToString(),
                                  Text = brand.BrandName
                              }).ToList();
            ViewBag.brands = brandModel;
            ViewBag.Currency = new SelectList(_context.Valutes.ToList(), "ValuteId", "ValuteName");
            ViewBag.Color = new SelectList(_context.Colors.ToList(), "ColorId", "ColorName");
            ViewBag.Fuel = new SelectList(_context.Fuels.ToList(), "FuelId", "FuelName");
            ViewBag.Body = new SelectList(_context.Bodies, "BodyId", "BodyName");
            ViewBag.Transmission = new SelectList(_context.Transmissions.ToList(), "TransmissionId", "TransmissionName");
            ViewBag.GearBox = new SelectList(_context.GearBoxes.ToList(), "GearBoxId", "GearBoxName");
            ViewBag.City = new SelectList(_context.Cities.ToList(), "CityId", "CityName");
            ViewBag.EngineCap = new SelectList(_context.EngineVolumes.ToList(), "EngineVolumeId", "EngineVolumeName");

            if (ModelState.IsValid)
            {
                var entity = new Ad()
                {
                    BrandId = ads.BrandId,
                    ModelId = ads.ModelId,
                    BodyId = ads.BodyId,
                    Walk = ads.Walk,
                    ColorId = ads.ColorId,
                    Price = ads.Price,
                    ValuteId = ads.ValuteId,
                    CreditHave = ads.CreditHave,
                    Barter = ads.Barter,
                    FuelId = ads.FuelId,
                    TransmissionId = ads.TransmissionId,
                    GearBoxId = ads.GearBoxId,
                    YearId = ads.YearId,
                    EngineVolumeId = ads.EngineVolumeId,
                    Hp = ads.Hp,
                    Note = ads.Note,
                    AlloyWheels = ads.AlloyWheels,
                    CentralClosure = ads.CentralClosure,
                    LeatherSalon = ads.LeatherSalon,
                    SeatVent = ads.SeatVent,
                    ParkRadar = ads.ParkRadar,
                    XenonLamps = ads.XenonLamps,
                    Lyuk = ads.Lyuk,
                    Conditioner = ads.Conditioner,
                    RearCamera = ads.RearCamera,
                    RainSensor = ads.RainSensor,
                    SeatHeating = ads.SeatHeating,
                    SideCurtains = ads.SideCurtains,
                    Name = ads.Name,
                    Abs = ads.Abs,
                    CityId = ads.CityId,
                    Email = ads.Email,
                };
                _context.Add(entity);
                _context.SaveChanges();
            }

            return View(ads);
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