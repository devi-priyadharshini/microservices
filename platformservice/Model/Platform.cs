using System.ComponentModel.DataAnnotations;


namespace platformservice.Model
{

    public class Platform
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string Cost { get; set; }
    }
}