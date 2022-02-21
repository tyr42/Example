using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WOPS_API.Controllers
{
    [Route("[controller]")]
    public class ProgressController : Controller
    {
        // GET: ProgressController
        [HttpGet("{id}")]
        public ActionResult Index(int id)
        {
            return View(id);
        }

    }
}
