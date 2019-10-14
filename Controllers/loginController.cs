using Microsoft.AspNetCore.Mvc;


namespace crudmvc.Controllers
{
    public class loginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        } 
        public IActionResult Create()
        {
            return View();
        } 
        public IActionResult Admin()
        {
            return View();
        }   
        public IActionResult Visitor()
        {
            return View();
        } 
    }
}