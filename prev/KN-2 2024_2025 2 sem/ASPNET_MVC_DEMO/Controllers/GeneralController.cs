using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_DEMO.Controllers
{
    public class GeneralController : Controller
    {
        public IActionResult UserSecrets()
        {
            return View();
        }
    }
}
