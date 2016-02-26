using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using TagHelpers.Model;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
	        ViewBag.SomeStrings = new List<SelectListItem>()
	        {
		        new SelectListItem() {Text = "Hello", Value = "Hello"},
				new SelectListItem() {Text = "Hi", Value = "Hi"},
				new SelectListItem() {Text = "Hey", Value = "Hey"}
			};
			return View(new SomeModel());
        }

		[HttpPost]
	    public IActionResult Index(SomeModel model)
	    {
			if (!ModelState.IsValid)
			{
				return View(model);
			}
			return View("Succes");
	    }
    }
}
