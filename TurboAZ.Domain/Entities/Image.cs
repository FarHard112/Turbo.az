using System.ComponentModel.DataAnnotations;

namespace TurboAZ.Entity.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }

        public string ImageUrl { get; set; }
        public int ImageTypeId { get; set; }
        public int? AdsId { get; set; }
        public virtual Ad Ads { get; set; }
    }
}