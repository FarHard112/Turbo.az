using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Entity.Models
{
    public class Transmission
    {
        [Key]
        public int TransmissionId { get; set; }
        public string TransmissionName { get; set; }
        public List<Ad> Ads { get; set; }
    }

}
