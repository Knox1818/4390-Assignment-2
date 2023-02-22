using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _4390_Assignment_2.Pages;

public class ShopeModel : PageModel
{
    private readonly ILogger<ShopeModel> _logger;

    public ShopeModel(ILogger<ShopeModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
