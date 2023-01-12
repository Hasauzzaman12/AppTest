using Microsoft.AspNetCore.Mvc;

namespace AppTest.Areas.Admin.Controllers
{
    public class ModuleController : Controller
    {
        public IActionResult Index()
        {
            return View();

            // this controller is for Dymaic module >>
        }
    }
}
