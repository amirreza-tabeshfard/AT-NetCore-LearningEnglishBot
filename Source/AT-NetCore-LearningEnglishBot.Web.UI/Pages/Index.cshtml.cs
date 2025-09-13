using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT_NetCore_LearningEnglishBot.Web.UI.Pages;
public class IndexModel(ILogger<IndexModel> logger) 
    : PageModel
{
    #region Field(s)
    
    private readonly ILogger<IndexModel> _logger = logger; 

    #endregion

    public void OnGet()
    {

    }
}