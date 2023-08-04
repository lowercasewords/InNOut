using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InNOut.Pages
{
	public class InPageModel : PageModel
    {
        public readonly ILogger<InPageModel> _logger;

        public ILogger<InPageModel> Logger
        {
            get
            {
                return _logger;
            }
        }

        public InPageModel(ILogger<InPageModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
    }
}
