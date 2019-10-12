using Microsoft.AspNetCore.Mvc;

namespace crudmvc.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        } 
    }
}