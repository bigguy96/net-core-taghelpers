using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TagHelperCore.Models;

namespace TagHelperCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var vm = new HomeViewModel
            {
                SelectedItems = Enumerable.Range(1, 8)
                    .Select(x => new SelectListItem
                    {
                        Text = x.ToString(),
                        Value = x.ToString()
                    }).ToList()
            };

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
