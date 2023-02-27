using System.ComponentModel.DataAnnotations;

namespace _4390_Assignment_2.Models
{
    public class Order{
        public int OrderID {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Food {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Restaurant {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? ResAddress {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
    }
}