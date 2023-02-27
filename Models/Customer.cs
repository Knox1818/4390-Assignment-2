using System.ComponentModel.DataAnnotations;

namespace _4390_Assignment_2.Models
{
    public class Customer{
        public int CustomerID {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Name {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Address {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Email {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public Order? Orders {get;set;}
    }
}