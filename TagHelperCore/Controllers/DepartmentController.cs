using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagHelperCore.Entities;
using TagHelperCore.Models;

namespace TagHelperCore.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            var departmentViewModel = new DepartmentViewModel()
            {
                Stores = Store.CreateList()
            };            

            return View(departmentViewModel);
        }

        [HttpPost]
        public IActionResult Index(DepartmentViewModel departmentViewModel)
        {
            return View(departmentViewModel);
        }
    }
}