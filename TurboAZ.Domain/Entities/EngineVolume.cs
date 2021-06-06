using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Entity.Models
{
    public class EngineVolume
    {
        [Key]
        public int? EngineVolumeId { get; set; }
        public double EngineVolumeName { get; set; }
        public List<Ad> Ads { get; set; }
    }
}
