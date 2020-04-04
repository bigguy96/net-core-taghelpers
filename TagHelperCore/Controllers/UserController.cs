using Microsoft.AspNetCore.Mvc;
using TagHelperCore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TagHelperCore.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public IActionResult Index(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {

            }
            
            
            return View(userViewModel);
        }
    }
}
