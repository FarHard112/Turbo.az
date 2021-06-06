using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Entity.Models
{
    public class Body
    {
        [Key]
        public int BodyId { get; set; }
        public string BodyName { get; set; }
        public List<Ad> Ads { get; set; }
    }
}
