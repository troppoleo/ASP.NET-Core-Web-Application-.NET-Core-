using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Learn1.Controllers
{
    public class LoopController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int pTimes = 3)
        {
            ViewData["times"] = pTimes;
            ViewData["What print"] = "Hi!!";
            return View();
        }
    }
}
