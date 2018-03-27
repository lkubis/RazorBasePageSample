using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorBasePageSample
{
    public abstract class MyBasePage : Page
    {
        public void SetTitle(string message)
        {
            this.PageContext.ViewData["title"] = message;
        }
    }
}