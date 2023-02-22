using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _4390_Assignment_2.Pages;

public class CartModel : PageModel
{
    [BindProperty]
    [Display(Name ="Firt Name")]
    [Required]
    public string Name{get; set;}=string.Empty;

    [BindProperty]
    [Required]
    [Display(Name ="E-Mail")]
    [EmailAddress] // requirment for emails
    public string email {get; set;}=string.Empty;
    [BindProperty]
    [Display(Name = "Credit Card")]
    [Required]
    [CreditCard]
    public string CreditCard {get;set;}=string.Empty;

    [BindProperty]
    [Required] //required field
    [StringLength(200, MinimumLength =1)]  // limit length 
    public string message{get;set;}=string.Empty;
    public string submit{get;set;}
    private readonly ILogger<CartModel> _logger;

    public CartModel(ILogger<CartModel> logger)
    {
        _logger = logger;
    }

     public void OnGet()
    {

    }
    public void OnPost()
    {
        _logger.LogWarning($"OnPost Called{Name} {email}"); // log to show errors or in this case everytime OnPost is called 
    }
}
