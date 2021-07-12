using System;
using System.Collections.Generic;

namespace TurboAZ.Entity.Models
{
    public class Ad
    {
        public Ad()
        {
            Images = new List<Image>();
        }
        public int AdId { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int BodyId { get; set; }
        public Body Body { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int ValuteId { get; set; }
        public Valute Valute { get; set; }
        public int FuelId { get; set; }
        public Fuel Fuel { get; set; }
        public int TransmissionId { get; set; }
        public Transmission Transmission { get; set; }
        public int GearBoxId { get; set; }
        public GearBox GearBox { get; set; }
        public int? EngineVolumeId { get; set; }
        public EngineVolume EngineVolume { get; set; }

        public int YearId { get; set; }
        public Year Year { get; set; }
        public virtual ICollection<Image> Images { get; set; }
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
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}