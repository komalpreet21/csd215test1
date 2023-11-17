using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    public void onPost()
    {
        if(Request.Method.Equals("POST", System.StringComparison.OrdinalIgnoreCase))
        {
            string val1 = Request.Form["value1"];
            string val2 = Request.Form["value2"];
        
        double res2=0;

        if(Request.Form["x2"]=="x2"){
            double res = double.Parse(val1);

            res2 =res*res;


        }
        if(Request.Form["x3"]=="x3"){
            double res = double.Parse(val1);

            res2 = res*res*res;

        }

        if(Request.Form["power"]=="power"){
            double value1 = double.Parse(val1);
            double value2 = double.Parse(val2);
              res2=1;
            for (int i=1; i<value2; i++)
            {
                res2=res2*value1;
            }
        }

        ViewData["result"] = res2;
    }

    }
}
