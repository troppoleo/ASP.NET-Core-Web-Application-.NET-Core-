using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Learn1.Controllers
{
    public class HelloWordController : Controller
    {
        // GET: /<controller>/
        //public string Index(string p1, string p2)
        //{
        //    return System.Text.Encodings.Web.HtmlEncoder.Default.Encode($"Par 1:{p1} par 2:{p2}");
        //}

        public IActionResult Index()
        {
            return View();
        }


    }
}
