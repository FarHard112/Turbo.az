using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Entity.Models
{
    public class GearBox
    {
        [Key]
        public int GearBoxId { get; set; }
        public string GearBoxName { get; set; }
        public List<Ad> Ads { get; set; }
    }
}
