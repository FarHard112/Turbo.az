using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Entity.Models
{
    public class Year
    {
        [Key]
        public int YearId { get; set; }
        public string YearName { get; set; }
        public List<Ad> Ads { get; set; }
    }
}
