using System.ComponentModel.DataAnnotations;

namespace Final_Project_CarBag.Models
{
    public class Order{
        public int OrderID {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Food {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Customer {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Email {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
    }
}