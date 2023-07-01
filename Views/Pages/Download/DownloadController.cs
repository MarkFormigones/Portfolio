using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Starterkit.Views.Pages.Download
{
    public class DownloadController : Controller
    {
        // GET: /<controller>/
        public IActionResult DownloadCV()
        {
            string filePath = "wwwroot/assets/media/pdf/mark-anthony-formigones.pdf";
            string fileName = "Mark Anthony Formigones CV";

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);

            return File(fileBytes, "application/pdf", fileName);
        }
    }
}

