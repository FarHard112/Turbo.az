using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Turbo.AZ_ONION__.Models;
using Turbo.AZ_ONION__.TypeConverter;
using TurboAZ.DAL;
using TurboAZ.Entity.Models;

namespace Turbo.AZ_ONION__.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region GetDropdownsData

        public JsonResult GetBrands()
        {
            var brands = _unitOfWork.turboRepository.GetBrands();
            return Json(brands);
        }

        public JsonResult GetModels(int BrandId = 1)
        {
            var models = _unitOfWork.turboRepository.GetModels(BrandId);
            return Json(models);
        }

        public JsonResult GetFuel()
        {
            var fuel = _unitOfWork.turboRepository.GetFuel();
            return Json(fuel);
        }

        public JsonResult GetColors()
        {
            var colors = _unitOfWork.turboRepository.GetColors();
            return Json(colors);
        }

        public JsonResult GetBodies()
        {
            var bodies = _unitOfWork.turboRepository.GetBodies();
            return Json(bodies);
        }

        public JsonResult GetGearBoxes()
        {
            var gearBoxes = _unitOfWork.turboRepository.GetGearBoxes();
            return Json(gearBoxes);
        }

        public JsonResult GetTransmissions()
        {
            var transmissions = _unitOfWork.turboRepository.GeTransmissions();
            return Json(transmissions);
        }

        public JsonResult GetEngineVolumes()
        {
            var engineVolumes = _unitOfWork.turboRepository.GetEngineVolumes();
            return Json(engineVolumes);
        }

        public JsonResult GetCities()
        {
            var cities = _unitOfWork.turboRepository.GetCities();
            return Json(cities);
        }

        public JsonResult GetValutes()
        {
            var valutes = _unitOfWork.turboRepository.GetValutes();
            return Json(valutes);
        }

        public JsonResult GetYears()
        {
            var years = _unitOfWork.turboRepository.GetYears();
            return Json(years);
        }

        #endregion GetDropdownsData

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(int BrandId, AdViewModel adViewModel, List<IFormFile> imgFiles)
        {
            Ad model = TypeConversion.Converter<AdViewModel, Ad>(adViewModel);
            _unitOfWork.turboRepository.Add(BrandId, model);

            if (imgFiles.Count > 0)
            {
                foreach (var file in imgFiles)
                {
                    var extensission = Path.GetExtension(file.FileName);
                    var imgName = Guid.NewGuid() + extensission;
                    model.Images.Add(new Image(){ImageUrl = imgName,AdsId = model.AdId});
                    var downloadPlace = Path.Combine(Directory.GetCurrentDirectory(), "/wwwwroot/img" + imgName);
                    var stream = new FileStream(imgName, FileMode.Create);
                    file.CopyTo(stream);
                  
                }
            }

            _unitOfWork.turboRepository.AddImage(model);
            _unitOfWork.Complete();
            _unitOfWork.Dispose();

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}