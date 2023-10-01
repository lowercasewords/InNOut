using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace InNOut.Pages
{
	public class InPageModel : PageModel
    {
        private static readonly string MESSAGE_URL = "MessageStorage.txt";
        //Appends clients data to the database 
        public void OnPost(string message_title, string message_content)
        {
            using (StreamWriter streamWriter = new StreamWriter(MESSAGE_URL, true))
            {
                streamWriter.WriteLine($"{message_title}:{message_content};");
                streamWriter.Close();
            }
        }
    }
}
