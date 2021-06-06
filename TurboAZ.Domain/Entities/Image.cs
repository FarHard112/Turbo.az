using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Entity.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public int ImageTypeId { get; set; }
        public ImageType  ImageType { get; set; }
        public int AdId { get; set; }
        public Ad Ad { get; set; }


    }
}
