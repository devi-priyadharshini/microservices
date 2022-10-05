
using System.ComponentModel.DataAnnotations;

namespace platformservice.Dtos
{

    public class PlatformReadData
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Cost { get; set; }

    }
}