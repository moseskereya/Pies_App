using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pie.Controllers
{
    public class MosesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}