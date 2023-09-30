using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

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

        //Appends clients data to the database 
        public void OnPost(string message_title, string message_content)
        {
            using (StreamWriter streamWriter = new StreamWriter("ContentStorage.txt", true))
            {
                streamWriter.Close();
            }
        }
    }
}
