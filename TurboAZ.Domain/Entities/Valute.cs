using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Entity.Models
{
    public class Valute
    {
        [Key]
        public int ValuteId { get; set; }
        public string ValuteName { get; set; }
        public List<Ad> Ads { get; set; }
    }
}
