using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Microondas.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : Controller
    { 
        

        [HttpGet]
        [Route("")]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

    }
}
