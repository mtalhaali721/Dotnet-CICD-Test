using System.ComponentModel.DataAnnotations;

namespace TKWebAPI.Models
{
    public class DevicesModel
    {
        [Key]
        public int DevId { get; set; }

        [Required]
        public string DevCategory { get; set; }

        [Required]
        public string DevName { get; set; }

        [Required]
        public int DevQuantity { get; set; }

        [Required]
        public float DevRate { get; set; }

    }
}
