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
        //create a new instance of the Make a turkey class with the Recipe method. 
        readonly MakeATurkey turkey = new MakeATurkey();
        //set empty string for submission result to be displayed under the submission button
        public string SubmissionResult { get; private set; } = "";
        //taken from Your new favorite poem. https://github.com/MetzinAround/Your-New-Favorite-Poem
        public async Task OnPostSubmit(string weight)
        {
            //I wasn't sure how to use this from you're new favorite poem without the task/async, so I created a fake await with a delay of 1 second so I could use it. 
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
