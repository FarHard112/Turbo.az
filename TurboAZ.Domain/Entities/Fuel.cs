﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Entity.Models
{
    public class Fuel
    {
        [Key]
        public int FuelId { get; set; }
        public string FuelName { get; set; }
        public List<Ad> Ads { get; set; }
    }
}
