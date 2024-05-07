using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedLib;

namespace IterAddWeb.Pages
{
    public class CalcModel : PageModel
    {
        [BindProperty]
        public int StartValue { get; set; } = 8;

        [BindProperty]
        public int BumpValue { get; set; } = 3;

        [BindProperty]
        public int Iterations { get; set; } = 5;

        public string? Result { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            Result = CalcMethods.SmartAdd(StartValue, BumpValue, Iterations).ToString();
        }
    }
}
