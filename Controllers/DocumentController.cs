using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    public class DocumentController : Controller
    {
        public IActionResult GetDocument()
        {
            return View();
        }
    }
}