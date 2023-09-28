using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.RegularExpressions;
using System.Text.Json.Serialization;
using Microsoft.Extensions.FileSystemGlobbing;

namespace InNOut.Pages
{
    public class OutPageModel : PageModel
    {
        //The path to the stored content
        private static readonly string contentPath = "MessageStorage.txt";
        //Type of the default text file
        private static readonly string TEXT_TYPE = "text/plain";
        /// <summary>
        /// How many lines of the content file is considered a page to a client
        /// It is done so that the client will load content by parts rather everything at once 
        /// </summary>
        private static readonly short LINES_PER_PAGE = 2;

        /// <summary>
        /// Number of client pages
        /// </summary>
        [ViewData]
        public int PageNum
        {
            get => Regex.Matches(
                    System.IO.File.ReadAllText(contentPath),
                    "\n").Count;
        }

        public FileResult OnGetMessage([FromQuery(Name = "page")] int page)
        {
            Console.WriteLine(page);
            //return File(System.IO.File.ReadAllBytes(contentPath).Skip(page).Take(LINES_PER_PAGE).ToArray(), TEXT_TYPE);
            return File(System.IO.File.ReadAllBytes(contentPath), TEXT_TYPE);
        }


        public PageResult OnGetPageNum()
        {
            //Returns number of total pages in the document
            return Page();
        }
    }
}