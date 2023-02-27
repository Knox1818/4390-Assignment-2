using System.ComponentModel.DataAnnotations;

namespace _4390_Assignment_2.Models
{
    public class Delivery{
        public int DeliveryID {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Driver {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? DeliveryTime {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
    }
}