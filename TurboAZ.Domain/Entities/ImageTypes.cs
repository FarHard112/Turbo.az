using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Domain.Entities
{
    public class ImageTypes
    {
        [Key]
        public int ImageTypeId { get; set; }

        public string ImageTypeName { get; set; }
    }
}
