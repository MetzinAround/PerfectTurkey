using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Web.Mvc;


namespace PerfectTurkey.Pages
{ 
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
        readonly MakeATurkey turkey = new MakeATurkey();

        public string SubmissionResult { get; private set; } = "";
        public async Task OnPostSubmit(string weight)
        {

            double doubleWeight;

            if (weight is null || !double.TryParse(weight, out doubleWeight))
            {
                SubmissionResult = "Please enter a number";
            }
            else
            {
                var weighted = Convert.ToDouble(weight);
                
                try
                {
                    await Task.Delay(1000);
                    SubmissionResult = turkey.Recipe(weighted);
                }
                catch
                {
                    SubmissionResult = "TURKEY, WHAT ARE YOU DOING?";
                }
            }
        }
    }
}
