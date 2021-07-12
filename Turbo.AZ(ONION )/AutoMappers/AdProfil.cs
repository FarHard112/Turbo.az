using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Turbo.AZ_ONION__.Models;
using TurboAZ.Entity.Models;

namespace Turbo.AZ_ONION__.AutoMappers
{
    public class AdProfil:Profile
    {
        public AdProfil()
        {
            CreateMap<Ad, AdViewModel>();
            CreateMap<AdViewModel, Ad>();
        }
    }
}
