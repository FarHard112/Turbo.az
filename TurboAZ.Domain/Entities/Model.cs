using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Entity.Models
{
     public class Model
    {
        [Key]
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<Ad> Ads { get; set; }
    }
}
