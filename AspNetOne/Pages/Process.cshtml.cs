using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetOne.Pages
{
    public class ProcessModel : PageModel
    {
        public Process Process { get; set; }
        public void OnGet()
        {
            Process = Process.GetCurrentProcess();
        }
    }
}
