using System.Collections.Generic;
using System.Linq;
using TurboAZ.DAL.Repository.Abstract;
using TurboAZ.Entity.Models;

namespace TurboAZ.DAL.Repository.Concrete
{
    public class TurboRepository : ITurboRepository
    {
        private readonly TurboDBContext _context;

        public TurboRepository(TurboDBContext context)
        {
            _context = context;
        }

        #region GetDropdownData

        public List<Body> GetBodies()
        {
            return _context.Bodies.ToList();
        }

        public List<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }

        public List<City> GetCities()
        {
            return _context.Cities.ToList();
        }

        public List<Color> GetColors()
        {
            return _context.Colors.ToList();
        }

        public List<EngineVolume> GetEngineVolumes()
        {
            return _context.EngineVolumes.ToList();
        }

        public List<Fuel> GetFuel()
        {
            return _context.Fuels.ToList();
        }

        public List<GearBox> GetGearBoxes()
        {
            return _context.GearBoxes.ToList();
        }

        public List<Model> GetModels(int BrandId)
        {
            return _context.Models.Where(x => x.BrandId == BrandId).ToList();
        }

        public List<Transmission> GeTransmissions()
        {
            return _context.Transmissions.ToList();
        }

        public List<Valute> GetValutes()
        {
            return _context.Valutes.ToList();
        }

        public List<Year> GetYears()
        {
            return _context.Years.ToList();
        }

        #endregion GetDropdownData

        public void Add(int BrandId, Ad ads)
        {
            var newAd = new Ad()
            {
                BrandId = BrandId,
                ModelId = ads.ModelId,
                BodyId = ads.BodyId,
                Walk = ads.Walk,
                ColorId = ads.ColorId,
                Price = ads.Price,
                FuelId = ads.FuelId,
                TransmissionId = ads.TransmissionId,
                GearBoxId = ads.GearBoxId,
                YearId = ads.YearId,
                EngineVolumeId = ads.EngineVolumeId,
                Hp = ads.Hp,
                Note = ads.Note,
                CreditHave = ads.CreditHave,
                ValuteId = ads.ValuteId,
                Barter = ads.Barter,
                AlloyWheels = ads.AlloyWheels,
                CentralClosure = ads.CentralClosure,
                SeatVent = ads.SeatVent,
                Abs = ads.Abs,
                ParkRadar = ads.ParkRadar,
                XenonLamps = ads.XenonLamps,
                Lyuk = ads.Lyuk,
                Conditioner = ads.Conditioner,
                RearCamera = ads.RearCamera,
                RainSensor = ads.RainSensor,
                SeatHeating = ads.SeatHeating,
                SideCurtains = ads.SideCurtains,
                Name = ads.Name,
                CityId = ads.CityId,
                Email = ads.Email,
            };
            _context.Ads.Add(newAd);
        }

       public void AddImage(Ad adsModel)
        {
            _context.Images.AddRange(adsModel.Images);
        }
    }
}