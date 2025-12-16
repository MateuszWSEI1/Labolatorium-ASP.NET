using Microsoft.AspNetCore.Mvc;
using Labolatorium_1.Models;

namespace Labolatorium_1.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Result([FromForm] Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
        
    }
}