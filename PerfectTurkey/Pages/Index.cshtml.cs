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

        public IndexModel(MakeATurkey makeATurkey, ILogger<IndexModel> logger)
        {
            turkey = makeATurkey;
            _logger = logger;
        }

        public void OnGet()
        {
          

        }
        //create a new instance of the Make a turkey class with the Recipe method. 
        readonly MakeATurkey turkey;
        //set empty string for submission result to be displayed under the submission button
        public string SubmissionResult { get; private set; } = "";
        //taken from Your new favorite poem. https://github.com/MetzinAround/Your-New-Favorite-Poem
        public void OnPostSubmit(string weight)
        {
            //I wasn't sure how to use this from you're new favorite poem without the task/async, so I created a fake await with a delay of 1 second so I could use it. 

            if (weight is null || !double.TryParse(weight, out double doubleWeight))
            {
                SubmissionResult = "Please enter a number";
            }
            else
            {   // realized I could just use the out double from the Try Parse and didn't have to convert the weight to a double here, I had already done it. 
                //var weighted = Convert.ToDouble(weight);

                try
                {
                    SubmissionResult = turkey.Recipe(doubleWeight);
                }
                catch
                {
                    SubmissionResult = "TURKEY, WHAT ARE YOU DOING?";
                }
            }
        }
    }
}
