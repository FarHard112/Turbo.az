using System.Collections.Generic;
using System.Linq;
using TurboAZ.DAL.Repository.Abstract;
using TurboAZ.Entity.Models;

namespace TurboAZ.DAL.Repository.Concrete
{
    public class TurboRepo : ITurbo
    {
        private readonly TurboDBContext _context;

        public TurboRepo(TurboDBContext context)
        {
            _context = context;
        }

        public List<Brand> GetBrands()
        {
            var brands = _context.Brands.ToList();
            return brands;
        }

        public List<Model> GetModels(int BrandId)
        {
            var models = _context.Models.Where(x => x.BrandId == BrandId).ToList();
            return models;
        }

        public List<Fuel> GetFuel()
        {
            return _context.Fuels.ToList();
        }

        public List<Color> GetColors()
        {
            return _context.Colors.ToList();
        }

        public List<Transmission> GeTransmissions()
        {
            return _context.Transmissions.ToList();
        }

        public List<Body> GetBodies()
        {
            return _context.Bodies.ToList();
        }

        public List<GearBox> GetGearBoxes()
        {
            return _context.GearBoxes.ToList();
        }

        public List<EngineVolume> GetEngineVolumes()
        {
            return _context.EngineVolumes.ToList();
        }

        public Ad Add(int BrandId, Ad ads)
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
            return ads;
        }

        public List<City> GetCities()
        {
            return _context.Cities.ToList();
        }

        public List<Valute> GetValutes()
        {
            return _context.Valutes.ToList();
        }
    }
}