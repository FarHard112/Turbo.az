using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Entity.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public List<Model> Models { get; set; }
        public List<Ad> Ads { get; set; }
    }
}
