using Microsoft.AspNetCore.Mvc;

namespace EghaamatYaar.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult LoginTo()
        {
            return View();
        }
    }
}
