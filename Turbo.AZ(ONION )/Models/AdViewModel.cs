using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Image = TurboAZ.Entity.Models.Image;

namespace Turbo.AZ_ONION__.Models
{
    [ModelMetadataType(typeof(AdViewModelMetadataType))]
    public class AdViewModel
    {
        public AdViewModel()
        {
            Images = new List<Image>();
        }
        public int CityId { get; set; }

        public int BrandId { get; set; }

        public int ModelId { get; set; }

        public int BodyId { get; set; }

        public int ColorId { get; set; }

        public int ValuteId { get; set; }

        public int FuelId { get; set; }

        public int TransmissionId { get; set; }

        public int GearBoxId { get; set; }

        public int? EngineVolumeId { get; set; }

        public int YearId { get; set; }
        public double Price { get; set; }

        public int Hp { get; set; }
        public int Walk { get; set; }
        public bool CreditHave { get; set; }
        public bool Barter { get; set; }
        public string Note { get; set; }
        public bool AlloyWheels { get; set; }
        public bool CentralClosure { get; set; }
        public bool LeatherSalon { get; set; }
        public bool SeatVent { get; set; }
        public bool Abs { get; set; }
        public bool ParkRadar { get; set; }
        public bool XenonLamps { get; set; }
        public bool Lyuk { get; set; }
        public bool Conditioner { get; set; }
        public bool RearCamera { get; set; }
        public bool RainSensor { get; set; }
        public bool SeatHeating { get; set; }
        public bool SideCurtains { get; set; }
        public List<Image> Images { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        // public DateTime Date { get; set; }
    }
}