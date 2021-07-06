﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;

namespace TurboAZ.DAL.Repository.Abstract
{
    public interface ITurbo
    {
        public List<Brand> GetBrands();
        public List<Model> GetModels(int BrandId);
        public List<Fuel> GetFuel();
        public List<Color> GetColors();
        public List<Transmission> GeTransmissions();
        public List<Body> GetBodies();
        public List<GearBox> GetGearBoxes();
        public List<EngineVolume> GetEngineVolumes();
        public List<City> GetCities();
        public List<Valute> GetValutes();
        public Ad Add(int BrandId,Ad ads);

    }
}
