using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TurboAZ.Entity.Models;

namespace Turbo.AZ_ONION__.Models
{
    public class AdViewModelMetadataType
    {
        public int AdId { get; set; }

        [Required(ErrorMessage = "Şəhər göstərilməlidir!")]
        public int CityId { get; set; }

        public City City { get; set; }

        [Required(ErrorMessage = "Marka göstərilməlidir")]
        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        [Required(ErrorMessage = "Model göstərilməlidir")]
        public int ModelId { get; set; }

        public Model Model { get; set; }

        [Required(ErrorMessage = "Ban növü göstərilməlidir")]
        public int BodyId { get; set; }

        public Body Body { get; set; }

        [Required(ErrorMessage = "Rəng göstərilməlidir")]
        public int ColorId { get; set; }

        public Color Color { get; set; }

        [Required(ErrorMessage = "Valyuta göstərilməlidir")]
        public int ValuteId { get; set; }

        public Valute Valute { get; set; }

        [Required(ErrorMessage = "Yanacağın növü göstərilməlidir")]
        public int FuelId { get; set; }

        public Fuel Fuel { get; set; }

        [Required(ErrorMessage = "Ötürücü göstərilməlidir")]
        public int TransmissionId { get; set; }

        public Transmission Transmission { get; set; }

        [Required(ErrorMessage = "Sürətlər qutusu göstərilməlidir")]
        public int GearBoxId { get; set; }

        public GearBox GearBox { get; set; }

        [Required(ErrorMessage = "Mühərrikin həcmi göstərilməlidir")]
        public int? EngineVolumeId { get; set; }

        public EngineVolume EngineVolume { get; set; }

        [Required(ErrorMessage = "Buraxılış ili göstərilməlidir")]
        public int YearId { get; set; }

        public Year Year { get; set; }
        public List<Image> Images { get; set; }

        [Required(ErrorMessage = "Qiymət göstərilməlidir")]
        [Range(1, maximum: 1000000, ErrorMessage = "1-1000000 aralığında olmalıdır")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Mühərrikin gücü göstərilməlidir")]
        public int Hp { get; set; }

        [Required(ErrorMessage = "Yürüş göstərilməlidir")]
        public int Walk { get; set; }

        [Required(ErrorMessage = "Ad göstərilməlidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email göstərilməlidir")]
        [EmailAddress]
        public string Email { get; set; }
    }
}