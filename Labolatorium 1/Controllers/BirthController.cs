using Microsoft.AspNetCore.Mvc;
using Labolatorium_1.Models;

namespace Labolatorium_1.Controllers
{
    public class BirthController : Controller
    {
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result([FromForm] Birth model)
        {
            if (!model.IsValid())
            {
                ViewBag.ErrorMessage = "Proszę podać imię i poprawną datę urodzenia";
                return View("Form", model);
            }

            return View(model);
        }
    }
}