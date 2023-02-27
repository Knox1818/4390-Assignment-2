using System.ComponentModel.DataAnnotations;

namespace Final_Project_CarBag.Models
{
    public class Customer{
        public int CustomerID {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Name {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Email {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
    }
}